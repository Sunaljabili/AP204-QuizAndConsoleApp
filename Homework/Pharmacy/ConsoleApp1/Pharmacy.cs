using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Pharmacy
    {
        public string Name { get; set; }
        private static int _id;
        public Drug[] drugArr = new Drug[0];
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public Pharmacy()
        {
            _id++;
            _id = Id;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }

        public void AddDrug (Drug drug)
        {
         Array.Resize(ref drugArr, drugArr.Length + 1);
          drugArr[drugArr.Length - 1] = drug;
            
        }
        public void DrugList()
        {
            foreach (var item in drugArr)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Count: {item.Count}, Type : {item.Type}");
            }
        }
        public void SaleDrug(string name,int count,int money)
        {
            bool check = false;
            foreach (var item in drugArr)
            {
                if(item.Name==name && item.Count>=count && item.Price <= money)
                {
                    item.Count--;
                    Console.WriteLine(item);
                    check = true;
                }
              
            }
            if (!check)
            {
                Console.WriteLine("Satish yoxdur");
            }
        }
    }
}
