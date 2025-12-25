using Newtonsoft.Json;
using OrderPath_Client_App.Data;
using OrderPath_Client_App.Data.Seller.QuanLySanPham;
using OrderPath_Client_App.Forms.Sellers;
using OrderPath_Client_App.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace OrderPath_Client_App.Forms
{
    public partial class SellerGUI : Form
    {
        // Cache ảnh để load ảnh
        private Dictionary<string, Image> _imageCache = new Dictionary<string, Image>();

        public SellerGUI()
        {
            InitializeComponent();
            dgv_productList.CellFormatting += Dgv_productList_CellFormatting;
            dgv_productList.CellDoubleClick += Dgv_productList_CellDoubleClick;
        }

        //Hàm xử lý ảnh
        private void Dgv_productList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_productList.Columns[e.ColumnIndex].Name == "ColumnImg" && e.RowIndex >= 0)
            {
                if (e.Value != null)
                {
                    string url = e.Value.ToString();

                    if (_imageCache.ContainsKey(url))
                    {
                        e.Value = _imageCache[url];
                    }
                    else
                    {
                        try
                        {
                            var request = WebRequest.Create(url);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                Image img = Image.FromStream(stream);
                                Image resized = new Bitmap(img, new Size(80, 80));
                                _imageCache[url] = resized;
                                e.Value = resized;
                            }
                        }
                        catch
                        {
                            e.Value = null;
                        }
                    }
                }
            }
        }

        private void bttn_guiAddPro_Click(object sender, EventArgs e)
        {
            AddProduct addPro = new AddProduct();
            addPro.ShowDialog();
            bttn_guiGetProList_Click(null, null);
        }

        // Lưu ý: Phải có từ khóa 'async' ở đây
        private async void bttn_guiDelPro_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã chọn dòng nào chưa
            if (dgv_productList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Lấy ID và Tên sản phẩm từ dòng đang chọn (để hiển thị thông báo cho rõ)
                DataGridViewRow row = dgv_productList.SelectedRows[0];

                if (row.Cells[0].Value == null) return; // Kiểm tra an toàn

                int id = int.Parse(row.Cells[0].Value.ToString());
                string productName = row.Cells[1].Value.ToString(); // Giả sử cột 1 là tên SP

                // 3. Hiện hộp thoại Xác nhận (Yes/No)
                DialogResult confirm = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sản phẩm: {productName}?\nHành động này không thể hoàn tác!",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Nếu người dùng bấm Yes thì mới xóa
                if (confirm == DialogResult.Yes)
                {
                    // 4. Gọi API Xóa trực tiếp
                    var response = await ApiClient.Client.DeleteAsync($"seller/products/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Đã xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5. Load lại danh sách để cập nhật DataGridView (Xóa dòng khỏi bảng)
                        bttn_guiGetProList_Click(null, null);
                    }
                    else
                    {
                        // Đọc lỗi từ Server gửi về (nếu có)
                        string errorMsg = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Không thể xóa. Lỗi từ Server:\n{errorMsg}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttn_guiFixPro_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra chọn dòng
            if (dgv_productList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm trong danh sách để sửa!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgv_productList.SelectedRows[0];
            if (row.Cells[0].Value == null) return;

            try
            {
                // 2. Lấy dữ liệu từ bảng
                int id = int.Parse(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                decimal price = decimal.Parse(row.Cells[2].Value.ToString());
                int quantity = int.Parse(row.Cells[3].Value.ToString());
                string image = row.Cells[4].Value?.ToString() ?? "";

                // 3. Mở form và truyền dữ liệu
                FixProduct fixPro = new FixProduct();
                fixPro.SetProductData(id, name, price, quantity, image, "", "");

                fixPro.ShowDialog();

                // 4. Load lại danh sách sau khi sửa xong
                bttn_guiGetProList_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu dòng: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lấy danh sách sản phẩm
        private async void bttn_guiGetProList_Click(object sender, EventArgs e)
        {
            try
            {
                // Dùng ApiClient đã cấu hình sẵn BaseAddress và Token bên LoginForm
                // Truyền phần đuôi URL
                var response = await ApiClient.Client.GetAsync("seller/products");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<List<ProductResponseDTO>>(jsonString);

                    dgv_productList.Rows.Clear();
                    _imageCache.Clear();

                    if (products != null)
                    {
                        foreach (var p in products)
                        {
                            dgv_productList.Rows.Add(
                                p.Id,
                                p.Name,
                                p.Price,
                                p.Quantity,
                                p.Image,
                                p.Status ? "Active" : "Hidden"
                            );
                        }
                    }
                }
                else
                {
                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        MessageBox.Show("Phiên đăng nhập hết hạn hoặc không có quyền truy cập!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi tải dữ liệu: " + response.ReasonPhrase, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Lấy ds đơn hàng
        private async void bttn_guiGetOrdList_Click(object sender, EventArgs e)
        {
            try
            {
                // Dùng ApiClient gọi API
                var response = await ApiClient.Client.GetAsync("seller/orders");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var orders = JsonConvert.DeserializeObject<List<OrderResponseDTO>>(jsonString);

                    dgv_ordList.Rows.Clear();

                    if (orders != null)
                    {
                        foreach (var o in orders)
                        {
                            dgv_ordList.Rows.Add(
                                o.OrderId,
                                o.CustomerId,
                                o.Total,
                                o.Status,
                                o.Date
                            );
                        }
                    }
                }
                else
                {
                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        MessageBox.Show("Phiên đăng nhập hết hạn hoặc không có quyền truy cập!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi tải đơn hàng: " + response.ReasonPhrase, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Xác nhận đơn hàng
        // Nhớ thêm using System.Text; nếu báo lỗi Encoding
        private async void bttn_guiConfOrd_Click(object sender, EventArgs e)
        {
            if (dgv_ordList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Lấy ID đơn hàng
                int orderId = int.Parse(dgv_ordList.SelectedRows[0].Cells[0].Value.ToString());

                // 2. Hỏi xác nhận
                DialogResult confirm = MessageBox.Show(
                    $"Bạn có muốn xác nhận đơn hàng #{orderId} để bắt đầu giao hàng không?",
                    "Duyệt đơn hàng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    // 3. Tạo dữ liệu gửi đi (Status = "Confirmed" hoặc "Shipping" tùy quy ước của bạn)
                    var bodyData = new { Status = "Confirmed" };
                    string jsonBody = JsonConvert.SerializeObject(bodyData);
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    // 4. Gọi API Cập nhật trạng thái
                    var response = await ApiClient.Client.PutAsync($"seller/orders/{orderId}/status", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Đã duyệt đơn hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bttn_guiGetOrdList_Click(null, null); // Load lại bảng
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + response.ReasonPhrase, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Hủy đơn hàng
        private async void bttn_guiDelOrd_Click(object sender, EventArgs e)
        {
            if (dgv_ordList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Lấy ID
                int orderId = int.Parse(dgv_ordList.SelectedRows[0].Cells[0].Value.ToString());

                // 2. Hỏi xác nhận kỹ hơn (vì hủy là mất doanh thu)
                DialogResult confirm = MessageBox.Show(
                    $"Bạn có chắc chắn muốn HỦY đơn hàng #{orderId} không?\nHành động này không thể hoàn tác!",
                    "Xác nhận hủy",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning // Icon cảnh báo
                );

                if (confirm == DialogResult.Yes)
                {
                    // 3. Gửi trạng thái "Cancelled"
                    var bodyData = new { Status = "Cancelled" };
                    string jsonBody = JsonConvert.SerializeObject(bodyData);
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    // 4. Gọi API
                    var response = await ApiClient.Client.PutAsync($"seller/orders/{orderId}/status", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Đã hủy đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bttn_guiGetOrdList_Click(null, null); // Load lại bảng
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + response.ReasonPhrase, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgv_productList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Kiểm tra dòng hợp lệ (tránh click vào header)
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgv_productList.Rows[e.RowIndex];

                // 2. Lấy dữ liệu từ bảng theo index (Khớp với thứ tự lúc Add dòng ở bttn_guiGetProList_Click)
                int id = int.Parse(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                decimal price = decimal.Parse(row.Cells[2].Value.ToString());
                int quantity = int.Parse(row.Cells[3].Value.ToString());
                string image = row.Cells[4].Value?.ToString() ?? "";

                // Các trường không có trên Grid (Category, Description) thì tạm thời truyền rỗng
                string category = "";
                string description = "";

                // 3. Khởi tạo form ProductDetail và truyền dữ liệu
                ProductDetail detailForm = new ProductDetail();
                detailForm.LoadData(id, name, price, quantity, image, category, description);

                detailForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị chi tiết: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm hỗ trợ Resize ảnh giữ nguyên tỷ lệ (Zoom fit)
        private Image ResizeImageKeepAspectRatio(Image img, int maxWidth, int maxHeight)
        {
            // 1. Tính toán tỷ lệ thu nhỏ
            double ratioX = (double)maxWidth / img.Width;
            double ratioY = (double)maxHeight / img.Height;
            double ratio = Math.Min(ratioX, ratioY); // Lấy tỷ lệ nhỏ hơn để ảnh nằm trọn trong khung

            // 2. Tính kích thước mới
            int newWidth = (int)(img.Width * ratio);
            int newHeight = (int)(img.Height * ratio);

            // 3. Tạo khung ảnh mới (Background trong suốt)
            Bitmap newImage = new Bitmap(maxWidth, maxHeight);

            using (Graphics g = Graphics.FromImage(newImage))
            {
                // Cài đặt chất lượng ảnh cao nhất
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                // 4. Vẽ ảnh vào giữa khung
                int posX = (maxWidth - newWidth) / 2;
                int posY = (maxHeight - newHeight) / 2;

                g.DrawImage(img, posX, posY, newWidth, newHeight);
            }

            return newImage;
        }

        private void dgv_productList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) { }

    }
}