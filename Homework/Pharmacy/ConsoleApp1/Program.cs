using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Drug drug = new Drug();

            drug.Name = "Spazmalqon";
            drug.Price = 5;
            drug.Count = 10;

            Console.WriteLine(drug.ToString());

            Drug drug1 = new Drug();
            drug1.Name = "Nimesil";
            drug1.Price =3;
            drug1.Count = 10;

            Console.WriteLine(drug1.ToString());

            Pharmacy pharmacy = new Pharmacy();
            pharmacy.AddDrug(drug);
            pharmacy.AddDrug(drug1);
            pharmacy.DrugList();
            pharmacy.SaleDrug("Nimesil", 2, 1);

            



        }
    }
}
