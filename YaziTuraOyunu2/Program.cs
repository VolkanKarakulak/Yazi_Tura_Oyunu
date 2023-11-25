namespace YaziTuraOyunu2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firlatilacak_adet = 10;  //Fırlatma adedini belirleyin

            int oyuncuSecim; //int oyuncuSecim = 0; bu da kullanılabilir
            int bilgisayarSecim; //int bilgisayarSecim = 0; bu da kullanılabilir

            int i = 0;
            int yaziSayac = 0;
            int turaSayac = 0;
            bool berabere = false;

            while (true)
            {
                Console.WriteLine("1) YAZI");
                Console.WriteLine("2) TURA");
                Console.Write("Seçiminizi Yapınız: ");
                string secim = Console.ReadLine();

                int YAZI = 1;
                int TURA = 2;


                if (!int.TryParse(secim, out oyuncuSecim) || oyuncuSecim < 1 || oyuncuSecim > 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Geçerli Numara Girmediniz Lütfen Tekrar Deneyiniz!");
                    Console.ResetColor();
                }
                else
                {
                    do
                    {
                        int atis = Random.Shared.Next(1, 3);
                        i++;

                        if (atis == 1)
                        {
                            Console.WriteLine("YAZI");
                            yaziSayac++;
                        }
                        else
                        {
                            Console.WriteLine("TURA");
                            turaSayac++;
                        }
                        if (i == firlatilacak_adet)
                        {
                            Console.WriteLine();  // son sayaçtan sonra yazı ile arasında boşluk koyar
                        }

                    } while (i < firlatilacak_adet);

                    if (yaziSayac > turaSayac)
                    {
                        bilgisayarSecim = 1;
                    }
                    else
                    {
                        bilgisayarSecim = 2;
                    }

                    if (yaziSayac == turaSayac) // eşitlik durumunda 1 atış daha yapılır
                    {
                        berabere = true;
                        Console.WriteLine("Toplam YAZI: " + yaziSayac);
                        Console.WriteLine("Toplam TURA: " + turaSayac);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("BERABERE");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("HAYDİ KAZANANI BELİRLEMEK İÇİN 1 ATIŞ DAHA YAPALIM");
                        Console.WriteLine();
                        Console.ResetColor();

                        int finalSecim;

                        while (true)
                        {
                            Console.Write("LÜTFEN SEÇİM YAPINIZ: ");
                            //Console.WriteLine();
                            string final = Console.ReadLine();
                            Console.WriteLine();

                            if (!int.TryParse(final, out finalSecim) || finalSecim < 1 || finalSecim > 2)
                            {
                                Console.WriteLine("Lütfen Geçerli Bir Seçim Yapınız");
                            }
                            else
                            {
                                int finalAtis = Random.Shared.Next(1, 3);
                                Console.WriteLine("ATIŞ SONUCU: " + finalAtis);
                                Console.WriteLine();

                                if (finalAtis == finalSecim)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("TEBRİKLER KAZANDINIZ");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("MAALESEF KAZANAMADINIZ");
                                    Console.ResetColor();
                                }
                                break;
                            }
                        }
                    }

                    else if (oyuncuSecim == bilgisayarSecim)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("TEBRİKLER KAZANDINIZ");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("MAALESEF KAZANAMADINIZ");
                        Console.ResetColor();
                        Console.WriteLine();
                    }

                    if (!berabere)
                    {
                    Console.WriteLine($"Toplam YAZI: {yaziSayac}");
                    Console.Write($"Toplam TURA: {turaSayac}");
                    Console.WriteLine();
                    }

                    break;
                }
            }  
        }   
    }
}