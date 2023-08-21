﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuyetXuan_QLBH.BALL;
using TuyetXuan_QLBH.MODELL;

namespace TuyetXuan_QLBH.GUI
{
    public partial class SanPham : Form
    {
        string nameimg;


        PictureBox pb = new PictureBox();
        SanPhamBAL cusBAL1 = new SanPhamBAL();

        public SanPham()
        {
            InitializeComponent();
            DataGridViewImageColumn colImage = new DataGridViewImageColumn();

            dgvsp.CellClick += dgvsp_CellClick;
        }
        string img;
        private void ResetInputFields()
        {
            tbMa.Text = string.Empty;
            tbName.Text = string.Empty;
            txtGia.Text = string.Empty;
            tbSL.Text = string.Empty;
            nameimg = string.Empty;
            cbKC.SelectedIndex = -1; // Reset the selected index of the combo box

            // ... (rest of the code)
        }
        private void CheckDataAvailability()
        {
            bool dataAvailable = dgvsp.Rows.Count > 0;

            // Disable or hide the buttons based on data availability
            btNew.Enabled = dataAvailable;
            btDelete.Enabled = dataAvailable;
            btEdit.Enabled = dataAvailable;
        }
        private void dgvsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvsp.Rows[e.RowIndex];

                // Check if the clicked cell is empty (null or empty string)
                if (selectedRow.Cells[e.ColumnIndex].Value == null || string.IsNullOrEmpty(selectedRow.Cells[e.ColumnIndex].Value.ToString()))
                {
                    // The cell is empty, so reset the input fields
                    ResetInputFields();
                }
                else
                {
                    // Extract data from the selected row
                    int productId = Convert.ToInt32(selectedRow.Cells["colProductID"].Value);
                    string name = selectedRow.Cells["colName"].Value.ToString();
                    int price = Convert.ToInt32(selectedRow.Cells["colPrice"].Value);
                    int quantityInStock = Convert.ToInt32(selectedRow.Cells["colQuantityInStock"].Value);
                    string image = selectedRow.Cells["colImage"].Value.ToString();
                    string KhuVuc = selectedRow.Cells["ColKC"].Value.ToString();
                    // Display the data in the input fields
                    tbMa.Text = productId.ToString();
                    tbName.Text = name;
                    txtGia.Text = price.ToString();
                    tbSL.Text = quantityInStock.ToString();
                    cbKC.Text = KhuVuc;
                    if (image != null)
                    {
                        img = image;
                    }

                    if (File.Exists(@"E:\TuyetXuan_QLBH\TuyetXuan_0084\TuyetXuan_0084\img" + img))
                    {
                        // Hiển thị hình ảnh trong PictureBox
                        pictureBox.Image = new Bitmap(@"E:\TuyetXuan_QLBH\TuyetXuan_0084\TuyetXuan_0084\img" + img);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        pictureBox.Image = null;
                    }
                }
            }
            else
            {
                // Reset input fields when no valid row is clicked
                ResetInputFields();
            }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)

        {

        }


        private void btNew_Click(object sender, EventArgs e)
        {
            //Check if all required fields are filled
            if (string.IsNullOrEmpty(tbMa.Text) || string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(txtGia.Text) || string.IsNullOrEmpty(tbSL.Text) || string.IsNullOrEmpty(nameimg))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if any required field is missing
            }
            // Reset input fields and combo box selection to their default values

            int ma;
            if (!int.TryParse(tbMa.Text, out ma) || ma < 0)
            {
                MessageBox.Show("Mã sản phẩm phải là số nguyên không âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsProductIDAlreadyExists(ma))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng nhập mã khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int price;
            if (!int.TryParse(txtGia.Text, out price))
            {
                MessageBox.Show("Giá sản phẩm phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantity;
            if (!int.TryParse(tbSL.Text, out quantity))
            {
                MessageBox.Show("Số lượng sản phẩm phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = tbName.Text;
            if (string.IsNullOrEmpty(name) || name.Length > 15 || !char.IsUpper(name[0]))
            {
                MessageBox.Show("Tên không hợp lệ! Tên sản phẩm phải bắt đầu bằng ký tự viết hoa và tối đa 15 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If all required fields are filled and data is valid, proceed with adding the product
            SanPhamBEL cus = new SanPhamBEL();
            cus.id = ma;
            cus.name = tbName.Text;
            cus.price = price;
            cus.quantity_in_stock = quantity;
            cus.Image = nameimg;
            cus.KichCo = cbKC.Text;

            cusBAL1.AddSanPham(cus);
            dgvsp.Rows.Add(cus.id, cus.name, cus.price, cus.quantity_in_stock, cus.Image, cus.KichCo);
            MessageBox.Show("Sản phẩm đã được thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset input fields and combo box selection to their default values
            ResetInputFields();
        }


        private bool IsProductIDAlreadyExists(int id)
        {
            foreach (DataGridViewRow row in dgvsp.Rows)
            {
                int existingID = Convert.ToInt32(row.Cells["colProductID"].Value);
                if (existingID == id)
                {
                    return true; // ID already exists
                }
            }
            return false;
        }

        private bool IsDataAlreadyExists(int id, string name, int price, int quantity, string kichco)
        {
            foreach (DataGridViewRow row in dgvsp.Rows)
            {
                int existingID = Convert.ToInt32(row.Cells["colProductID"].Value);
                string existingName = row.Cells["colName"].Value.ToString();
                int existingPrice = Convert.ToInt32(row.Cells["colPrice"].Value);
                int existingQuantity = Convert.ToInt32(row.Cells["colQuantityInStock"].Value);
                string existingKichCo = row.Cells["ColKC"].Value.ToString();

                if (existingID == id && existingName == name && existingPrice == price && existingQuantity == quantity && existingKichCo == kichco)
                {
                    return true; // Data already exists
                }
            }
            return false;

        }
        private void btDelete_Click(object sender, EventArgs e)
        {

            if (dgvsp.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SanPhamBEL cus = new SanPhamBEL();
            cus.id = int.Parse(tbMa.Text);
            cusBAL1.DeleteSanPham(cus);
            int idx = dgvsp.CurrentCell.RowIndex;
            dgvsp.Rows.RemoveAt(idx);
            MessageBox.Show("Sản phẩm đã được xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Reset input fields and combo box selection to their default values
            ResetInputFields();
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            // Check if any row is selected for editing
            if (dgvsp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dgvsp.SelectedRows[0]; // Get the first selected row

            // Extract data from the selected row
            int productId = Convert.ToInt32(selectedRow.Cells["colProductID"].Value);
            string currentImage = selectedRow.Cells["colImage"].Value.ToString();

            // Check if the ID field has been modified
            if (productId != int.Parse(tbMa.Text))
            {
                MessageBox.Show("Không thể thay đổi ID của sản phẩm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new SanPhamBEL object with the updated data
            SanPhamBEL cus = new SanPhamBEL();
            cus.id = productId; // Use the current ID
            cus.name = tbName.Text;
            cus.price = int.Parse(txtGia.Text);
            cus.quantity_in_stock = int.Parse(tbSL.Text);
            cus.KichCo = cbKC.Text;
            if (!string.IsNullOrEmpty(nameimg))
            {
                cus.Image = nameimg; // Use the new image if selected
            }
            else
            {
                cus.Image = currentImage; // Use the current image if no new image selected
            }

            // Call the EditSanPham method to update the database
            cusBAL1.EditSanPham(cus);

            // Get the index of the currently selected row in the DataGridView
            int rowIndex = selectedRow.Index;

            // Update the row in the DataGridView with the edited data
            dgvsp.Rows[rowIndex].Cells["colName"].Value = cus.name;
            dgvsp.Rows[rowIndex].Cells["colPrice"].Value = cus.price;
            dgvsp.Rows[rowIndex].Cells["colQuantityInStock"].Value = cus.quantity_in_stock;
            dgvsp.Rows[rowIndex].Cells["colImage"].Value = cus.Image; // Update the image column
            dgvsp.Rows[rowIndex].Cells["colKC"].Value = cus.KichCo;
            MessageBox.Show("Sản Phâm đã được cập nhật!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset input fields to their default values
            ResetInputFields();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                // Get the file size in bytes
                long fileSize = new FileInfo(selectedImagePath).Length;

                string targetDirectory = @"E:\drawable\";
                string targetFileName = Path.Combine(targetDirectory, Path.GetFileName(selectedImagePath));

                nameimg = Path.GetFileName(selectedImagePath);

                File.Copy(selectedImagePath, targetFileName, true);

                pictureBox.Image = new Bitmap(openFileDialog.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = new Bitmap(openFileDialog.FileName);
            }
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Xác nhận",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvsp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row (not a header row) is clicked
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvsp.Rows[e.RowIndex];

                // Extract data from the selected row
                int productId = Convert.ToInt32(selectedRow.Cells["colProductID"].Value);
                string name = selectedRow.Cells["colName"].Value.ToString();
                int price = Convert.ToInt32(selectedRow.Cells["colPrice"].Value);
                int quantityInStock = Convert.ToInt32(selectedRow.Cells["colQuantityInStock"].Value);
                string Image = selectedRow.Cells["colImage"].Value.ToString();
                string KhuVuc = selectedRow.Cells["ColKC"].Value.ToString(); // Correct column name

                // Display the data in the input fields
                tbMa.Text = productId.ToString();
                tbName.Text = name;
                txtGia.Text = price.ToString();
                tbSL.Text = quantityInStock.ToString();
                cbKC.Text = KhuVuc; // Set the text property of the combo box to the Kích Cỡ (KhuVuc)

                if (Image != null)
                {
                    img = selectedRow.Cells["colImage"].Value.ToString();
                }

                if (File.Exists(@"E:\drawable\" + img))
                {
                    // Hiển thị hình ảnh trong PictureBox
                    pictureBox.Image = new Bitmap(@"E:\TuyetXuan_QLBH\TuyetXuan_0084\TuyetXuan_0084\img\" + img);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox.Image = null;
                }
            }
        }
        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tbMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void gd_Load(object sender, EventArgs e)
        {
            List<SanPhamBEL> lstCus = cusBAL1.ReadSanPham();
            foreach (SanPhamBEL cus in lstCus)
            {
                dgvsp.Rows.Add(cus.id, cus.name, cus.price, cus.quantity_in_stock, cus.Image, cus.KichCo);

            }

            // Reset input fields and combo box selection to their default values
            ResetInputFields();
        }
        //private void txtTK_TextChanged(object sender, EventArgs e)
        //{
        //    dgvsp.Rows.Clear();
        //    SanPhamBEL cus = new SanPhamBEL();
        //    cus.name = txtTK.Text;
        //    List<SanPhamBEL> lstCus = cusBAL1.Timkiem(cus);
        //    foreach (SanPhamBEL c in lstCus)
        //    {
        //        dgvsp.Rows.Add(c.id, c.name, c.price, c.quantity_in_stock, c.Image, c.KichCo);
        //    }
        //}

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        //private void lbTK_Click(object sender, EventArgs e)
        //{

        //}
    }
}

