using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_LTDT_PKMT_1
{
    internal class XuLyDoThi
    {
        public static void XuatMaTranDoThi(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void XacDinhThanhPhanLienThongManh_ChiMucCacDinh()
        {   
            
        }
        public static int CayKhung_TrongSo()
        {
            int trongsocaykhung = 0;
            return trongsocaykhung;

        }
        public static void GiaiThuatPrim()
        {
            int DinhBatDau_Prim = XuLyKieuSo.NhapSo("đỉnh bắt đầu: ");
            //Xuất ra thông tin của cây khung
            //Xuất trọng số của cây khung

        }
        public static void GiaiThuatKruskal()
        {
            XuLyKieuSo.NhapSo("đỉnh bắt đầu: ");
            //Xuất ra thông tin của cây khung
            //Xuất trọng số của cây khung
        }        
        public static void TimCayKhungLonNhat()
        {
            XuLyKieuSo.NhapSo("đỉnh bắt đầu: ");
            //Xuất ra thông tin của cây khung
            //Xuất trọng số của cây khung
        }
        public static void GiaiThuatFloyd_Warshall()
        {

        }
        public static void DuongDiNganNhat(int DinhA, int DinhB)
        {

        }
        public static void XacDinhChuTrinhEuler(int DinhA, int DinhB)
        {
            //Kiểm tra đồ thị có tính chất Euler hay không

            //Nếu có tính chất Euler thì nhập đỉnh bắt đầu
            int DinhBatDau_Euler = XuLyKieuSo.NhapSo("đỉnh bắt đầu: ");
            //Nếu tồn tại lời giải thì in ra chuỗi đỉnh thuộc về chu trình
            //Ngược lại thông báo "Không có lời giải"

            //Nếu có tính chất Nửa Euler thì nhập đỉnh bắt đầu
            int DinhBatDau_NuaEuler = XuLyKieuSo.NhapSo("đỉnh bắt đầu: ");
            //Nếu tồn tại lời giải thì in ra chuỗi đỉnh thuộc về chu trình
            //Ngược lại thông báo "Không có lời giải"
        }
    }
}
