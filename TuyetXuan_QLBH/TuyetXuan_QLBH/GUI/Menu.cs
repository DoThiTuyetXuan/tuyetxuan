using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuyetXuan_QLBH.GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanPham t1 = new SanPham();
            t1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerGUI t2 = new CustomerGUI();
            t2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.ShowDialog();
        }
    }
}
