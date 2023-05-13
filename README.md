Bu proje Patika.Dev'in düzenlemiş olduğu Simpra .Net Bootcamp'inin 2.ödevi kapsamında geliştirilmiştir.

Proje 4 katmandan oluşmaktadır.

EntityLayer: Bu katmanda veri tabanı tablolarının sınıfları tutulmaktadır.
--> Models: Veri tabanı tablosunun sınıfı burada bulunmaktadır.
DataAccessLayer: Bu katmanda GenericRepository, Context, Mapper, Migration gibi bölümler bulunmaktadır.
-->Abstract: Burada GenericRepository ve Staff'in interfaceleri bulunmaktadır.
-->Context: Burada Context sınıfı ve Repository sınıfı tutulmaktadır. 
-->EntityFramework: Burada Staff sınıfının GenericRepository ile bağlantısı kurulmaktadır.
-->Mapper: Burada veri tabanındaki tablonun genel özellikleri tanımlanmıştır.
BusinessLayer: Bu katmanda projedeki tabloların CRUD işlemleri ve FluentValidation işlemleri gerçekleştirilmektedir.
-->Abstract: Burada Staff'in CRUD işlemleri için interface'i oluşturulmuştur.
-->Concrete: Burada Staff'in FluentValidation kontrollleri ve CRUD işlemleri gerçekleştirilmiştir.
-->FluentValidations: Burada Staff sınıfının attribute'larının gerekli kontrolleri ve hata mesajları ayarlanmıştır.
SimraOdev2: Bu katmanda projenin genel istekleri karşılanmaktadır.
-->appsettings.json: Burada veri tabanı bağlantı yolu belirtilmiştir.
-->ServiceExtension: Burada Program.cs sınıfının uzun olmaması için extension kullanılmıştır.
