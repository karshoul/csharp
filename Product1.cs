namespace Sanpham {
    public partial class Product {
        public string name {set; get;}
        public decimal price {set; get;}
        public string description1 {set; get;}
        public string GetInfo1() {
            return $"{name} / {price} : {description1}";
        }
        
    }
}