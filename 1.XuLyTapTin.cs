using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_LTDT_PKMT_1
{
    internal class XuLyTapTin
    {       
        public static void KiemTraTapTinTonTai(string DuongDanTapTin)
        {            
            if (!File.Exists(DuongDanTapTin))
            {
                Console.WriteLine("Duong Dan Tap Tin Khong Ton Tai");                
            }
            else
            {
                XuLyKieuString.QuayLaiMENU();
            }            
        }
        
        public static bool KiemTraDoThiHopLy()
        {
            return true;
        }


    }
}
