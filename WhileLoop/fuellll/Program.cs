using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string gorivo = Console.ReadLine();
            double kolichestvo = double.Parse(Console.ReadLine());
            string karta = Console.ReadLine();
            double otstupka = 0;
            double otstupkaKolichestvo = 0;
            double cena = 0;


            if (karta == "Yes")
            {

                if (gorivo == "Gas")
                {
                    otstupka = kolichestvo * (0.93 - 0.08);

                    if (kolichestvo >= 20 && kolichestvo <= 25)
                    {
                        otstupkaKolichestvo = otstupka - (otstupka * 0.08);
                        Console.WriteLine($"{otstupkaKolichestvo:f2} lv.");
                    }
                    else if (kolichestvo > 25)
                    {
                        otstupkaKolichestvo = otstupka - (otstupka * 0.10);
                        Console.WriteLine($"{otstupkaKolichestvo:f2} lv.");
                    }
                    else
                    {
                        otstupkaKolichestvo = otstupka;
                        Console.WriteLine($"{otstupkaKolichestvo:f2} lv.");
                    }
                }
                else if (gorivo == "Gasoline")
                {
                    otstupka = kolichestvo * (2.22 - 0.12);

                    if (kolichestvo >= 20 && kolichestvo <= 25)
                    {
                        otstupkaKolichestvo = otstupka - (otstupka * 0.08);
                        Console.WriteLine($"{otstupkaKolichestvo:f2} lv.");
                    }
                    else if (kolichestvo > 25)
                    {
                        otstupkaKolichestvo = otstupka - (otstupka * 0.10);
                        Console.WriteLine($"{otstupkaKolichestvo:f2} lv.");
                    }
                    else
                    {
                        otstupkaKolichestvo = otstupka;
                        Console.WriteLine($"{otstupkaKolichestvo:f2} lv.");
                    }
                }
                else if (gorivo == "Diesel")
                {
                    otstupka = kolichestvo * (2.33 - 0.18);

                    if (kolichestvo >= 20 && kolichestvo <= 25)
                    {
                        otstupkaKolichestvo = otstupka - (otstupka * 0.08);
                        Console.WriteLine($"{otstupkaKolichestvo:f2} lv.");
                    }
                    else if (kolichestvo > 25)
                    {
                        otstupkaKolichestvo = otstupka - (otstupka * 0.10);
                        Console.WriteLine($"{otstupkaKolichestvo:f2} lv.");
                    }
                    else
                    {
                        otstupkaKolichestvo = otstupka;
                        Console.WriteLine($"{otstupkaKolichestvo:f2} lv.");
                    }
                }
            }
            else if (karta == "No")
            {
                if (gorivo == "Gas")
                {
                    cena = kolichestvo * 0.93;

                    if (kolichestvo >= 20 && kolichestvo <= 25)
                    {
                        otstupka = cena - (cena * 0.08);
                        Console.WriteLine($"{otstupka:f2} lv.");
                    }
                    else if (kolichestvo > 25)
                    {
                        otstupka = cena - (cena * 0.10); ;
                        Console.WriteLine($"{otstupka:f2} lv.");
                    }
                    else
                    {
                        otstupka = cena;
                        Console.WriteLine($"{otstupka:f2} lv.");
                    }
                }
                else if (gorivo == "Gasoline")
                {
                    cena = kolichestvo * 2.22;
                    if (kolichestvo >= 20 && kolichestvo <= 25)
                    {
                        otstupka = cena - (cena * 0.08);
                        Console.WriteLine($"{otstupka:f2} lv.");
                    }
                    else if (kolichestvo > 25)
                    {
                        otstupka = cena - (cena * 0.10);
                        Console.WriteLine($"{otstupka:f2} lv.");
                    }
                    else
                    {
                        otstupka = cena;
                        Console.WriteLine($"{otstupka:f2} lv.");
                    }
                }
                else if (gorivo == "Diesel")
                {
                    cena = kolichestvo * 2.33;

                    if (kolichestvo >= 20 && kolichestvo <= 25)
                    {
                        otstupka = cena - (cena * 0.08);
                        Console.WriteLine($"{otstupka:f2} lv.");
                    }
                    else if (kolichestvo > 25)
                    {
                        otstupka = cena - (cena * 0.10); ;
                        Console.WriteLine($"{otstupka:f2} lv.");
                    }
                    else
                    {
                        otstupka = cena;
                        Console.WriteLine($"{otstupka:f2} lv.");
                    }

                }
            }

        }
    }
}