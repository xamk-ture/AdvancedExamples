namespace CollectionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //you can run each method individually to see the output
            //if you do not want to run a method, comment it out
            WhereExample();
            WhereExample2();
            OrderByExample();
            FirstAndSingleOrDefault();
            CountExample();
        }

        /// <summary>
        /// This method demonstrates the use of the Where method
        /// </summary>
        private static void WhereExample()
        {
            Console.WriteLine("Where Example");

            var items = new List<int> { 1, 2, 3, 4, 5 };

            var selectedItems = items.Where(x => x < 3);

            foreach (var item in selectedItems)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// This example shows how to do the same thing as in WhereExample() but without using the Where method (what the where method does under the hood)
        /// </summary>
        private static void WhereExample2()
        {
            Console.WriteLine("WhereExample2");

            var items = new List<int> { 1, 2, 3, 4, 5 };

            var selectedItems = new List<int>();

            foreach (var item in items)
            {
                if (item < 3)
                {
                    selectedItems.Add(item);
                }
            }

            foreach (var item in selectedItems)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// This method demonstrates the use of the OrderBy method
        /// </summary>
        private static void OrderByExample()
        {
            Console.WriteLine("Order By Example");

            var numbers = new List<int> { 6, 4, 5, 8, 1};

            var orderedNumbers = numbers.OrderBy(x => x);

            Console.WriteLine("Ordered Numbers");

            foreach (var number in orderedNumbers)
            {
                Console.WriteLine(number);
            }

            var decendingNumbers = numbers.OrderByDescending(x => x);

            Console.WriteLine("Decending Numbers");

            foreach (var number in decendingNumbers)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// This demonstrates how to fetch single item from collection
        /// </summary>
        private static void FirstAndSingleOrDefault()
        {
            Console.WriteLine("First and Single or Default Example");

            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            //FirstOrDefault always returns the first item from the collection that matches the predicate
            var firstNumber = numbers.FirstOrDefault(x => x > 3);
            Console.WriteLine(firstNumber);

            //SingleOrDefault goes through the whole collection and returns the item that matches the predicate
            //If more than one item is found it will return an error
            var singleNumber = numbers.SingleOrDefault(x => x == 3);
            Console.WriteLine(singleNumber);
        }

        /// <summary>
        /// Usage: When you want to count the number of items in a collection (optionally based on a predicate).
        /// </summary>
        private static void CountExample()
        {
            var words = new List<string> { "apple", "banana", "cherry" };
            var countShortWords = words.Count(word => word.Length <= 5);

            Console.WriteLine(countShortWords);
        }


    }
}