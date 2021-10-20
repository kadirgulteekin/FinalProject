using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static yapma sebebim sürekli new'lememek için.
    public static class Messages
    {
        public static string ProductAdded = "Ürün kklendi!";
        public static string ProductNameInValid = "Ürün ismi geçersiz!";
        public static string MaintananceTime = "Sitem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError="Ürün kategori üst sınır aşımı";
        public static string ProductNameAlreadyExist = "Aynı isimli iki ürün eklenemez.";
        public static string CategoryCountExceded="Category limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
