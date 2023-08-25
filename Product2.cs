// namespace Sanpham {
//     /* từ khóa "partial" ta dùng khi định nghĩa lớp thì nó giúp chúng ta chia nhỏ đĩnh nghĩa lớp ra nằm trên 
//     nhiều file mã nguồn */ 
//     public partial class Product {
//         public string description {set; get;}

//         /* VD ta định nghĩa ra một phương thức bất kì nào đó thì nó có thể truy cập 
//         đến tất cả thuộc tính, những phương thức được định nghĩa trong file mã nguồn product1 */
//         public void Abc()
//         {

//         }
//     }
// }

//-------------LỚP LỒNG NHAU NESTED CLASS-----------------
/*Để khai báo một lớp lồng trong một lớp khác hay làm lớp con của lớp khác thì ta khai báo ở trong phần
định nghĩa lớp định nghĩa lớp của lớp đó */
/* Khi khai báo một lớp nằm trong một lớp khác ngoài những từ khóa là "public"; "internal" chỉ ra phạm vi truy cập
ta đã biết, khi nó nằm trong lớp có thể sử dụng thêm "private"; "protect';... giống như là thành viên của lớp */ 


namespace Sanpham {
    /* từ khóa "partial" ta dùng khi định nghĩa lớp thì nó giúp chúng ta chia nhỏ đĩnh nghĩa lớp ra nằm trên 
    nhiều file mã nguồn */ 
    public partial class Product {
        // Thuộc tính
        public Manufactory manufactory {set; get;}
        public class Manufactory {
            //Thuộc tính
            public string name {set; get;}
            public string addr {set; get;}
            public string description2 {set; get;}
            public string GetInfo2() {
            return $"{name} / {addr} : {description2}";
        }
        }
        
    }
}