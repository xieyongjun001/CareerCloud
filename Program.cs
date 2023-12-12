using System;
using GenericClass;

class Program
{
    static void Main()
    {
        #region for Generic
        GenericClass<int> intCollection = new GenericClass<int>();

        intCollection.AddItem(5);
        intCollection.AddItem(3);
        intCollection.AddItem(9);
        intCollection.AddItem(1);
        intCollection.AddItem(7);

        Console.WriteLine("Item at index 2: " + intCollection.GetItem(2));

        Console.WriteLine("Sorted collection in descending order:");
        foreach (int item in intCollection.GetSortedDescending())
        {
            Console.WriteLine(item);
        }

        #endregion


    }
}
