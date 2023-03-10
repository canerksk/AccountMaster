# AccountMaster

AccountMaster uygulaması SphereServer accounts klasörü içindeki sphereaccu.scp dosyasını okuyan C# programlama dili, Visual Studio 2022 IDEsi ve .NET Framework 4.5 çerçevesi kullanılarak yapılmış bir uygulamadır.

Uygulama içerisinden SphereServerda kayıtlı hesapların yönetimini yapabilirsiniz.

![Adsız](https://user-images.githubusercontent.com/10347131/223496207-14d395af-5f12-4ee7-a2ed-7a580062e784.png)

Uygulama SphereServer.exe (Farklı sürümlerin farklı isimleri olabilir) aynı dizinde çalışmalıdır. "accounts" klasörü veya başka bir dizinde çalışmamalıdır.

Ayrıca Sphere.ini içindeki sunucu adını okuyarak program başlığında görüntülemektedir. 

Program içerisinde bazı sunuculara özgü account anahtarları vardır. Bu anahtarlar bazı SphereServer emülatörlerine göre değişiklik gösterebilir.


Örneğin MAIL veya EMAIL account anahtarı 56b sürümlerinde olmadığı için EMAIL alanı boş görünecektir. Kaynak kodlardan kendi kullandığınız emülatöre göre ufak düzenlemeler yaptıktan sonra derleme alarak kullanabilirsiniz.

Program zaman içerisinde güncel tutulacaktır. Toplu hesap silme işlemi. Detaylı hesap filtreleme, içe aktarma, dışa aktarma gibi özellikler eklenecektir.

Program Account Master (Ultima Develoers [Uo.anet.net.tr]) v1.0.1 programından esinlenerek yapılmıştır. Bu program hem açık kaynak olmaması hem de artık güncelliğini yitirmesiyle bu projenin yapılma ihtiyacı duyulmuştur.
