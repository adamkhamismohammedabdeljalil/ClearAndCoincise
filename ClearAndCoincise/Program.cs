using System.Linq;

var random = new Random();

var range = Enumerable.Range(0, 1000).Select(number => random.Next(0, 2000)).ToList();

Console.WriteLine("Uneven numbers");

printAll(GetUnEvenNumbersMethod(range));
void printAll(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        Console.WriteLine(number + " ");
    }
    Console.WriteLine();
}
foreach (var item in range)
{
    Console.WriteLine(item);
}

//Method syntax
IEnumerable<int> GetUnEvenNumbersMethod(IEnumerable<int> numbers)
{
    //return (from number in numbers
    //        where number % 2 == 1
    //        select number);
   return numbers.Where(number=>number%2==1).Select(number=>number);

}

