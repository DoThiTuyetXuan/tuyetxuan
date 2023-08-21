using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuyetXuan_QLBH.GUI
{
    internal class EditSupplier
    {
        private string ma;
        private string ten;
        private string sdt;
        private string diachi;
        private string email;
        private string khuVuc;

        public EditSupplier(string ma, string ten, string sdt, string diachi, string email, string khuVuc)
        {
            this.ma = ma;
            this.ten = ten;
            this.sdt = sdt;
            this.diachi = diachi;
            this.email = email;
            this.khuVuc = khuVuc;
        }

        internal DialogResult ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}