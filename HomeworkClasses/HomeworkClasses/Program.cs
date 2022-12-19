using System;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace HomeworkClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Task
            ////1-ci tapşırıqda yaratdığınız Notebook classindan bir notebook array-i duzeldin
            ////Layihə işə düşdükdə bizdən minPrice dəyəri daxil etməyimizi və daha sonra maxPrice dəyəri daxil
            ////etməyimizi istəsin.
            ////sonra yaratmış olduğumuz array - də minPrice və maxPrice aralığında qiyməti olan notebookların
            ////adlarını console - a yazdırsız

            //NoteBook notebook1 = new NoteBook()
            //{
            //    Name = "Rog strix",
            //    Brand = "Asus",
            //    Price = 2600

            //};

            //NoteBook notebook2 = new NoteBook()
            //{
            //    Name = "MacBookpro",
            //    Brand = "Apple",
            //    Price = 2900

            //};

            //NoteBook notebook3 = new NoteBook()
            //{
            //    Name = "Lenovo",
            //    Brand = "GamePad",
            //    Price = 3900

            //};

            //NoteBook notebook4 = new NoteBook()
            //{
            //    Name = "HP",
            //    Brand = "345S",
            //    Price = 6900

            //};


            //NoteBook notebook5 = new NoteBook()
            //{
            //    Name = "Asus",
            //    Brand = "TUF",
            //    Price = 8900

            //};





            //Console.WriteLine("minPrice daxil et: ");
            //var input=Console.ReadLine();
            //double minPrice = Convert.ToDouble(input);

            //Console.WriteLine("maxPrice daxil et: ");
            //var input1 = Console.ReadLine();
            //double maxPrice = Convert.ToDouble(input1);


            //NoteBook[] notebooks = { notebook1,notebook2,notebook3,notebook4,notebook5};

            //for (int i = 0; i < notebooks.Length; i++)
            //{
            //    if (notebooks[i].Price > minPrice && notebooks[i].Price < maxPrice)
            //    {
            //        Console.WriteLine(notebooks[i].Brand);
            //    }


            //}



            Car car1 = new Car()
            {
                Brand = "BMW",
                Model = "X5M",
                CurrentFuel = 50,
                FuelFor1Km = 1,
                Millage = 35,
            };

            car1.Drive(15);
            

            
        }
    }
}
