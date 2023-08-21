
namespace TuyetXuan_QLBH.GUI
{
    partial class SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.tbMa = new System.Windows.Forms.TextBox();
            this.lbma = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbquantity_in_stock = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.dgvsp = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.btFile = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cbKC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(88, 197);
            this.tbMa.Margin = new System.Windows.Forms.Padding(2);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(175, 20);
            this.tbMa.TabIndex = 5;
            this.tbMa.TextChanged += new System.EventHandler(this.tbMa_TextChanged);
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.Location = new System.Drawing.Point(26, 197);
            this.lbma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(22, 13);
            this.lbma.TabIndex = 8;
            this.lbma.Text = "Mã";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(26, 239);
            this.lbten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(26, 13);
            this.lbten.TabIndex = 9;
            this.lbten.Text = "Tên";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(88, 239);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(175, 20);
            this.tbName.TabIndex = 10;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(26, 282);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(23, 13);
            this.lbPrice.TabIndex = 15;
            this.lbPrice.Text = "Giá";
            // 
            // lbquantity_in_stock
            // 
            this.lbquantity_in_stock.AutoSize = true;
            this.lbquantity_in_stock.Location = new System.Drawing.Point(23, 323);
            this.lbquantity_in_stock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbquantity_in_stock.Name = "lbquantity_in_stock";
            this.lbquantity_in_stock.Size = new System.Drawing.Size(49, 13);
            this.lbquantity_in_stock.TabIndex = 16;
            this.lbquantity_in_stock.Text = "Số lượng";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(88, 282);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(175, 20);
            this.txtGia.TabIndex = 17;
            // 
            // btNew
            // 
            this.btNew.Font = new System.Drawing.Font("Swis721 Hv BT", 8.25F);
            this.btNew.Location = new System.Drawing.Point(190, 448);
            this.btNew.Margin = new System.Windows.Forms.Padding(2);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(81, 30);
            this.btNew.TabIndex = 20;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Swis721 Hv BT", 8.25F);
            this.btDelete.Location = new System.Drawing.Point(300, 448);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(81, 30);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Swis721 Hv BT", 8.25F);
            this.btEdit.Location = new System.Drawing.Point(421, 448);
            this.btEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(81, 30);
            this.btEdit.TabIndex = 22;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Swis721 Hv BT", 8.25F);
            this.btExit.Location = new System.Drawing.Point(535, 448);
            this.btExit.Margin = new System.Windows.Forms.Padding(2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(81, 30);
            this.btExit.TabIndex = 23;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // dgvsp
            // 
            this.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colName,
            this.colPrice,
            this.colQuantityInStock,
            this.colImage,
            this.ColKC});
            this.dgvsp.Location = new System.Drawing.Point(9, 2);
            this.dgvsp.Margin = new System.Windows.Forms.Padding(2);
            this.dgvsp.Name = "dgvsp";
            this.dgvsp.RowHeadersWidth = 51;
            this.dgvsp.RowTemplate.Height = 24;
            this.dgvsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsp.Size = new System.Drawing.Size(660, 167);
            this.dgvsp.TabIndex = 24;
            this.dgvsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsp_CellContentClick_1);
            // 
            // colProductID
            // 
            this.colProductID.HeaderText = "Mã";
            this.colProductID.MinimumWidth = 6;
            this.colProductID.Name = "colProductID";
            this.colProductID.Width = 125;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 125;
            // 
            // colQuantityInStock
            // 
            this.colQuantityInStock.HeaderText = "Số lượng";
            this.colQuantityInStock.MinimumWidth = 6;
            this.colQuantityInStock.Name = "colQuantityInStock";
            this.colQuantityInStock.Width = 125;
            // 
            // colImage
            // 
            this.colImage.HeaderText = "Image";
            this.colImage.MinimumWidth = 6;
            this.colImage.Name = "colImage";
            this.colImage.Width = 125;
            // 
            // ColKC
            // 
            this.ColKC.HeaderText = "Kích Cỡ";
            this.ColKC.MinimumWidth = 6;
            this.ColKC.Name = "ColKC";
            this.ColKC.Width = 125;
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(88, 318);
            this.tbSL.Margin = new System.Windows.Forms.Padding(2);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(175, 20);
            this.tbSL.TabIndex = 25;
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(300, 348);
            this.btFile.Margin = new System.Windows.Forms.Padding(2);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(176, 27);
            this.btFile.TabIndex = 27;
            this.btFile.Text = "chọn ảnh";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(300, 185);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(176, 151);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 28;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // cbKC
            // 
            this.cbKC.FormattingEnabled = true;
            this.cbKC.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cbKC.Location = new System.Drawing.Point(88, 360);
            this.cbKC.Margin = new System.Windows.Forms.Padding(2);
            this.cbKC.Name = "cbKC";
            this.cbKC.Size = new System.Drawing.Size(175, 21);
            this.cbKC.TabIndex = 29;
            this.cbKC.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kích Cỡ";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKC);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.dgvsp);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lbquantity_in_stock);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.lbma);
            this.Controls.Add(this.tbMa);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SanPham";
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.gd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvsp_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label lbma;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbquantity_in_stock;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dgvsp;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cbKC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKC;
    }
}