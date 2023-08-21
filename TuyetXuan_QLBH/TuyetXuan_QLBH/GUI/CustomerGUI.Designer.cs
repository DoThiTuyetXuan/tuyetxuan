
namespace TuyetXuan_QLBH.GUI
{
    partial class CustomerGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbDC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDC = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(82, 221);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(121, 20);
            this.tbMa.TabIndex = 4;
            this.tbMa.TextChanged += new System.EventHandler(this.tbMa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(82, 264);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khu vực";
            // 
            // cbKV
            // 
            this.cbKV.FormattingEnabled = true;
            this.cbKV.Items.AddRange(new object[] {
            "Thành phố Hà Nội",
            "Thành phố Hồ Chí Minh",
            "Thành phố Hải Phòng",
            "Tỉnh Ninh Thuận",
            "Tỉnh Bình Thuận",
            "Tỉnh Kon Tum",
            "Tỉnh Gia Lai",
            "Tỉnh Đắk Lắk",
            "Tỉnh Đắk Nông",
            "Tỉnh Lâm Đồng",
            "Tỉnh Bình Phước",
            "Tỉnh Tây Ninh",
            "Tỉnh Bình Dương",
            "Tỉnh Đồng Nai",
            "Tỉnh Bà Rịa-Vũng Tàu",
            "Tỉnh Long An",
            "Tỉnh Tiền Giang",
            "Tỉnh Bến Tre"});
            this.cbKV.Location = new System.Drawing.Point(425, 289);
            this.cbKV.Margin = new System.Windows.Forms.Padding(2);
            this.cbKV.Name = "cbKV";
            this.cbKV.Size = new System.Drawing.Size(166, 21);
            this.cbKV.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Điện Thoại";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(82, 291);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(121, 20);
            this.tbSDT.TabIndex = 10;
            // 
            // btNew
            // 
            this.btNew.Font = new System.Drawing.Font("Swis721 Hv BT", 8.25F);
            this.btNew.Image = ((System.Drawing.Image)(resources.GetObject("btNew.Image")));
            this.btNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNew.Location = new System.Drawing.Point(121, 369);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(82, 37);
            this.btNew.TabIndex = 11;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Swis721 Hv BT", 8.25F);
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.Location = new System.Drawing.Point(265, 369);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(76, 37);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btEdit.Font = new System.Drawing.Font("Swis721 Hv BT", 8.25F);
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdit.Location = new System.Drawing.Point(407, 369);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(84, 37);
            this.btEdit.TabIndex = 13;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Swis721 Hv BT", 8.25F);
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExit.Location = new System.Drawing.Point(565, 369);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(93, 37);
            this.btExit.TabIndex = 14;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbDC
            // 
            this.lbDC.AutoSize = true;
            this.lbDC.Location = new System.Drawing.Point(360, 226);
            this.lbDC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDC.Name = "lbDC";
            this.lbDC.Size = new System.Drawing.Size(40, 13);
            this.lbDC.TabIndex = 15;
            this.lbDC.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // tbDC
            // 
            this.tbDC.Location = new System.Drawing.Point(425, 223);
            this.tbDC.Name = "tbDC";
            this.tbDC.Size = new System.Drawing.Size(203, 20);
            this.tbDC.TabIndex = 17;
            this.tbDC.TextChanged += new System.EventHandler(this.tbDC_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(425, 255);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(121, 20);
            this.tbEmail.TabIndex = 18;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMa,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.Location = new System.Drawing.Point(37, 35);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(590, 141);
            this.dataGridView.TabIndex = 21;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColMa
            // 
            this.ColMa.HeaderText = "id";
            this.ColMa.MinimumWidth = 6;
            this.ColMa.Name = "ColMa";
            this.ColMa.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ten";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sdt";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DiaChi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "enail";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "KhuVuc";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // CustomerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(668, 422);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbDC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbDC);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerGUI";
            this.Text = "Thongtinkhachhang";
            this.Load += new System.EventHandler(this.CustomerGUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbDC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDC;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}