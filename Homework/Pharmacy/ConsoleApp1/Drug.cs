using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Drug
    {
        private static int _id;
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public Drug()
        {
            _id++;
            _id = Id;
        }
        public string Name { get; set; }
        public TypeDrug Type { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
       
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, Count: {Count}";
        }
    }
}
