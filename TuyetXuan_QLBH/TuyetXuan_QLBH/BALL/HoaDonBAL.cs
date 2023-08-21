using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuyetXuan_QLBH.DALL;
using TuyetXuan_QLBH.MODELL;

namespace TuyetXuan_QLBH.BALL
{
    public class HoaDonBAL
    {
        HoaDonDAL dal = new HoaDonDAL();
        public List<HoaDonBEL> ReadHoaDon()
        {
            List<HoaDonBEL> lstCus = dal.ReadHoaDon();
            return lstCus;
        }

        public void AddHoaDon(HoaDonBEL cus)
        {
            dal.AddHoaDon(cus);
        }
        public void EditHoaDon(HoaDonBEL cus)
        {
            dal.EditHoaDon(cus);
        }
        public void DeleteHoaDon(HoaDonBEL cus)
        {

        }
    }
}
