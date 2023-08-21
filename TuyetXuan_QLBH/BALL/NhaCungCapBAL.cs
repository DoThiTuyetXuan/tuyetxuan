using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuyetXuan_QLBH.DALL;
using TuyetXuan_QLBH.MODELL;

namespace TuyetXuan_QLBH.BALL
{
    public class NhaCungCapBAL
    {
        NhaCungCapDAL dal = new NhaCungCapDAL();
        public List<NhaCungCapBEL> ReadNhaCungCap()
        {
            List<NhaCungCapBEL> lstCus = dal.ReadNhaCungCap();
            return lstCus;
        }

        public void NewNhaCungCap(NhaCungCapBEL cus)
        {
            dal.NewNhaCungCap(cus);
        }
        public void EditNhaCungCap(NhaCungCapBEL cus)
        {
            dal.EditNhaCungCap(cus);
        }
        public void DeleteNhaCungCap(NhaCungCapBEL cus)
        {
            dal.DeleteNhaCungCap(cus);
        }



    }
}
