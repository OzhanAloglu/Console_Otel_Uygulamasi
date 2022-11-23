using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Otel_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Otelimize hoşgeldiniz.");

            Console.Write("Hangi ay kalacaksınız seçim yapınız." + "\n" + "1.Haziran" + "\n" + "2.Temmuz" + "\n" + "3.Ağustos");
            int kalacakAy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kişi sayısı giriniz.");
            int kisiSayisi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gün sayısını girin.");
            int günSayisi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen yapmak istediğiniz seçimin numarasını giriniz.");
            Console.Write("1.kingRoom." + "\n" + "2.standartRoom." + "\n" + "3.vipRoom.");
            double oda = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("1.Açık büfe kahvaltı." + "2.Öğle Yemeği" + "3.Akşam yemeği");
            //string yemek = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("Ödemeyi nasıl yapacaksınız." +"\n"+ "1.seçim=6 Ay" + "\n" + "2.Seçim=8 Ay" + "\n" + "3.Seçim=Peşin");
            //string ödeme = Convert.ToString(Console.ReadLine());



            //seçim = 1;
            //seçim = 2;
            //seçim = 3;


            double fiyat = 0;
            



            switch (oda)
            {
                case 1:
                    Console.WriteLine("Sauna ister misiniz?");
                    Console.WriteLine("1-True" + "\n" + "2-No");
                    double seçim1 = Convert.ToDouble(Console.ReadLine());
                    if (seçim1 == 1)
                    {

                        if (kisiSayisi > 2 && kisiSayisi < 8)
                        {
                            fiyat = ((günSayisi * kisiSayisi) * 2000) + (kisiSayisi * günSayisi * 250);
                            Console.WriteLine("Oda fiyatı=" + fiyat);
                            Console.WriteLine("Odanın indirimli fiyatı");
                            fiyat = fiyat - (fiyat * 7.5 / 100) + (fiyat * 2 / 100);
                            Console.WriteLine("Fiyat=" + fiyat);


                        }

                    }
                    if (seçim1 == 2)
                    {
                        fiyat = (günSayisi * kisiSayisi) * 2000;
                        Console.WriteLine("Fiyatınız=" + fiyat);


                    }

                    Console.WriteLine("Özel havuz ister misiniz?");
                    Console.WriteLine("1-True" + "\n" + "2-No");
                    double seçim2 = Convert.ToDouble(Console.ReadLine());

                    if (seçim2 == 1)
                    {

                        Console.WriteLine("Termal kaynaklardan yararlanmak ister misiniz");
                        Console.WriteLine("1-True" + "\n" + "2-No");
                        double seçim3 = Convert.ToDouble(Console.ReadLine());

                        if (seçim3 == 1)
                        {
                            fiyat = (günSayisi * kisiSayisi * 2000);
                            fiyat = (fiyat + (fiyat * 2.5 / 100 + fiyat * 8.5 / 100));
                            Console.WriteLine("Fiyatınız=" + fiyat);
                        }
                        else if (seçim3 == 2)
                        {
                            fiyat = (günSayisi * kisiSayisi * 2000);
                            fiyat = fiyat + (fiyat * 7.5 / 100);
                            Console.WriteLine("Fiyatınız" + fiyat);

                        }


                    }
                    if (seçim2==2)
                    {
                        fiyat = (günSayisi * kisiSayisi) * 2000;
                        Console.WriteLine("Fiyatınız=" + fiyat);
                    }
                    Console.ReadLine();
                    break;

                case 2:

                    Console.WriteLine("Rezervasyon yapmak ister misiniz");
                    Console.WriteLine("1.Evet" + "\n" + "2.Hayır");
                    double cevap = Convert.ToDouble(Console.ReadLine());


                    if (cevap == 1)
                    {
                        Console.Write("Hangi ay kalacaksınız seçim yapınız." + "\n" + "1.Haziran" + "\n" + "2.Temmuz" + "\n" + "3.Ağustos");
                        int kalacakAy1 = Convert.ToInt32(Console.ReadLine());

                        if (kalacakAy1 == 1)
                        {
                            fiyat = (günSayisi * kisiSayisi) * 500;
                            fiyat = fiyat - (fiyat * 4 / 100) + (fiyat * 8 / 100);
                            Console.WriteLine("Fiyat=" + fiyat);

                        }

                        else if (kalacakAy1 == 2)
                        {
                            fiyat = (günSayisi * kisiSayisi) * 750;
                            fiyat = fiyat + (fiyat * 18 / 100 + fiyat * 2.5 / 100);
                            Console.WriteLine("Fiyatınız=" + fiyat);
                        }

                        else if (kalacakAy1 == 3)
                        {
                            fiyat = (günSayisi * kisiSayisi) * 1000;
                            fiyat = fiyat + (fiyat * 8 / 100 + fiyat * 2.5 / 100 + fiyat * 10 / 100);
                            Console.WriteLine("Fiyatınız=" + fiyat);
                        }

                       
                    }
                    if (cevap == 2)
                    {
                        Console.WriteLine("Rezervasyonsuz işlem yapamıyoruz teşekkürler iyi günler.");
                    }

                    Console.ReadLine();


                    break;

                case 3:

                    if (oda == 3)
                    {

                        Console.Write("Hangi ay kalacaksınız seçim yapınız." + "\n" + "1.Haziran" + "\n" + "2.Temmuz" + "\n" + "3.Ağustos");
                        int kalacakAy2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1.Açık büfe kahvaltı." + "2.Öğle Yemeği" + "3.Akşam yemeği");
                        int yemek = Convert.ToInt32(Console.ReadLine());

                        if (yemek == 1 && kalacakAy2 == 1)
                        {
                            fiyat = (kisiSayisi * günSayisi) * 500;
                            fiyat = fiyat + 1000;
                            Console.WriteLine("Fiyatınız=" + fiyat);
                        }
                        else if (yemek == 1 && kalacakAy2 == 2)
                        {
                            fiyat = (kisiSayisi * günSayisi) * 750;
                            fiyat = fiyat + 1000;
                            Console.WriteLine("Fiyatınız=" + fiyat);
                        }
                        else if (yemek == 1 && kalacakAy2 == 3)
                        {
                            fiyat = (kisiSayisi * günSayisi) * 1000;
                            fiyat = fiyat + 1000;
                            Console.WriteLine("Fiyatınız=" + fiyat);
                        }
                        else if (yemek == 2 && kalacakAy2 == 1)
                        {
                            fiyat = (kisiSayisi * günSayisi) * 500;
                            fiyat = fiyat + 500;
                            Console.WriteLine("Fiyatınız=" + fiyat);
                        }
                        else if (yemek == 2 && kalacakAy2 == 2)
                        {
                            fiyat = (kisiSayisi * günSayisi) * 750;
                            fiyat = fiyat + 500;
                            Console.WriteLine("Fiyatınız=" + fiyat);
                        }
                        else if (yemek == 2 && kalacakAy2 == 3)
                        {
                            fiyat = (kisiSayisi * günSayisi) * 1000;
                            fiyat = fiyat + 500;
                            Console.WriteLine("Fiyatınız=" + fiyat);
                        }
                        else if (yemek == 3 && kalacakAy2 == 1)
                        {
                            fiyat = (kisiSayisi * günSayisi) * 500;
                            fiyat = fiyat + 1500;
                            Console.WriteLine("Fiyatınız=" + fiyat);
                        }
                        else if (yemek == 3 && kalacakAy2 == 2)
                        {
                            fiyat = (kisiSayisi * günSayisi) * 750;
                            fiyat = fiyat + 1500;
                            Console.WriteLine("Fiyatınız=" + fiyat);
                        }
                        else if (yemek == 3 && kalacakAy2 == 3)
                        {
                            fiyat = (kisiSayisi * günSayisi) * 1000;
                            fiyat = fiyat + 1500;
                            Console.WriteLine("Fiyatınız=" + fiyat);
                        }


                    }


                    Console.ReadLine();


                    break;


            }









        }
    }
}
