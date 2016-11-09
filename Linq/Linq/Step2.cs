using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq
{
    public class Step2
    {
        public void Execute()
        {
            Console.WriteLine("\nStep 2: Enkele eenvoudige Linq operatoren.\n");

            // Enkele Linq methodes op collecties van getallen
            int[] getallen = { 2, 8, 10 };
            Console.WriteLine("De som is {0}", getallen.Sum());

            List<int> myList = new List<int>();
            myList.Add(2);
            myList.Add(10);
            myList.Add(10);
            Console.WriteLine("De som is van de getallen in de lijst is {0}", myList.Sum());

            HashSet<double> getallenSet = new HashSet<double> { 2.5, 8.4, 10.6 };
            getallenSet.Add(2.5);
            getallenSet.Add(8.4);
            getallenSet.Add(10.6);
            Console.WriteLine("De som van de getallen in de hashset is  {0} ...", getallenSet.Sum());
            Console.WriteLine("Het minimum in de hashset is  {0} ...", getallenSet.Min());
            Console.WriteLine("De maximum in de hashset is  {0} ...", getallenSet.Max());

            Stack<float> getallenStack = new Stack<float>();
            getallenStack.Push(1.5F);
            getallenStack.Push(2.6F);
            getallenStack.Push(5F);
            float somStack = getallenStack.Sum();
            Console.WriteLine("De som van de getallen op de stack is  {0} ...", getallenStack.Sum());
            Console.WriteLine("Het gemiddelde van de getallen op de stack is  {0} ...", getallenStack.Average());
            Console.WriteLine("Het aantal getallen op de stack is  {0} ...", getallenStack.Count());

            Console.WriteLine("Druk op enter om verder te gaan...");
            Console.ReadLine();
        }
    }
}
