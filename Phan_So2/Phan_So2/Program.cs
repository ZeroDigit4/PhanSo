using System;

namespace Phan_So2
{
    class PhanSo
    {
        public int tu, mau;

        public PhanSo(int x, int y)  // Hàm khởi tạo 2 tham số

        {

            tu = x;

            mau = y;

        }

        public PhanSo(int x)   // Hàm khởi tạo 1 tham số

        {

            tu = x;

            mau = 1;

        }
        public PhanSo()  // Hàm khởi tạo không tham số

        {

            tu = 0;

            mau = 1;

        }

        public void XuatPhanSo()  // Xuất Phân Số  x/y

        {

            Console.WriteLine("{0}/{1}", tu, mau);
        }

        public PhanSo RutGon() // Rút gọn phân số

        {

            int ts = tu;

            int ms = mau;

            if (tu < 0) tu = -tu;

            if (mau < 0) mau = -mau;

            while (tu != mau)
            {

                if (tu > mau) tu = tu - mau;

                else mau = mau - tu;

            }

            ts = ts / tu; ms = ms / tu;

            PhanSo ketqua = new PhanSo(ts, ms);

            return ketqua;

        }

        public string ConvertToString(int x, int y) // Trả về chuỗi string dạng “x/y” (đã được tối giản)
      
        {
            
            String ts = Convert.ToString(x);
            
            String ms = Convert.ToString(y);
           
            String Ps = ts + "/" + ms;
           
            return Ps;
        }
        public PhanSo Cong(PhanSo ps) // Tổng của 2 phân số

        {

            int ts = tu * ps.mau + mau * ps.tu;

            int ms = mau * ps.mau;

            PhanSo ketqua = new PhanSo(ts, ms);

            return ketqua;

        }

        public PhanSo Tru(PhanSo ps) // Hiệu của 2 phân số

        {

            int ts = tu * ps.mau - mau * ps.tu;

            int ms = mau * ps.mau;

            PhanSo ketqua = new PhanSo(ts, ms);

            return ketqua;

        }
        public double GiaTri(int x, int y) // Giá trị số thực của phân số
      
        {

           
            double gia_tri = (double)x / y;
          
            return gia_tri;
       
        }

        public PhanSo NghichDao() // Phân số nghịch đảo
       
        {
            
            int ts = mau;
           
            int ms = tu;
            
            if (ms < 0)
           
            {
            
                ms = -ms;
            
                ts = -ts;           
          
            }

            PhanSo ketqua = new PhanSo(ts, ms);

            return ketqua;

        }
    }
    class Program
    {
        static void Main(string[] args)
       
        {
            PhanSo ps = new PhanSo(-10, 4);
            
            PhanSo ps1 = new PhanSo(5);
            
            PhanSo ps2 = new PhanSo();                   

            Console.WriteLine("Khởi tạo phân số x/y "); ps.XuatPhanSo();

            Console.WriteLine("Khởi tạo phân số x/1 "); ps1.XuatPhanSo();

            Console.WriteLine("Khởi tạo phân số 0/1 "); ps2.XuatPhanSo();

            ps2 = ps.RutGon();

            Console.WriteLine("Rút gọn phân số x/y"); ps2.XuatPhanSo();

            Console.WriteLine("Tử số rút gọn \n" + ps2.tu);

            Console.WriteLine("Mẫu số rút gọn \n" + ps2.mau);

            string convert = ps2.ConvertToString(ps2.tu, ps2.mau);

            Console.WriteLine("Chuyển phân số x/y về dạng chuỗi \n" + "\"" + convert + "\"");

            PhanSo tong = new PhanSo();

            tong = ps2.Cong(ps1);

            Console.Write("Tổng của 2 phân số x/y và x/1 \n"); tong.XuatPhanSo();

            PhanSo hieu = new PhanSo();

            hieu = ps2.Tru(ps1);

            Console.Write("Hiệu của 2 phân số x/y và x/1 \n"); hieu.XuatPhanSo();

            double gia_tri = ps2.GiaTri(ps2.tu, ps2.mau);

            Console.WriteLine("Giá trị thực của phân số x/y \n" + gia_tri); 

            ps1 = ps2.NghichDao();

            Console.WriteLine("Nghịch đảo phân số x/y"); ps1.XuatPhanSo();
      
        }
   
    }

}
