using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamiloton_Tevin_List
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            List<string> itemListString = new List<string>() { "tv", "ipad", "ipod", "iphone", "apple tv", "ps4", "xbox" };
            List<decimal> itemListNum = new List<decimal>() { 400, 199, 199, 800, 129, 299, 399 };

            CombineTheList(itemListString, itemListNum);




            itemListString.Remove("tv");
            itemListString.Remove("ipad");
            itemListNum.Remove(400);
            itemListNum.Remove(199);
            itemListString.Insert(0, "alienware");
            itemListNum.Insert(0, 700);

            Console.WriteLine("The progrem is going to make a few changes to the list.\r\n");

            CombineTheList(itemListString, itemListNum);
        }
        public static void CombineTheList(List<string> its, List<decimal> iln)
        {
            for (int i = 0; i < its.Count; i++)
            {
                Console.WriteLine($"The {its[i]} Costs {iln[i].ToString("c")}\r\n");
            }


        }
    }
}
