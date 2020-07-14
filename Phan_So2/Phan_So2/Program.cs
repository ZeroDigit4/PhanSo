using System;

namespace Phan_So2
{
    class PhanSo
    {
        public int tu, mau, ts, ms;

        public PhanSo(int x, int y)  // Hàm khởi tạo 2 tham số

        {

            tu = x;

            mau = y;

        }

        public PhanSo(int x)   // hàm khởi tạo 1 tham số

        {

            tu = x;

            mau = 1;

        }
        public PhanSo()  //hàm khởi tạo không tham số

        {

            tu = 0;

            mau = 1;

        }

        public void XuatPhanSo()  // Xuất Phân Số  x/y

        {

            Console.WriteLine("{0}/{1}", tu, mau);
        }

        public PhanSo RutGon()

        {

            ts = tu;

            ms = mau;

            while (tu != mau)

                if (tu > mau) tu = tu - mau;

                else mau = mau - tu;

            ts = ts / tu; ms = ms / tu;

            PhanSo ketqua = new PhanSo(ts, ms);

            return (ketqua);

        }

        public int TuSo { get { return ts; } } 
        //Property TuSo trả về tử số của phân số (đã được tối giản)

        public int MauSo { get { return ms; } }
        //Property MauSo trả về mẫu số nguyên dương(đã được tối giản)

        public void ConvertToString() //trả về chuỗi string dạng “x/y” (đã được tối giản)
        {
            ts = Convert.ToString(tu);
            ms = Convert.ToString(mau);
            Console.WriteLine(ts + "/" + ms);
        }
        public PhanSo CongPS(PhanSo ps1) //tổng của 2 phân số

        {

            int ts = tu * ps1.mau + mau * ps1.tu;

            int ms = mau * ps1.mau;

            PhanSo ketqua = new PhanSo(ts, ms);

            return (ketqua);

        }

        public PhanSo TruPS(PhanSo ps1) //hiệu của 2 phân số

        {

            int ts = tu * ps1.mau - mau * ps1.tu;

            int ms = mau * ps1.mau;

            PhanSo ketqua = new PhanSo(ts, ms);

            return (ketqua);

        }
        public double GiaTri() //giá trị số thực của phân số
        {
            double gia_tri;
            gia_tri = (double)tu / mau;
            return (gia_tri);
        }

        public PhanSo NghichDao() //phân số nghịch đảo
        {
            ts = mau;
            ms = tu;
            if (mau < 0)
            {
                mau = -mau;
                tu = -tu;           
            }
            PhanSo ketqua = new PhanSo(ts, ms);

            return (ketqua);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
