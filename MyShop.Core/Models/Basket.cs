using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Basket : BaseEntity
    {
        //Virtual ICollection, Entity Framework için önemli bir konu.
        //Virtual ICollection sayesinde, DB'den Basket verileri load oldugunda EF bunu anlayarak aynı zamanda BasketItem degerlerinin de otomatik olarak load olmasını saglayacak. (Mesela Bir ürünün fiyatı değiştiginde, otomatik olarak sepete de (Eger bu ürün sepete eklenmişse) bu fiyat değişimi yansıyacak.[Bu kısım benim anladıgım şekli])
        //Buna Lazy Loading deniyor.

        //ICollection sayesinde EF BasketItem ve Basket classları arasında ilişkiyi oluşturuyor. Migration class'ında (201812280754115_AddBasket.cs) bu iki class arasında ForeingKey ilişkisini oluşturuyor.
        public virtual ICollection<BasketItem> BasketItems { get; set; }

        public Basket()
        {
            this.BasketItems = new List<BasketItem>();
        }
    }
}
