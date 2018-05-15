using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DTO;

namespace TNTA.DAO
{
    class SinhVienDAO
    {
        public static List<SinhVien> LoadDSSinhVien()
        {
            List<SinhVien> listSV = new List<SinhVien>();
            String querry = "Select * From SinhVien";
            DataTable DT = new DataTable();
            DT = DataProvider.instanse.Executequerry(querry);
            if (DT.Rows.Count == 0) return null;
            else
            {
                foreach (DataRow item in DT.Rows)
                {
                    SinhVien Sv = new SinhVien(item);
                    // String[] arr = Sv.NgaySinh.Split(' ');
                    // Sv.NgaySinh = arr[0];

                    //String.Format("{0:MM/dd/yyyy}",Sv.NgaySinh);
                    listSV.Add(Sv);
                }
                return listSV;
            }

        }
        public static List<SinhVien> LoadSVKyThi(int MaKyThi)
        {

            List<SinhVien> listSV = new List<SinhVien>();
            String querry = "Select * From SinhVien,Sv_KyThi where SinhVien.MaSV=SV_KyThi.MaSV and  MaTTKT=" + MaKyThi;
            DataTable DT = new DataTable();
            DT = DataProvider.instanse.Executequerry(querry);


            if (DT.Rows.Count == 0) return null;
            else
            {
                foreach (DataRow item in DT.Rows)
                {
                    SinhVien Sv = new SinhVien(item);
                    // String[] arr = Sv.NgaySinh.Split(' ');
                    // Sv.NgaySinh = arr[0];

                    //String.Format("{0:MM/dd/yyyy}",Sv.NgaySinh);
                    listSV.Add(Sv);
                }
                return listSV;
            }
        }
        public static List<SinhVien> LoadDSSinhVien_TheoKhoa(int MaKhoa)
        {
            List<SinhVien> listSV = new List<SinhVien>();
            String querry = "Select MaSV,HoVaTen,NgaySinh,GioiTinh,SDT,Email,SinhVien.MaLop  From SinhVien,Lop where SinhVien.MaLop=Lop.MaLop and Lop.MaKhoa =" + MaKhoa;
            DataTable DT = new DataTable();
            DT = DataProvider.instanse.Executequerry(querry);
            if (DT.Rows.Count == 0) return null;
            else
            {
                foreach (DataRow item in DT.Rows)
                {
                    SinhVien Sv = new SinhVien(item);
                    // String[] arr = Sv.NgaySinh.Split(' ');
                    // Sv.NgaySinh = arr[0];

                    //String.Format("{0:MM/dd/yyyy}",Sv.NgaySinh);
                    listSV.Add(Sv);
                }
                return listSV;
            }

        }
        public static List<SinhVien> LoadSVkoTrongKyThi(int MaKyThi)
        {

            List<SinhVien> listSV = new List<SinhVien>();
            String querry = " Select * From SinhVien where MaSV not in (select SinhVien.MaSV  from SinhVien,Sv_KyThi where SinhVien.MaSV=SV_KyThi.MaSV and  MaTTKT= " + MaKyThi + ")";
            DataTable DT = new DataTable();
            DT = DataProvider.instanse.Executequerry(querry);


            if (DT.Rows.Count == 0) return null;
            else
            {
                foreach (DataRow item in DT.Rows)
                {
                    SinhVien Sv = new SinhVien(item);
                    // String[] arr = Sv.NgaySinh.Split(' ');
                    // Sv.NgaySinh = arr[0];

                    //String.Format("{0:MM/dd/yyyy}",Sv.NgaySinh);
                    listSV.Add(Sv);
                }
                return listSV;
            }
        }
        public static List<SinhVien> TimKiem(string name)
        {
            List<SinhVien> listSV = new List<SinhVien>();
            String querry = "Select * From SinhVien where HoVaTen like N'%" + name + "%'";
            DataTable DT = new DataTable();
            DT = DataProvider.instanse.Executequerry(querry);
            if (DT.Rows.Count == 0) return null;
            else
            {
                foreach (DataRow item in DT.Rows)
                {
                    SinhVien Sv = new SinhVien(item);
                    // String[] arr = Sv.NgaySinh.Split(' ');
                    // Sv.NgaySinh = arr[0];

                    //String.Format("{0:MM/dd/yyyy}",Sv.NgaySinh);
                    listSV.Add(Sv);
                }
                return listSV;
            }
        }
        public static List<SinhVien> TimKiem_MSV(string name)
        {
            List<SinhVien> listSV = new List<SinhVien>();
            String querry = "Select * From SinhVien where MaSV like N'%" + name + "%'";
            DataTable DT = new DataTable();
            DT = DataProvider.instanse.Executequerry(querry);
            if (DT.Rows.Count == 0) return null;
            else
            {
                foreach (DataRow item in DT.Rows)
                {
                    SinhVien Sv = new SinhVien(item);
                    // String[] arr = Sv.NgaySinh.Split(' ');
                    // Sv.NgaySinh = arr[0];

                    //String.Format("{0:MM/dd/yyyy}",Sv.NgaySinh);
                    listSV.Add(Sv);
                }
                return listSV;
            }
        }
        public static void AddSV(string MaSv, String HoVaten, string GioiTinh, string NgaySinh, int SDT, string Email, int Malop)
        {

            string querry = "insert into SinhVien values(N'" + MaSv + "',N'" + HoVaten + "'," + NgaySinh + ",N'" + GioiTinh + "'," + SDT + ",N'" + Email + "'," + Malop + ")";
            DataProvider.instanse.ExecuteNonquerry(querry);



        }
        public static void EditSV(string MaSv, String HoVaten, string GioiTinh, string NgaySinh, int SDT, string Email, int Malop)
        {
            string querry = "update SinhVien set HoVaTen=N'" + HoVaten + "', NgaySinh=" + NgaySinh + ",GioiTinh=N'" + GioiTinh + "', SDT=" + SDT + ", Email=N'" + Email + "', MaLop=" + Malop + "Where MaSV=" + MaSv;
            DataProvider.instanse.ExecuteNonquerry(querry);

        }
        public static void EditSV1(string MaSv, String HoVaten, string GioiTinh, string NgaySinh, int SDT, string Email)
        {
            string querry = "update SinhVien set HoVaTen=N'" + HoVaten + "', NgaySinh=" + NgaySinh + ",GioiTinh=N'" + GioiTinh + "', SDT=" + SDT + ", Email=N'" + Email + "' Where MaSV=" + MaSv;
            DataProvider.instanse.ExecuteNonquerry(querry);

        }
        public static void DeleteSV(string MaSV)
        {
            string querry = "Delete SinhVien where MaSV=" + MaSV;
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
    }
}
