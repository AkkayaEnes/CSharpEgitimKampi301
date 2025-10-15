using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } //get almak set ayarlamak
        public bool CategoryStatus { get; set; }
    }
}

/*
Field-Variable-Property
 */

//int x; //field
//public int y { get; set; } //property

//void test()
//{
//    int z; //değişken
//}