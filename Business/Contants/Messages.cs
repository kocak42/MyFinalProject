using Core.Entities.Concrate;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Contants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "ürüm ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed="Ürürnler listelendi";
        public static string ProductCountOfCategoryError = "bir kategeoride en falza 10 ürün ekliyebilirsiniz";
        public static string ProductNamaElreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limitin aşıldığı için yeni kategori eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıc başarıyla kayıdedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı şifre";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string AccessTokenCreated = "Token oluşturuldu";

        public static string UserAlreadyExists = "Kullanıcı mevcut";
    }

}
