using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class NhanVien
    {
        private string _hoTen;
        private int _songaycong;
        private int _songaylamthem;
        private string _xeploai;
        private string _bophan;

        public NhanVien()
        {
        }
        public NhanVien(string hoten, int songaycong, int songaylamthem, string xeploai, string bophan)
        {
            this._hoTen = hoten;
            this._songaycong = songaycong;
            this._songaylamthem = songaylamthem;
            this._xeploai = xeploai;
            this._bophan = bophan;
        }
        public string hoten
        {
            set { this.hoten = value; }
            get { return hoten; }
        }
        public int songaycong
        {
            set { this.songaycong = value; }
            get { return songaycong; }
        }
        public int songaylamthem
        {
            set { this.songaylamthem = value; }
            get { return songaylamthem; }
        }
        public string xeploai
        {
            set { this.xeploai = value; }
            get { return xeploai; }
        }
        public string bophan
        {
            set { this.bophan = value; }
            get { return bophan; }
        }
        public double congThucluong()
        {
            int tangluong = 0;
            int luong1ngay = 100;
            if (bophan is "truc tiep")
                tangluong = 3;
            else if(bophan is "gian tiep")
                tangluong = 2;
            return (songaycong + songaylamthem * tangluong) * luong1ngay;
        }
        public void inthongtin()
        {
            double thunhap = 0;
            double luong;
            luong = congThucluong();
            if (xeploai is "A")
                thunhap = luong * 1.5;
            else if (xeploai is "B")
                thunhap = luong * 1.2;
            else if(xeploai is "C")
                thunhap = luong;
            Console.WriteLine("Ho va ten nhan vien: {0}",hoten);
            Console.WriteLine("Bo phan nhan vien: {0}",bophan);
            Console.WriteLine("Thu nhap: {0}",thunhap);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien NV1;
            NV1 = new NhanVien();
            Console.Write("Nhap ho ten nhan vien: ");
            string hoten = Console.ReadLine();
            Console.Write("Nhap so ngay cong cua nhan vien: ");
            int songaycong = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay lam them cua nhan vien: ");
            int songaylamthem = int.Parse(Console.ReadLine());
            Console.Write("Xep loai cua nhan vien: ");
            string xeploai = Console.ReadLine();
            Console.Write("Bo phan cua nhan vien: ");
            string bophan = Console.ReadLine();

            double luong = NV1.congThucluong();
            Console.WriteLine("Luong cua nhan vien: {0}", luong);
            NV1.inthongtin();
            Console.ReadKey();
        }
    }
}
