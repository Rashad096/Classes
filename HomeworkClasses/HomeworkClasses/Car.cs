using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClasses
{
    internal class Car
    {
        //    Aşağıdaki parametrlərə sahib Car class yaradın
        //- Brand
        //- Model
        //- CurrentFuel - masinin hazirki benzin miqdari
        //- FuelFor1Km - masinin 1 km ucun xerclediyi benzin
        //- Millage - Masinin bu vaxtadək neçə km sürüldüyü
        //- Drive() - sürülmə metodu.Bu metod int parametr qeəbul edir (neçə km sürmək istədiyimiz)
        // Car obyekti yaradın drive metodunu işə saldıqda arqument olaraq neçə km sürmək istədyimizi daxil
        // edirik və əgər benzin kifayət edirsə maşının millage dəyəri coxalir və benzini azalır, benzin kifayət etmirsə
        // console-da xəta mesajı yazılır


        public string Brand;
        public string Model;
        public int CurrentFuel;
        public int FuelFor1Km;
        public int Millage;

        public void Drive(int km)
        {
            if (CurrentFuel/FuelFor1Km>=km)
            {

                CurrentFuel -= FuelFor1Km * km;
                Millage += km;
                Console.WriteLine("Yanacag deyeri yeterlidir");
                
            }
            else
            {
                Console.WriteLine("Yanacag deyeri yetersizdir");
            }
            
        }

        


    }
}
