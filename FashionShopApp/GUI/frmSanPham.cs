using FashionShopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FashionShopApp.GUI
{
    public partial class frmSanPham : Form
    {
        SQLConfig config = new SQLConfig();
        string sql;
        public frmSanPham()
        {
            InitializeComponent();


        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadListSanPham();
            LoadCboLoaiSanPham();
            LoadCboTonTai();
            loadSanPhamDGV();
        }
        public void LoadCboLoaiSanPham()
        {
            sql = "SELECT * FROM LoaiSanPham";
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                List<object> items = new List<object>();
                foreach (DataRow dr in dt.Rows)
                {
                    items.Add(new { Text = dr[1].ToString(), Value = dr[0] });
                }

                cbo_LoaiSanPham.DataSource = items;
                cbo_LoaiSanPham.DisplayMember = "Text";
                cbo_LoaiSanPham.ValueMember = "Value";
            }

            cbo_LoaiSanPham.SelectedIndex = -1;
        }
        public void LoadCboTonTai()
        {
            List<object> items = new List<object>
            {
                new { Text = "Tồn tại", Value = 1 },
                new { Text = "Đã xóa", Value = 0 }

            };
            cbo_TonTai.DataSource = items;
            cbo_TonTai.DisplayMember = "Text";
            cbo_TonTai.ValueMember = "Value";

            cbo_TonTai.SelectedIndex = -1;
        }
        public void LoadListSanPham()
        {
            sql = "SELECT S.*, TenLoaiSP FROM SanPham S INNER JOIN LoaiSanPham L ON S.IdLoaiSP = L.IdLoaiSP ORDER BY IdSanPham DESC;";
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                lsv_SanPham.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    if (bool.Parse(dr[12].ToString()) == true)
                    {
                        ListViewItem item = new ListViewItem(new[] { dr[0].ToString() });
                        for (int i = 1; i <= 11; i++)
                        {
                            if (i == 2)
                            {
                                item.SubItems.Add(dr[13].ToString());
                            }
                            else
                                item.SubItems.Add(dr[i].ToString());
                        }

                        if (bool.Parse(dr[12].ToString()) == true)
                        {
                            item.SubItems.Add("Tồn tại");
                        }
                        else
                        {
                            item.SubItems.Add("Đã xóa");
                        }
                        lsv_SanPham.Items.Add(item);
                    }
                }

            }
        }
        void loadSanPhamDGV()
        {
            sql = "SELECT S.*, TenLoaiSP FROM SanPham S INNER JOIN LoaiSanPham L ON S.IdLoaiSP = L.IdLoaiSP ORDER BY IdSanPham DESC;";
            DataTable dt = config.ExecuteSelectQuery(sql);

            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "Mã sản phẩm";
            dgv.Columns[1].HeaderText = "Tên sản phẩm";
            dgv.Columns[2].HeaderText = "Loại sản phẩm";
            dgv.Columns[3].HeaderText = "Ảnh";

            dgv.Columns[4].HeaderText = "Giới tính";
            dgv.Columns[5].HeaderText = "Địa chỉ";
            dgv.Columns[6].HeaderText = "Số ĐT";
            dgv.Columns[7].HeaderText = "Email";
            dgv.AllowUserToAddRows = false;

        }
        private void lsv_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_SanPham.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsv_SanPham.SelectedItems[0];
                txt_IdSanPham.Text = selectedItem.SubItems[0].Text;
                txt_TenSanPham.Text = selectedItem.SubItems[1].Text;
                cbo_LoaiSanPham.Text = selectedItem.SubItems[2].Text;
                imagePath1 = selectedItem.SubItems[3].Text;
                LoadImageIntoPictureBox(imagePath1,ptb_Image1);
                imagePath2 = selectedItem.SubItems[4].Text;
                LoadImageIntoPictureBox(imagePath2, ptb_Image2);
                imagePath3 = selectedItem.SubItems[5].Text;
                LoadImageIntoPictureBox(imagePath3, ptb_Image3);
                txtGiaBan.Text = selectedItem.SubItems[6].Text;
                nmud_GiamGia.Value = int.Parse(selectedItem.SubItems[7].Text);
                txt_SoLuongDanhGia.Text = ConvertNewlinesToCrLf(selectedItem.SubItems[8].Text);
                txt_NoiDungSanPham.Text = ConvertNewlinesToCrLf(selectedItem.SubItems[9].Text);
                txt_DanhGiaSanPham.Text = ConvertNewlinesToCrLf(selectedItem.SubItems[10].Text);
                txt_ThanhToanVanChuyen.Text = selectedItem.SubItems[11].Text;
                cbo_TonTai.Text = selectedItem.SubItems[12].Text;
            }
            else
            {
                ResetSanPham();
            }
        }
        private void ResetSanPham()
        {
            txt_IdSanPham.Text = string.Empty;
            txt_TenSanPham.Text = string.Empty;
            cbo_LoaiSanPham.SelectedIndex = -1;
            ptb_Image1.Image = null;
            ptb_Image2.Image = null;
            ptb_Image3.Image = null;
            txtGiaBan.Text = string.Empty;
            nmud_GiamGia.Value = 0;
            txt_SoLuongDanhGia.Text = string.Empty;
            txt_NoiDungSanPham.Text = string.Empty;
            txt_DanhGiaSanPham.Text = string.Empty;
            txt_ThanhToanVanChuyen.Text = string.Empty;
            cbo_TonTai.SelectedIndex = -1;
        }
        private void LoadImageIntoPictureBox(string imageName, PictureBox ptb)
        {
            try
            {
                string folderPath = "Images";
                string imagePath = System.IO.Path.Combine(folderPath, imageName);
                if (System.IO.File.Exists(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    ptb.Image = image;

                    ptb.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    MessageBox.Show("Tệp ảnh không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetSanPham();
        }
        public static string ConvertNewlinesToCrLf(string input)
        {
            return input.Replace("\\n", "\r\n");
        }
        private string imagePath1 = "";
        private void btn_OpenImage1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ảnh (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imagePath1 = openFileDialog.FileName;
                    ptb_Image1.Image = new System.Drawing.Bitmap(imagePath1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở tệp ảnh: " + ex.Message);
                }
            }
        }
        private string imagePath2 = "";
        private void btn_OpenImage2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ảnh (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imagePath2 = openFileDialog.FileName;
                    ptb_Image2.Image = new System.Drawing.Bitmap(imagePath2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở tệp ảnh: " + ex.Message);
                }
            }
        }

        private string imagePath3 = "";
        private void btn_OpenImage3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ảnh (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imagePath3 = openFileDialog.FileName;
                    ptb_Image3.Image = new System.Drawing.Bitmap(imagePath3);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở tệp ảnh: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin sản phẩm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("UPDATE SanPham SET TenSanPham = N'{0}', IdLoaiSP = {1}, AnhSP = '{2}', AnhSPChiTiet1 = '{3}', AnhSPChiTiet2 = '{4}', GiaBan = {5}, GiamGia = {6}, SoLuongDanhGia = {7}, NoiDungSanPham = N'{8}', DanhGiaSanPham = N'{9}', ThanhToanVanChuyen = N'{10}', TonTai = {11} WHERE IdSanPham = {12}",
                    txt_TenSanPham.Text,
                    cbo_LoaiSanPham.SelectedValue.ToString(),
                    imagePath1,
                    imagePath2,
                    imagePath3,
                    txtGiaBan.Text,
                    nmud_GiamGia.Value.ToString(),
                    txt_SoLuongDanhGia.Text,
                    txt_NoiDungSanPham.Text,
                    txt_DanhGiaSanPham.Text,
                    txt_ThanhToanVanChuyen.Text,
                    cbo_TonTai.SelectedValue.ToString(),
                    txt_IdSanPham.Text);

                if (config.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("Cập nhập thông tin sản phẩm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhập thông tin sản phẩm không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadListSanPham();
            }

        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            sql = string.Format("INSERT INTO SanPham VALUES (N'{0}',{1},'{2}','{3}','{4}',{5},{6},{7},N'{8}',N'{9}',N'{10}',1);",
                txt_TenSanPham.Text,
                cbo_LoaiSanPham.SelectedValue.ToString(),
                imagePath1,
                imagePath2,
                imagePath3,
                txtGiaBan.Text,
                nmud_GiamGia.Value.ToString(),
                txt_SoLuongDanhGia.Text,
                txt_NoiDungSanPham.Text,
                txt_DanhGiaSanPham.Text,
                txt_ThanhToanVanChuyen.Text);

            if (config.ExecuteNonQuery(sql))
            {
                MessageBox.Show("Thêm sản phẩm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadListSanPham();
        }


    }

}
