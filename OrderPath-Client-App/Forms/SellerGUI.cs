using Newtonsoft.Json;
using OrderPath_Client_App.Data;
using OrderPath_Client_App.Data.Seller.QuanLySanPham;
using OrderPath_Client_App.Forms.Sellers;
using OrderPath_Client_App.Forms.Sellers.QuanLyDonHang;
using OrderPath_Client_App.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Http;
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

        private void bttn_guiDelPro_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (dgv_productList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Lấy ID từ dòng đang chọn (Cột đầu tiên - Index 0)
                DataGridViewRow row = dgv_productList.SelectedRows[0];

                // Kiểm tra null để tránh lỗi
                if (row.Cells[0].Value == null) return;

                int id = int.Parse(row.Cells[0].Value.ToString());

                // 3. Khởi tạo form Xóa và  truyền ID
                DeleteProduct delPro = new DeleteProduct();
                delPro.SetProductId(id);
                // 4. Hiện form lên
                delPro.ShowDialog();

                // 5. Sau khi xóa xong (đóng form con), tải lại danh sách
                bttn_guiGetProList_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form xóa: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void bttn_guiConfOrd_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đã chọn dòng nào chưa
            if (dgv_ordList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Lấy ID đơn hàng từ cột đầu tiên (Index 0)
                // Lưu ý: Đảm bảo cột 0 của chứa OrderId
                int orderId = int.Parse(dgv_ordList.SelectedRows[0].Cells[0].Value.ToString());

                // 3. Mở form ConfirmOrder và truyền ID sang
                ConfirmOrder confOrd = new ConfirmOrder();
                confOrd.SetOrderId(orderId); 
                confOrd.ShowDialog();

                // 4. Load lại danh sách sau khi đóng form con để thấy trạng thái mới
                bttn_guiGetOrdList_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Hủy đơn hàng
        private void bttn_guiDelOrd_Click(object sender, EventArgs e)
        {
            if (dgv_ordList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int orderId = int.Parse(dgv_ordList.SelectedRows[0].Cells[0].Value.ToString());

                DeleteOrder delOrd = new DeleteOrder();
                delOrd.SetOrderId(orderId); 
                delOrd.ShowDialog();

                bttn_guiGetOrdList_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgv_productList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) { }

    }
}