using System.Collections.Generic;
namespace CollectionsTutorial
{
    internal class CollectionTutorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // create a list of strings
            var myList = new List<string>();
            // add 5 elements into the current list
            myList.Add("Eric Le");
            myList.Add("John Cena");
            myList.Add("Shake Spear");
            myList.Add("Megan Fox");
            myList.Add("Trump Pet");
            // first way to access elements inside the list : foreach
            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }
            // second way is to use the normal for statement
            for (int i=0;i<myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            // remove some element inside the list
            bool x;
            x = myList.Remove("Biden");
            Console.WriteLine(x);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            // a way to check if an element is existing in the list
            Console.WriteLine("Checking if the element is in the list");
            if (myList.Contains("Eric Le"))
            {
                Console.WriteLine("The element Eric Le is inside the list");
            }
            // to use the IndexOf 
            Console.WriteLine("The index of the Element Eric Le is {0}", myList.IndexOf("Eric Le"));
            Console.WriteLine("The number of elements inside the list is {0}",myList.Count);
            // create a list
            Console.WriteLine("We are creating a Dictionary");
            Dictionary<String, int> myDict = new Dictionary<string, int>();
            myDict.Add("John", 24);
            myDict.Add("Obama", 45);
            myDict.Add("Camella", 35);
            // access the elements in the dictionary
            foreach (var item in myDict)
            {
                Console.WriteLine("key of {0} and a value of {1}",item.Key,item.Value);


            }
            // to check if a key is contained inside a dictionary
            if (myDict.ContainsKey("Obama"))
            {
                Console.WriteLine("Obama is in the dictionary");
            }
            // ContainsValue method to check 
        }
    }
}