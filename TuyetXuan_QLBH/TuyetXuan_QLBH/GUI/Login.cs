using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuyetXuan_QLBH.BALL;
using TuyetXuan_QLBH.MODELL;

namespace TuyetXuan_QLBH.GUI
{
    public partial class Formlogin : Form
    {
        TaiKhoanBAL cusBAL = new TaiKhoanBAL();
        public Formlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TaiKhoanBEL> lstCus = cusBAL.ReadTaiKhoan();
            bool loginSuccess = false;

            foreach (TaiKhoanBEL cus in lstCus)
            {
                if (cus.Username == tbId.Text && cus.Password == tbName.Text)
                {
                    loginSuccess = true;
                    break;
                }
            }

            if (loginSuccess)
            {
                this.Hide();
                var form2 = new Menu();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
             //   MessageBox.Show("Đăng nhập thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {
            tbName.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Xác nhận",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        //private void lbquen_Click(object sender, EventArgs e)
        //{

        //}
    }
}

