using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sw
{

    class Program
    {
        [Firm("Nestle", "USA")]
        static void Main(string[] args)
        {
            //    GetAttribute(typeof(Chocolate));
            //}


            //Chocolate aa = new Chocolate(30, "Milk", 200);
            //aa.Output();
            //Console.ReadLine();
        }
        [Firm("Nestle", "USA")]
        public void GetAttribute(Type t)
        {
            GetAttribute(typeof(Chocolate));
            Firm att = (Firm)Attribute.GetCustomAttribute(t, typeof(Firm));


            Console.WriteLine("name:{0} country {1} ", att.name, att.country);
            Console.ReadLine();
            Chocolate aa = new Chocolate(30, "Milk", 200);
            aa.Output();
            Console.ReadLine();
        }
        //ListTest a = new ListTest();
        //a.OutSorted(a.ListCollect());
        //Console.ReadLine();
            

            }
        }
    
        
                    //Console.ReadLine();

                    //ListTest a = new ListTest();
                    //a.ListCollect();

                    // ListTest b = new ListTest();
                    //a.OutSorted(a.ListCollect());

                    //Dark bb = new Dark();
                    //bb.Outputd();
                    
             
             
            
        

