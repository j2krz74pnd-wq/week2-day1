// // // // //task 1
// // // // // List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5 };
// // // // // int sum = numbers1.Sum();
// // // // // Console.WriteLine("The sum of all the elements in the list is: " + sum);


// // // // //task 2
// // // // List<string> words = new List<string> { "hello", "world", "!" };
// // // // string concat = string.Concat(words); 
// // // // Console.WriteLine("The concatenated string is: " + concat);


// // // //task 3
// // // List<DateTime> dates = new List<DateTime>
// // // {
// // //     new DateTime(2020, 10, 1),
// // //     new DateTime(2022, 8, 15),
// // //     new DateTime(2021, 4, 28)
// // // };
// // // dates.Sort();
// // // Console.WriteLine("The sorted dates are:");
// // // foreach (DateTime date in dates)
// // // {
// // //     Console.WriteLine(date.ToShortDateString());
// // // }


// // //task 4
// // List<double> numbers = new List<double> {3.5, 2.7, 6.9, 1.2};
// // double average = numbers.Average();
// // System.Console.WriteLine("The average value of all the elements in the list is: " + average);


// //task 5
// List<int> numbers = new List<int>{1,2,3,4,5};
// List<int> evenNumber = numbers.FindAll(n => n%2==0);
// Console.WriteLine("The filtered numbers are:");
// foreach (int number in evenNumber)
// {
//         Console.WriteLine(number);

// }


// //task 6
// List<bool> values = new List<bool> { true, true, true };
// bool allTrue = values.All(v => v);
// System.Console.WriteLine("Are all the values in the list true ? " + allTrue);


//task 7
// List<string> item = new List<string>{"apple", "banana", "cherry"};
// item.Remove("banana");
// System.Console.WriteLine("List after removal"); 
// foreach (var items in item)
// {
//     System.Console.WriteLine(items);
// }


//task 8
// List<string> items8 = new List<string> { "apple", "banana", "cherry" };
// bool found = items8.Contains("banana");
// Console.WriteLine("Is the element found? " + found);


//task 9
// List<int> numbers9 = new List<int>();
// numbers9.Add(10);
// numbers9.Add(20);
// numbers9.AddRange(new[] { 30, 40, 50 });
// Console.WriteLine("All numbers in the list:");
// foreach (var number in numbers9)
// {
//     Console.WriteLine(number);
// }


//task 10
List<int> numbers10 = new List<int>();
Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    numbers10.Add(rnd.Next(1, 101));           // 1..100
}
Console.WriteLine("Random numbers in the list:");
foreach (var number in numbers10)
{
    Console.WriteLine(number);
}