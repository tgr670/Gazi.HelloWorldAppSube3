namespace Gazi.HelloWorldAppSube3
{
    internal class Program
    {
        //static int oyuncusayi = 500;
        static void Main(string[] args)
        {

            //int sayi = 100;//Değer Tipi
            //string isim = "Tuğrul";//Referans Tipleri
            //byte number = 150;
            //byte a = 30;
            //double d = 40;

            //int sayi = 10;
            //Console.WriteLine(sayi);
            //sayi = 20;
            //Console.WriteLine(sayi);
            //sayi = 30;
            //Console.WriteLine(sayi);
            //sayi = 40;
            //Console.WriteLine(sayi);

            //byte yas;
            //Console.WriteLine(yas);  Bu şekilde çalışmaz
            //değişken ismi _ harici bi şeyle başlayamaz sayı simge vs
            // değişken isminde boşluk yerine _ kullanılır

            //var sayi = 3.24f;

            //string isim = "Ahmet", soyad = "mehmet";
            //Console.WriteLine("Merhaba " + isim + " " + soyad);
            //Console.WriteLine("Merhaba {0} {1}", isim, soyad);
            //Console.WriteLine($"Merhaba {isim} {soyad}");


            //string isim = "Tuğrul", soyad = "Durudoğan";
            //Console.WriteLine("Merhaba " + isim + " " + soyad);
            //Console.WriteLine("Merhaba {0} {1}", isim, soyad);
            //Console.WriteLine($"Merhaba {isim} {soyad}");

            //Console.WriteLine("İsminizi giriniz:");
            //string isim = Console.ReadLine();

            //Console.WriteLine("Soyadınızı giriniz");
            //string soyad = Console.ReadLine();

            //Console.WriteLine("Yaşınızı Giriniz");
            ////byte yas = Convert.ToByte(Console.ReadLine());
            //byte yas= byte.Parse(Console.ReadLine());
            ////Cw Tab yapınca direkt console writeline açar
           

            //Console.WriteLine($"Hoşgeldin {isim} {soyad} {yas}");


            //Console.WriteLine("Hangi İlde yaşıyosunuz");
            //string şehir= Console.ReadLine();

            //Tür dönüşümleri (Type Casting)
            //C# proglamalama dili, tip güvenliği (type safetey) sağlayan bir dildir.örn byte bir veriye string bir değer atnamaz.
            //Ancak atadığımız değeri istediğimiz veri tipine dönüştütürerek atama gerçekleştirebiliriz.

            //byte sayi = 10;
            //int number = sayi; //Implicit Type Casting. İnt bytedan daha büyük olduğu için onun değerlerini alabilir.dönüşebilir.


            //checked
            //{
            //int sayi = 257;
            //*byte number = (byte)sayi;//Explicit Type Casting.Kendimiz yaptığımız yorumladığmız Casting.
            //Console.WriteLine(number); //Ctrl K S ile bunu kolayca yapabiliriz.Blokları sarabiliriz.
            //}
            //Risk: Eğer atanmak istenen değer , atanacak veri tipinden büyükse veri kaybı olur.Bunun önüne geçmek için
            //Checked blokları kullanılır. Bu blok risk durumunda hata vererek atama yapılmasını önler.

            //string sayi = "25";
            ////byte number = Convert.ToByte(sayi);
            //int number = int.Parse(sayi);//Elimizde string varsa parse metodu Conver.ToByte metodundan daha hızlı çalışır.
            //Console.WriteLine(number);


            Console.ReadKey();
        }
    }
}
//NameSpace:İçinde classları bulunduran blok yapılarıdır.
//{ }: Blok(Scope) Yapılar
//Class: İçinde metodları bulunduran yapılardır.
//Metod: İş yapan kod bloklarıdır.
//Main Metodu: Console uygulamalarının giriş noktasıdır.
//IntelliSense:Kod yazım yardımcısı penceresi.
//IntelliCode: Yapay zeka destekli kod yazım yardımcısı.
//Syntax: Kod yazılım kurallarına denir.
//Ctrl B derleme kısayolu .
//Ctrl K D Blokları düzeltir.
//Ctrl S kaydetme
//Ctrl K C yorum satırına getirme
//Ctrl K U Eski haline getirme yorum satırını.
//Solution: İçinde projeleri tutan yapılardır.
//Derleme(Compile): C#->Derleme->MS-IL(exe)->RunTime(Derleme)->Makina Dili(0-1)
//MS-IL: Microsoft Intermedite Language

//.NET: Microsoft tarafından geliştirilmiş bir yazılım geliştirme ortamıdır.(FrameWork de denir)
//Programlama dilleri: C#-VB-F#
//Editörler: Visual Studio-Visual Studio Code
//Derleyiciler(Compiler) - Runtime
//Kütüphaneler (Namespace)

//Desktop Applications : Masaüstü Uyuglamarı. Console,Windows Forms App
//Web Based Apllications: Web Tabanlı uygulamalar
//Mobile Apps: Xamarin->Android ve İOS
//İOT: Internet Of things (Akıllı Cihazlar)
//AI Yapay Zeka
//Game Development : Unity
//How Computer Works İzle

//Stack Bölgesi: Değer Tipleri(Valut types) Burda saklanır
//Heap bölgesi : Referenas Tipleri burda saklanır
//Aynı türden değişkenler tek satırda tanımlanıp değer atabilir. byte a =30, b; b=40 . Byte a, b; b=; a=30;
//Static değişkenler,program çalıştığı sürece hafızada kalırlar 
//Tanımlamanın başına static sözcüğü getirilir.
//const : sonradan değeri değiştirelemeyen değişkenler (sabit değişken)

//bit: 0-1 
//8bit = 1 byte
//1024byte= 1 Kilobyte(KB)
//1024kb= 1 Megabyte(mb)
//1024mb= 1 Gigabyte(gb)
//1024gb=1 Terabyte(tb)


