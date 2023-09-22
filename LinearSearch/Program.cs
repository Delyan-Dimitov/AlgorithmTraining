using Search.LinearSearch;

var hayStack = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var random = new Random();
var needle = random.Next(1, hayStack.Length);

   Console.WriteLine(LinearSearch.Search(hayStack, needle));