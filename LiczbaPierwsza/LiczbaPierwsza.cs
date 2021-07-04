using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbaPierwsza
{
    /// <summary>
    /// Sprawdza czy podana liczba przez użytkownika jest liczbą pierwszą
    /// </summary>
    class LiczbaPierwsza
    {
        /// <summary>
        /// Pobiera wartość dodatnią całkowitą od użytkownika.
        /// </summary>
        /// <param name="komunikat">string jaki ma się wyświetlić użytkownikowi</param>
        /// <returns></returns>
        private static int PobierzIntDodatni(string komunikat)
        {
            string sLiczba;
            int nLiczba = 0;
            bool czyLiczba = false;
            do
            {
                Console.Write("{0}", komunikat);
                sLiczba = Console.ReadLine();
                if (int.TryParse(sLiczba, out nLiczba))
                {
                    if (nLiczba > 0)
                        czyLiczba = true;
                    else
                        Console.WriteLine("'{0}' - nie jest liczba całkowitą większą od 0.", sLiczba);
                }
                else
                {
                    Console.WriteLine("'{0}' - nie jest liczba całkowitą większą od 0.", sLiczba);
                }
            } while (!(czyLiczba));
            return nLiczba;
        }
        
        /// <summary>
        /// Sprawdza czy podana liczba jest liczbą pierwszą.
        /// </summary>
        /// <param name="nLiczba">int liczba</param>
        /// <returns>bool true/false</returns>
        private static bool CzyLiczbaPierwsza(int nLiczba)
        {
            if (nLiczba < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(nLiczba); i++)
                {
                    if (nLiczba % i == 0 && i != nLiczba) return false;
                }
                return true;
            }
        }
        
        /// <summary>
        /// Pobiera od użytkowniak wartość z klawiatury i sprawdza czy podana wartość jest liczbą pierwszą.
        /// </summary>
        public static void SprawdzCzyLiczbaPierwsza()
        {
            Console.WriteLine("Sprawdzanie czy podana liczba jest liczbą pierwszą.\n");
            int nLiczba = PobierzIntDodatni("Podaj liczbę całkowitą dodatnią: ");
            if (CzyLiczbaPierwsza(nLiczba))
            {
                Console.WriteLine("\nLiczba {0} jest liczbą pierwszą.\n", nLiczba);
            } 
            else
            {
                Console.WriteLine("\nLiczba {0} nie jest liczbą pierwszą.\n", nLiczba);
            }
        }

    }

}
