using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alan_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
           
        menu:
            Console.WriteLine("Hesaplama işlemi için 1");
            Console.WriteLine("Çıkış işlemi için 0");
            
            string secenekhesaplama = Console.ReadLine();
            if (secenekhesaplama != "1"&&secenekhesaplama!="0")
            {
                Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                Console.Clear();
                goto menu;
                
            }
            
            
            if (secenekhesaplama == "1")
            {
             hesapturu:
                Console.WriteLine("Alan hesaplamak için 1");
                Console.WriteLine("Çevre hesaplamak için 2");

                string alanislemi = Console.ReadLine();
                if (alanislemi != "1" && alanislemi != "2")
                {
                    Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                    Console.Clear();
                    goto hesapturu;
                     
                }

                if (alanislemi == "1")
                {
                sekilsecim:
                    Console.WriteLine("Üçgen alan hesaplamak için 1");
                    Console.WriteLine("Kare alan hesaplamak için 2");
                    Console.WriteLine("Dikdörtgen alan hesaplamak için 3");
                    Console.WriteLine("Daire alan hesaplamak için 4");
                    string secimalan = Console.ReadLine();
                    if (secimalan != "1" && secimalan != "2"&& secimalan!="3"&&secimalan!="4")
                    {
                        Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                        Console.Clear();
                        goto sekilsecim;
                    }

                    if (secimalan == "1")
                    {
                    uchgentip:
                        Console.WriteLine("Eşkenar üçgen için 1");
                        Console.WriteLine("İkizkenar üçgen için 2");
                        Console.WriteLine("Çeşitkenar üçgen için 3");

                        string ucgencesit = Console.ReadLine();
                        if (ucgencesit != "1" && ucgencesit != "2" && ucgencesit != "3")
                        {
                            Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                            Console.Clear();
                            goto uchgentip;
                            
                        }
                        if (ucgencesit == "1")
                        {
                            try { 
                            Console.WriteLine("Taban uzunluğunu giriniz");
                            int tabanuzun = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Yükseklik giriniz");
                            int yuksek = Convert.ToInt32(Console.ReadLine());
                            int eskenarucgenalan;
                            eskenarucgenalan = (tabanuzun * yuksek) / 2;
                            Console.WriteLine(eskenarucgenalan);
                            Console.ReadKey();
                            goto menu;
                                }
                            catch (Exception e)
                            {
                                Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                                Console.Clear();
                                goto uchgentip;
                                
                            }

                        }
                        else if (ucgencesit == "2")
                        {
                            try { 
                            Console.WriteLine("Taban uzunluğunu giriniz");
                            int ikiztabanuzun = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Yükseklik giriniz");
                            int ikizyuksek = Convert.ToInt32(Console.ReadLine());
                            int ikizkenarucgenalan;
                            ikizkenarucgenalan = (ikiztabanuzun * ikizyuksek) / 2;
                            Console.WriteLine(ikizkenarucgenalan);
                            Console.ReadKey();
                            goto menu;
                                }
                            catch(Exception e)
                            {
                                Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                                Console.Clear();
                                goto uchgentip;
                                
                            }
                        }
                        else if (ucgencesit == "3")
                        {
                            try { 
                            Console.WriteLine("Taban uzunluğunu giriniz");
                            int cesestabanuzun = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Yükseklik giriniz");
                            int cesyuksek = Convert.ToInt32(Console.ReadLine());
                            int ceskenarucgenalan;
                            ceskenarucgenalan = (cesestabanuzun * cesyuksek) / 2;
                            Console.WriteLine(ceskenarucgenalan);
                            Console.ReadKey();
                            goto menu;
                                }
                            catch(Exception e)
                            {
                                Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                                Console.Clear();
                                goto uchgentip;
                               
                            }
                        }
                    }

                    else if (secimalan == "2")
                    {
                     kareaalan:
                        try { 
                        Console.WriteLine("Bir kenarı giriniz");
                        int karekenar = Convert.ToInt32(Console.ReadLine());
                        int karealan;
                        karealan = karekenar * karekenar;
                        Console.WriteLine(karealan);
                        Console.ReadKey();
                        goto menu;
                            }
                        catch(Exception e)
                        {
                            Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                            Console.Clear();
                            goto kareaalan;
                            
                        }
                    }
                    else if (secimalan == "3")
                    {
                        dikalan:
                        try { 
                        Console.WriteLine("Dikdörtgen uzun kenarı giriniz");
                        int kısakenar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dikdörtgen kısa kenarı giriniz");

                        int uzunkenar = Convert.ToInt32(Console.ReadLine());
                        int dörtgenalan;
                        dörtgenalan = kısakenar * uzunkenar;
                        Console.WriteLine(dörtgenalan);
                        Console.ReadKey();
                        goto menu;
                            }
                        catch(Exception e)
                        {
                            Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                            Console.Clear();
                            goto dikalan;
                            
                        }
                    }
                    else if (secimalan == "4")
                    {
                     dairea:
                        try { 
                        Console.WriteLine("Yarıçap giriniz");
                        Console.WriteLine("Pi sayısı 3 olarak girilmiştir");
                        int r = Convert.ToInt32(Console.ReadLine());
                        int dairealan;
                        dairealan = 3 * r * r;
                        Console.WriteLine(dairealan);
                        goto menu;
                            }
                        catch (Exception e)
                        {
                            Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                            Console.Clear();
                            goto dairea;
                            
                        }
                    }

                }
                else if (alanislemi == "2")
                {
                 sekilsecim2:
                    Console.WriteLine("Üçgen çevre hesaplamak için 1");
                    Console.WriteLine("Kare çevre hesaplamak için 2");
                    Console.WriteLine("Dikdörtgen çevre hesaplamak için 3");
                    Console.WriteLine("Daire çevre hesaplamak için 4");
                    string secimcevre = Console.ReadLine();
                    if (secimcevre != "1" && secimcevre != "2" && secimcevre != "3" && secimcevre != "4")
                    {
                        Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                        Console.Clear();
                        goto sekilsecim2;
                        
                    }
                    if (secimcevre == "1")
                    {
                       uchgentip2:
                        Console.WriteLine("Eşkenar üçgen için 1");
                        Console.WriteLine("İkizkenar üçgen için 2");
                        Console.WriteLine("Çeşitkenar üçgen için 3");

                        string ucgencesit = Console.ReadLine();
                        if (ucgencesit != "1" && ucgencesit != "2" && ucgencesit != "3")
                        {
                            Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                            Console.Clear();
                            goto uchgentip2;
                            
                        }
                        if (ucgencesit == "1")
                        {
                            esc:
                            try { 
                            Console.WriteLine("Kenar uzunluğunu giriniz");
                            int tabanuzun = Convert.ToInt32(Console.ReadLine());

                            int eskenarucgenalan;
                            eskenarucgenalan = (tabanuzun * 3);
                            Console.WriteLine(eskenarucgenalan);
                            Console.ReadKey();
                            goto menu;
                                }
                            catch(Exception e)
                            {
                                Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                                Console.Clear();
                                goto esc;
                                
                            }

                        }
                        else if (ucgencesit == "2")
                        {
                            ikizc:
                            try { 
                            Console.WriteLine("Taban uzunluğunu giriniz");
                            int ikiztabanuzun = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("İkiz kenarlardan birinin uzunluğunu giriniz");
                            int ikizyuksek = Convert.ToInt32(Console.ReadLine());
                            int ikizkenarucgenalan;
                            ikizkenarucgenalan = (ikiztabanuzun + ikizyuksek * 2);
                            Console.WriteLine(ikizkenarucgenalan);
                            Console.ReadKey();
                            goto menu;
                                }
                            catch(Exception e)
                            {
                                Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                                Console.Clear();
                                goto ikizc;
                                
                            }
                        }
                        else if (ucgencesit == "3")
                        {
                            cesc:
                            try { 
                            Console.WriteLine("1. kenar uzunluğunu giriniz");
                            int birincikenar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("2. kenar uzunluğunu giriniz");
                            int ikincikenar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("3. kenar uzunluğunu giriniz");
                            int ucuncukenar = Convert.ToInt32(Console.ReadLine());
                            int ceskenarucgenalan;
                            ceskenarucgenalan = (birincikenar + ikincikenar + ucuncukenar);
                            Console.WriteLine(ceskenarucgenalan);
                            Console.ReadKey();
                            goto menu;
                                }
                            catch(Exception e)
                            {
                                Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                                Console.Clear();
                                goto cesc;
                               
                            }
                        }
                        
                        Console.ReadKey();

                    }
                    else if (secimcevre == "2")
                    {
                        karec:
                        try { 
                        Console.WriteLine("Bir kenarı giriniz");
                        int karekenar = Convert.ToInt32(Console.ReadLine());
                        int karealan;
                        karealan = 4 * karekenar;
                        Console.WriteLine(karealan);
                        Console.ReadKey();
                        goto menu;
                            }
                        catch (Exception e)
                        {
                            Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                            Console.Clear();
                            goto karec;
                            
                        }

                    }
                    else if (secimcevre == "3")
                    {
                        dikc:
                        try { 
                        Console.WriteLine("Dikdörtgen uzun kenarı giriniz");
                        int kısakenar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dikdörtgen kısa kenarı giriniz");

                        int uzunkenar = Convert.ToInt32(Console.ReadLine());
                        int dörtgenalan;
                        dörtgenalan = (kısakenar + uzunkenar) * 2;
                        Console.WriteLine(dörtgenalan);
                        Console.ReadKey();
                        goto menu;
                            }
                        catch(Exception e)
                        {
                            Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                            Console.Clear();
                            goto dikc;
                            
                        }
                    }
                    else if (secimcevre == "4")
                    {
                        daic:
                        try { 
                        Console.WriteLine("Yarıçap giriniz");
                        Console.WriteLine("Pi sayısı 3 olarak girilmiştir");
                        int r = Convert.ToInt32(Console.ReadLine());
                        int dairealan;
                        dairealan = 3 * r * 2;
                        Console.WriteLine(dairealan);
                        goto menu;
                            }
                        catch(Exception e)
                        {
                            Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!!");
                            Console.Clear();
                            goto daic;
                            
                        }
                    }
                    else if (secenekhesaplama == "0")
                    {
                        Environment.Exit(0);
                    }

                }
            }
        }
    }
}
