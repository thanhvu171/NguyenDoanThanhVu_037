using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class HinhChuNhat
    {
        private double _rong;
        private double _dai;

        public HinhChuNhat()
        {

        }
        public HinhChuNhat (double dai, double rong)
        {
            this._rong = rong;
            this._dai = dai;
        }
        public double rong
        {
            set { this._rong = value; }
            get { return rong; }
        }
        public double dai
        {
            set { this._dai = value; }
            get { return dai; }
        }
        public double tinhChuVi()
        {
            return (dai + rong) * 2;
        }
        public double tinhDienTich()
        {
            return dai * rong;
        }
        public void xuat()
        {
            Console.WriteLine(dai);
            Console.WriteLine(rong);
            Console.WriteLine(tinhChuVi());
            Console.WriteLine(tinhDienTich());
        }
    }
    class HinhVuong : HinhChuNhat
    {
        private double _canh;
        public HinhVuong()
        {

        }
        public HinhVuong(double canh)
        {
            this._canh = canh;
        }
        public double canh
        {
            set { this._canh = canh; }
            get { return canh; }
        }
        public double tinhChuViHV()
        {
            return (canh + canh) * 2;
        }
        public double tinhDienTichHV()
        {
            return canh * canh;
        }
        public void xuat(double canh)
        {
            Console.WriteLine(canh);
            Console.WriteLine(tinhDienTichHV());
            Console.WriteLine(tinhChuViHV());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai HCN: ");
            double chieudai = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong HCN: ");
            double chieurong = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh HV: ");
            double canh = double.Parse(Console.ReadLine());
            HinhChuNhat HCN = new HinhChuNhat(dai, rong);
            HinhVuong HV = new HinhVuong(canh);
            HCN.xuat();
            HV.xuat();

            Console.ReadKey();

        }
    }
}
