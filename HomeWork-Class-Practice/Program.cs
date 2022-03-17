using HomeWork_Class_Practice.Models;
using System;

namespace HomeWork_Class_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             int type_count = GetInputCount("Please write how many laptops do you need : ",0);

            
            Notebook[] notebooks = new Notebook[type_count];
            for (int i = 0; i < type_count; i++)
            {
                Console.WriteLine("------------------------------");

                
                string brandname = GetInputLength ($"Please enter the {i + 1} brand name: ",2, 15);

                string model =  GetInputLength($"Please enter the {i + 1} model: ",1,15);

                int ram = GetInputCount ($"Please enter the {i + 1} RAM: ",1,1000);

                int storage = GetInputCount($"Please enter the {i + 1} size of storage: ",15,3000);

                double price = GetInputCount($"Please enter the {i + 1} Price: ",99,10000);

                
                int count = GetInputCount ($"Please enter the {i + 1} count: ",1,10);



                notebooks[i] = new Notebook(brandname, price, count)
                {

                    Model = model,
                    Ram = ram,
                    Storage = storage
                };
                //notebooks[i].Model = model;
                //notebooks[i].Ram = ram;
                //notebooks[i].Storage = storage;
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("List of notebooks");
            foreach (var item in notebooks)
            {
                item.GetInfo();
                Console.WriteLine("-----------------------");
            }

            static string GetInputLength(string name,int min,int max=15)
            {
                
                string input;
                
                do
                {
                    Console.Write(name);
                    input = (Console.ReadLine());

                } while (input.Length < min || input.Length > max);
                return input;
            }

            static int GetInputCount(string name, int min, int max = 10)
            {

                int input;

                do
                {
                    Console.Write(name);
                    input = (Convert.ToInt32(Console.ReadLine()));

                } while (input <= min || input > max);
                return input;
            }


        }
    }
}
