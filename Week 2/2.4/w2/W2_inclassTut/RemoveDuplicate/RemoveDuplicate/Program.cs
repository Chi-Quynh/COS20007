namespace RemoveDuplicate
{
    public class Program
    {
        static void Main(string[] args)
        {
            // duplicate removal
            // imagine you have a list, which may contain duplicates of some elements
            // [3,5,6,3,9,8] => a duplicate of number 3
            // i want to write a function / method to take in a list and return 
            // another list without duplicates [3,5,6,9,8]
            // 
            List<int> myList = new List<int>();
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(3);
            foreach (int i in myList)
            {
                Console.WriteLine("The element has value {0}",i );
            }

            // create an empty list for returning later
            List<int> rs = new List<int>();
            // check if the rs list doesnt contain the current element
            // add the element into the rs list
            foreach (int i in myList)
            {
                if (!rs.Contains(i))
                {
                    rs.Add(i);
                }
            }

            foreach (int i in rs)
            {
                Console.WriteLine("The rs list has an element with value {0}", i);
            }
            Program objectofPclass = new Program();
            var rs2= new List<int>();
            rs2 = objectofPclass.DuplicateRemove(myList);
            foreach (int i in rs2)
            {
                Console.WriteLine("The rs2 list has an element with value {0}", i);
            }

        }
        public List<int> DuplicateRemove(List<int> myList)
        {
            // create an empty list for returning later
            List<int> rs = new List<int>();
            // check if the rs list doesnt contain the current element
            // add the element into the rs list
            foreach (int i in myList)
            {
                if (!rs.Contains(i))
                {
                    rs.Add(i);
                }
            }
            return rs;
        }
    }
}