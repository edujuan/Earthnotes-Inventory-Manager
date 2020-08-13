using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM495
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public int TypeID { get; set; }

        //h

        public string FullInfo
            //basically a string that would contain all of the info when we get values from DB
        {
            get 
            { 
                // "Juan Viera (juan@gmail.com)"
                return $"{ Name } has only { Quantity } units left"; 
            }
        }

    }



}