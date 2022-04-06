using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TypeDrug
    {
        private static int _id;
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public TypeDrug()
        {
            _id++;
            _id = Id;
        }
        public string TypeName { get; set; }
        public override string ToString()
        {
            return TypeName;
        }
    }
}
