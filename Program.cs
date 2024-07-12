namespace Algorithms_DataStructursHW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arrNum = { 1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9 };
            Console.WriteLine("The unique number is " + BinarySearch(arrNum));
        }
        public static int BinarySearch(int[] arrToSearch)
        {
            // establish upper and lower bound
            int lower = 0;
            int upper = arrToSearch.Length - 1;

            while (upper > lower) //loops while array is over a size of one
            {
                int mid = (upper + lower) / 2; // finds middleish of array

                if (mid % 2 == 1) // if odd enters statement
                {

                    mid --; // moves back 2 spots
                }

                if (arrToSearch[mid] == arrToSearch[mid + 1]) // if mid index matches following int enter statement
                {
                    lower = mid + 2; // removes left half of array as well as mid index and following match
                }
                else
                    upper = mid; //removes right half of array, only runs if element is in first half of array
               

            }
            return arrToSearch[lower]; // returns lonely element
        }
    }
}
