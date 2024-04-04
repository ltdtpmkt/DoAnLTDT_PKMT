using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_LTDT_PKMT_1
{
    internal class XuLyKieuSo
    {
        //Nhập số, kiểm tra có phải là số hay không, nếu là khoảng trắng hoặc để trống thì trả về giá trị 0
        public static int NhapSo(string tenBien)
        {
            int kq = 0;
            bool dieukien = false;
            string str = "";

            do
            {
                Console.Write($" >Nhập {tenBien}: ");
                str = string.Concat(Console.ReadLine());
                try
                {
                    if (string.IsNullOrWhiteSpace(str))
                    {
                        kq = 0;
                        break;
                    }
                    else
                    {
                        kq = int.Parse(str);
                    }
                    dieukien = true;
                }
                catch (FormatException)
                {
                    Console.Write($"*Ghi chú: {tenBien} không phải dạng số. Đề nghị nhập lại: \n");
                }
            } while (!dieukien);

            return kq;
        }
    }
}
