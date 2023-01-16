using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Object_Oriented_Program
{
    internal class InventoryManager
    {
        
       
        public void Convert(string jFilePath)
        {
           
            using (StreamReader file = new StreamReader(jFilePath))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<InventoryFactory>(json);
                Console.WriteLine("Items Price Weight TotalValue");
                double value1=0,value2=0,value3=0,totalValue;
                foreach (var objects in items.RiceList)
                {
                    double value = objects.PricePerKg * objects.Weight;
                    Console.WriteLine(objects.Name + " -> " + objects.PricePerKg + " -> " + objects.Weight + " -> " + value);
                    value1 += value;
                }
                foreach(var objects in items.WheatList)
                {
                    double value = objects.PricePerKg * objects.Weight;
                    Console.WriteLine(objects.Name + " -> " + objects.PricePerKg + " -> " + objects.Weight + " -> " + value);
                    value2 += value;
                }
                foreach (var objects in items.PulsesList)
                {
                    double value = objects.PricePerKg * objects.Weight;
                    Console.WriteLine(objects.Name + " -> " + objects.PricePerKg + " -> " + objects.Weight + " -> " + value);
                    value3 += value;
                }
                totalValue = value1 + value2 + value3;
                Console.WriteLine("Total Inventaory is" + totalValue);

            }
        }
    }
}
