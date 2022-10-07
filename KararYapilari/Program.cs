namespace KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Karar Yapıları
            //1) if-else
            //2) switch-case
            //3) ternary if

            //Karsilastirma ops
            //1) == (Karsilikli iki değişkenin eşit olmas durumu 
            //2) != Karsilikli iki değişenin birbiriyle eşit olmaması durumu
            //3 a<b soldaki değerin sağdakinden küçük olma durumu (kucuktur)
            //4 a>b  "          "       "           büyük   "" " (buyuktur)
            //5 <= ve >=    kucuk esit buyuk esit olma durumu.


            #region if-else

            //iki durum için
            //Console.WriteLine("Kullanici kodu giriniz:");
            //string usernam = Console.ReadLine();

            //if (usernam == "admin")
            //{
            //    Console.WriteLine("Hosgeldiniz sayin admin");

            //}
            //else
            //{
            //    Console.WriteLine("Taniyamadik sizi");
            //}

            //Birden fazla durum
            //Console.WriteLine("Haftanin kacinci gunu oldugunuz yaziniz:");
            //string haftagunu = Console.ReadLine();
            //if(haftagunu == "1")
            //{
            //    Console.WriteLine("pazartesi");
            //}
            //else if (haftagunu == "2") { Console.WriteLine("sali"); }
            //else if (haftagunu == "3") { Console.WriteLine("carsamba"); }
            //else if (haftagunu == "4") { Console.WriteLine("persembe"); }
            //else if (haftagunu == "5") { Console.WriteLine("cuma"); }
            //else if (haftagunu == "6") { Console.WriteLine("cumartesi"); }
            //else if (haftagunu == "7") { Console.WriteLine("pazar"); }
            //else Console.WriteLine("1-7 arasinda bir deger giriniz");

            #endregion


            #region Soru1-Kullanicidan alınan sayi tek mi çift mi
            //int sayi; string? giris;
            //Console.WriteLine("Bir sayi giriniz:");
            //giris = Console.ReadLine();
            //sayi= Convert.ToInt32(giris);

            //if (sayi %2 == 0)
            //{
            //    Console.WriteLine("sayi çifttir");
            //}
            //else
            //    Console.WriteLine("sayi tektir");
            #endregion
            #region Sorular 
            //ekrandan alinan suyun sikcaligi ile durmunu
            //string? giris; int su;
            //Console.WriteLine("Suyun sıcaklığını giriniz");
            //giris = Console.ReadLine();
            //su = Convert.ToInt32(giris);
            //if (su >= 100 )
            //{
            //    Console.WriteLine("Suyun sicakligi: " + su + " derece ve Gaz durumundadir.");
            //}

            //else if (su <= 0)
            //{
            //    Console.WriteLine("Suyun sicakligi: " + su +" derece ve Kati durumdadir");

            //}
            //else // (su >0 && su<100) //aynı mantık*
            //    Console.WriteLine("Suyun sicakligi: " + su +"derece ve Sivi durumdadir");




            #endregion

            #region Soru2
            //Kullanici adi ve sifre istenecek.(admin-123)
            //ikisi birden dogru girildiyse hosgeldiniz.
            //diger durumda hatalari ekrana bastir.

            //Console.WriteLine("Kullanici adinizi giriniz:");
            //string? giris = Console.ReadLine();
            //Console.WriteLine("sifrenizi giriniz:");
            //int sifre = Convert.ToInt32(Console.ReadLine());
            //if (giris == "admin" && sifre == 123)
            //{
            //    Console.WriteLine("Hosgeldiniz Admin");
            //}
            //else if (giris != "admin")
            //{
            //    Console.WriteLine("Hatali kullanici adi");
            //}
            //else if (sifre != 123)
            //{
            //    Console.WriteLine("Hatali sifre");
            //}




            #endregion


            #region Soru3
            // Girilen not 0-30 FF
            //30-50 dd
            //    50-70 BB
            //    70-100 AA
            //Console.WriteLine("Notunuz Giriniz.");
            //int not = Convert.ToInt32(Console.ReadLine());
            //if(not <=30)
            //{
            //    Console.WriteLine("Notunuz:"+not+"Harf notu:FF");
            //}
            //else if(not <=31 && not<=50)
            //{
            //    Console.WriteLine("Notunuz:" + not + "Harf notu:DD");
            //}
            //else if(not <=51 && not <= 70)
            //{
            //    Console.WriteLine("Notunuz:" + not + "Harf notu:BB");
            //}
            //else if(not<=100 && not>=71)
            //{
            //    Console.WriteLine("Notunuz:" + not + "Harf notu:aa");
            //}
            #endregion

            #region Soru4
            // disaridan urun adi girilecek ve
            // program urunun hangi reyonda old soyleyecek
            //Domates biber patlican icin sebze
            // Dis macunuiparfum, krem i,cin kozmetik
            //Telefon pc ses sistemi teknoloji
            //FArklı bir üründe bu urunden bizde yok.
            //string? giris;
            //Console.WriteLine("Ürünü giriniz");
            //giris = Console.ReadLine();
            //giris = Convert.ToString(giris);
            //if (giris == "domates" || giris == "biber" || giris == "patlican")
            //{
            //    Console.WriteLine("Bu urun sebze reyonumuzdadir.");
            //}
            //else if (giris == "dis macunu" || giris == "parfum" || giris == "krem")
            //{
            //    Console.WriteLine("Bu urun kozmetik reyonumuzdadir.");
            //}
            //else if (giris == "telefon" || giris == "bilgisayar" || giris == "ses sistemi")
            //{
            //    Console.WriteLine("Bu urun teknoloji reyonumuzdadir.");
            //}
            //else
            //    Console.WriteLine("Bu urun elimizde yok");



            #endregion

            #region Soru 5
            ////urun 5 tl
            ////girilen sip sayisi 20den azsa %5 ind
            ////20-50 arasi %10
            ////50-100 arasi %15
            ////100 den fazla ise %20
            ////Toplam tutar ind miktari ve Odenecek tutar bilgisi
            //int urun = 5; string? giris;
            //float indtop; float toplam;
            //float indirim;
            //Console.WriteLine("Sipariş adetini giriniz:");
            //giris = Console.ReadLine();
            //int adet = Convert.ToInt32(giris);
            //if (adet < 20)
            //{
            //    toplam = adet * urun;
            //    indirim = toplam * 0.05f;
            //    indtop = toplam - (toplam*0.05f);
            //    Console.WriteLine("Toplam tutar= " + (toplam) + " indirim:%5" + " indirim tutarı:" + indirim + " Odenecek tutar:" + indtop); 
            //}
            //else if (adet >=21 && adet<50)
            //{
            //    toplam = adet * urun;
            //    indirim = toplam * 0.1f;
            //    indtop = toplam - (toplam* 0.1f);
            //    Console.WriteLine("Toplam tutar= " + (toplam) + " indirim:%10" + " indirim tutarı:" + indirim + " Odenecek tutar:" + indtop);
            //}
            //else if (adet >= 50 && adet <= 100)
            //{
            //    toplam = adet * urun;
            //    indirim = toplam * 0.15f;
            //    indtop = toplam - (toplam * 0.15f);
            //    Console.WriteLine("Toplam tutar= " + (toplam) + " indirim:%15" +" indirim tutarı:"+ indirim + " Odenecek tutar:" + indtop);
            //}
            //else if (adet >100)
            //{
            //    toplam = adet * urun;
            //    indirim = toplam * 0.20f;
            //    indtop = toplam - (toplam * 0.20f);
            //    Console.WriteLine("Toplam tutar= " + (toplam) + " indirim:%20 " + " indirim tutarı:" + indirim + " Odenecek tutar:" + indtop);
            //}

            #endregion

            #region Ternary If
            // eger tek satirda ufak bir karar mekanizması ile yolumuza
            // devam etmek istersek; 
            // soru isareti operatoru size bu konuda yardımcı olacaktır.
            //Yazim formatı;
            // sonuc = 10 ? "true oldugunda calisacak kod" : "False oldugunda calisacak kod"
            //-----------
            //int x=10, y=100;

            //var result = x > y ? "x>y" : "x<y";
            //Console.WriteLine(result);



            #endregion

            #region Switch Case
            //if else mantıgı ile çalışır
            //if else buyuk küçük gibi durumları kontrol ederken
            //switch case yalnızca esitlik durumlarını kontrol eder
            //kendisine ait bir indexleme mekanizması vardır
            //Sıraya koyar otomatik olarak yuzlerce kosulumuz olsa bile herbirine bakmadan
            //hangisi esit ise oraya konumlanir
            //switch icerisindeki veri tipiniz ne ise case de de aynı veritipi olmalidir.
            //

            //string mesaj = "";
            //Console.WriteLine("Mevsim giriniz:");
            //string? mevsim = Console.ReadLine();

            //switch (mevsim)
            //{
            //    case "Kış":
            //        mesaj = "aralik,ocak,subat";
            //        break;
            //    case "Bahar":
            //        mesaj = "mart,nisan,mayis";
            //        break;
            //    case "Sonbahar":
            //        mesaj = "eylul,ekim,kasim";
            //        break;
            //    case "Yaz":
            //        mesaj = "haziran,temmuz,agustos";
            //        break;
            //    default: //ongorulen bir durum harici deger ile karsilasirsak varsayilan olarak buraya girer.
            //        break;
            //}
            //        Console.WriteLine(mesaj);




            #endregion


            #region Switch-Case Soru1
            ////Ekrandan rol okutalim
            ////Eger admin girilirse ekrana "admin syf yonlendiriliyosunuz" msj versin
            ////Eger satis "satis syf"
            ////eger uye "uye syf
            //string mesaj = "";
            //Console.WriteLine("Rol giriniz");
            //string? rol = Console.ReadLine();
            //switch (rol)
            //{
            //    case "Admin":
            //        mesaj = "Admin syf yonlendir"; // same : cw("admin syf");
            //        break;
            //    case "Uye":
            //        mesaj = "Uye syf yonlendir";
            //            break;
            //    case "Satis":
            //        mesaj = "satis syf yonlendir";
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine(mesaj);
            #endregion

            #region S-C Soru2
            //ekrandan ay okut. 1 girerse ocak 2girerse Subat..
            // string mesaj = "";

            // Console.WriteLine("Ay icin sayi gir");
            //int ay =Convert.ToInt32(Console.ReadLine());
            // switch (ay)
            //     {
            //     case 1:
            //         mesaj = "ocak";
            //         break;
            //         case 2:
            //         mesaj = " subat";
            //         break ;
            //         default:
            //         break;
            //  }
            // Console.WriteLine(mesaj);



            #endregion

            #region S-C Soru 3 ice ice switch.
            //Kullanici adi ve sifre al
            //kullanici ad ve sifre dogru ise "tebrikler.
            //kullanici adi dogru sifre yanlissa "ka dogru pw yanlis
            //ka yanlıs pw dogru ise "ka yanlis pw dogru yaz
            //
            
            Console.WriteLine("Kullanici adinizi girin");
            string? id = Console.ReadLine();

            Console.WriteLine("Sifrenizi girin");
            string? pw = Console.ReadLine();

            switch (id)
            {
                case "admin":
                    switch (pw)
                    {
                        case "123":
                            Console.WriteLine("Tbr ikiside dogru");
                            break;
                        default:
Console.WriteLine("Kullanıcı adı dogru sifre yanlis");
                            break;                            
                    }
                    break;
                default:
                    Console.WriteLine("Kullanici adiniz yanlış");
                    break;
            }


            #endregion
        }
    }
}
