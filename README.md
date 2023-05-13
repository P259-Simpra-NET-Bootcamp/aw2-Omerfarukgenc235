Bu proje Patika.Dev'in düzenlemiş olduğu Simpra .Net Bootcamp'inin 2.ödevi kapsamında geliştirilmiştir.

Proje 4 katmandan oluşmaktadır.

EntityLayer: Bu katmanda veri tabanı tablolarının sınıfları tutulmaktadır.
--> Models: Veri tabanı tablosunun sınıfı burada bulunmaktadır.
DataAccessLayer: Bu katmanda GenericRepository, Context, Mapper, Migration gibi bölümler bulunmaktadır.
-->Abstract: Burada GenericRepository ve Staff'in interfaceleri bulunmaktadır.
-->Context: Burada Context sınıfı ve  tutulmaktadır. 
BusinessLayer: Bu katmanda projedeki tabloların CRUD işlemleri ve FluentValidation işlemleri gerçekleştirilmektedir.
