using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string AuthorizationDenied="Giris redd edildi";
        public static string AccessTokenCreated="Token yaradildi";
        public static string SuccessfulLogin="Ugurlu giris";
        public static string PasswordError="Parol sehvdir";
        public static string UserRegistered="User register oldu";
        public static string UserAlreadyExists="Bele bir user var";
        public static string UserNotFound="Bele bir user yoxdur";
        public static string ProductUpdated="Product Update olundu";
        internal static string CustomerAdded;
        internal static string CustomersListed;
        internal static string OverImage;
        internal static string ThrowErrorMessage;
        internal static string Deleted;
        internal static string Updated;
        internal static string CarDeleted;
    }
}
/*[HttpGet("getdetails")]
        public IActionResult GetDetails()
        {
            var result = _carImageService.GetDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }*/