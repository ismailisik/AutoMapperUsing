using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperWork.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        //Not: Eğer biz bir methodun döndüğü değeri dto muza mapping yapmak ister isek yada datamızı bir method sayesinde bir şekle sokup o şekilde istemciye sunmak istiyorsak method mepleme yapmamız gerekmektedir.
        //Not: Methodun başına Get ekler isek Dto'muzda direk  ProductWithPrice adında bir prop mapleme için yeterli olcaktır.Aksi takdirde Mapping classımız üzerinden mapplememiz gerekmektedir...
        public string GetProductWithPrice()
        {
            return $"Ürün Adı: {ProductName} Fiyatı: {UnitPrice}";
        }

        //Not: Compex type verimizi  nasıl dto ya mapleyeceğiz. Aşağıdaki örneğe bak..Buna AutoMapper da flatening deniyor.
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }

    }
}
