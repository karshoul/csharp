﻿using System;
using System.Linq;

namespace CS_hello_world
{
    class Program
    {
        /*
            Đây là hàm Main
            Điểm chạy chương trình
        */
        static void Main(string[] args)
        {
            //  string loichao; //null
            //  string ten = "Khuong Nguyen";
            //  loichao = "Xin chao";

            //  string thongbao = loichao + " " + ten; 
            //  thongbao += "!";
            //  Console.WriteLine(thongbao); 
            
            // string thongbao;
            // thongbao = "\\Hoc\t ve\t chuoi ki tu\n \"String\"";
            // // Để chèn kí tự dấu nháy kép: \"
            // // Để chèn dấu chéo ngược: \\
            // // Để chèn dấu tab: \t
            // // Để chèn ký tự xuống dòng: \n
            // // Để trở về đầu dòng: \r
            // Console.WriteLine(thongbao);


            //có dầu @ có thể xuống dòng, muốn chèn dấu nháy kép: "" tương đương 1 dấu "
            // string thongbao;
            // thongbao = @"Xin chao       ""2021"" \
            
            // Hoc lap trinh C#
            // ";

            // Console.WriteLine(thongbao);

            // CHÈN GIÁ TRỊ, BIỂU THỨC GIÁ TRỊ VÀO CHUỖI STRING
            // string thongbao;
            // int year = 2020;
            // thongbao = 
            // $"Xin chao {year, -10}, nam sau la nam {year + 1}"; 
            // // {year, 10} 10 là chèn chỗ trống 10 kí tự trước biểu thức (căn lề phải)
            // // căn lề trái thêm dấu trừ vào chỗ kí tự VD: {year. -10}
            // Console.WriteLine(thongbao);

            // VD
            // string thongbao;
            // string name = "Khuong";
            // int year = 2005;
            // string gioitinh = "nam";
            // thongbao = 
            // $@"
            // Ho ten: {name, 10}
            // Nam sinh: {year, 10}
            // Gioi tinh: {gioitinh, 10}
            // ";

            // Console.WriteLine(thongbao);

            // string thongbao = "Khuong Nguyen, xin chao cac ban!";
            // int dodai = thongbao.Length; // Đếm bao nhiêu ký tự
            //Để đọc một ký tự nào đó trong chuỗi ta sử dụng ngoặc vuông
            // char kytu = thongbao[4];


            // Console.WriteLine(thongbao);
            // Console.WriteLine(dodai);
            // Console.WriteLine(kytu);

            // for (int i = 0; i < dodai; i++)
            // {
            //     char kytu = thongbao[i];
            //     Console.WriteLine($"Chi so {i} la ky tu: {kytu, 3}");
            // }


            // Duyệt qua từng ký tự 
            // foreach (var kytu in thongbao)
            // {
            //     Console.WriteLine(kytu);
            // }

            // Nội dung người dùng nhập vào ta có thể bỏ bằng cách sau
            // string thongbao = "         Khuong Nguyen, xin chao cac ban!        ";
            // thongbao = thongbao.Trim();// xóa khoảng trống

            //Muốn cắt đi cụ thể những ký nào ở đầu và ở cuối thì ta sẽ điền ký tự đó vào (đc kí hiệu bằng dấu '')
            //Muốn loại bỏ những ký tự đặc biết ở đầu hoặc ở cuối thôi ta dùng TrimStart or TrimEnd 
            //Để chuyển toàn bộ chuỗi thành chữ in thường hoặc thành chữ in hoa: 
            // In hoa: ToUpper()
            // In thường: ToLower()
            // string thongbao = "Khuong Nguyen, xin chao cac ban!        ";
            // thongbao = thongbao.Trim();
            // Console.WriteLine(thongbao.ToLower());

            // TÌM KIẾM VÀ THAY THẾ MỘT CHUỖI CON Ở TRONG CHUỖI
            string thongbao = "Khuong Nguyen, xin chao cac ban!        ";
            thongbao = thongbao.Replace("xin chao", "chao mung");
            Console.WriteLine(thongbao.ToLower());

        }
    }
}



