using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string[] ValidImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO" };

        public static string BrandAdded = "Brend elave edildi";
        public static string BrandDeleted = "Brend silindi";
        public static string BrandUpdated = "Brend guncellendi";

        public static string RentalAdded = "Rental elave edildi";
        public static string RentalDeleted = "Rental silindi";
        public static string RentalUpdated = "Rental guncellendi";

        public static string CarAdded = "Car elave edildi";
        public static string CarNameInvalid = "Car adi gecersizdir";
        public static string MaintenanceTime = "Sistem proflaktik baxisda";
        public static string CarsListed = "car listelendi";
        public static string UnitPriceInvalid = "Car Pricei kecerli deyil";
        public static string CarCheckImageLimited="Sekil secme limiti doldu";
        public static string CarImagesListed="Sekiller listelendi";
        public static string CarImageDeleted="Sekil silindi";
        public static string CarImageAdded="Sekiller elave edildi";
        public static string ColorAdded="Reng elave edildi";
        public static string ColorDeleted="Reng silindi";
        public static string ColorListed="Reng listelendi";
        public static string ColorListedById="Renge gore listelendi";
        
        public static string ImageLimitExpiredForCar = "Bir arabaya maximum 5 fotoğraf eklenebilir";
        public static string InvalidImageExtension = "Geçersiz dosya uzantısı, fotoğraf için kabul edilen uzantılar" + string.Join(",", ValidImageFileTypes);
        public static string CarImageMustBeExists = "Böyle bi resim bulunamadı";
        public static string CarHaveNoImage = "Arabaya ait bi resim yok";
    }
}
