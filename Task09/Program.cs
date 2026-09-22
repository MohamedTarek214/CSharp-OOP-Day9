namespace Task09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01
            #region Problem1
            //Console.WriteLine($"Monday = {(int)Weekdays.Monday}");
            //Console.WriteLine($"Tuesday = {(int)Weekdays.Tuesday}");
            //Console.WriteLine($"Wednesday = {(int)Weekdays.Wednesday}");
            //Console.WriteLine($"Thursday = {(int)Weekdays.Thursday}");
            //Console.WriteLine($"Friday = {(int)Weekdays.Friday}");

            //Console.WriteLine("*****************************");

            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine($"{day} = {(int)day}");
            //} 
            #endregion

            #region Problem2
            //foreach (Grades grade in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"{grade} = {(short)grade}");
            //} 
            #endregion

            #region Problem3
            //Child child = new Child();

            //child.Salary = 5000;

            //child.DisplaySalary(); 
            #endregion

            #region Problem4
            //int result = Utility.CalculatePerimeter(10, 5);

            //Console.WriteLine($"Perimeter = {result}"); 
            #endregion

            #region Problem5
            //ComplexNumber num1 = new ComplexNumber(2, 3);
            //ComplexNumber num2 = new ComplexNumber(4, 5);

            //ComplexNumber result = num1 * num2;

            //result.Display(); 
            #endregion

            #region Problem6
            //double result = Utility.CelsiusToFahrenheit(25);

            //Console.WriteLine($"Fahrenheit = {result}"); 
            #endregion
            #endregion



            #region Part02
            #region Problem1
            //// Integers
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int[] ReversedNumbers = Utility.ReverseArray(numbers);

            //Console.WriteLine("Integers:");
            //foreach (int number in ReversedNumbers)
            //    Console.WriteLine(number);

            //// Strings
            //string[] names = { "Ahmed", "Mohamed", "Ali" };
            //string[] ReversedNames = Utility.ReverseArray(names);

            //Console.WriteLine("\nStrings:");
            //foreach (string name in ReversedNames)
            //    Console.WriteLine(name);

            //// Custom Objects
            //Person[] people =
            //{
            //new Person("Ahmed"),
            //new Person("Mohamed"),
            //new Person("Ali")
            //};


            //Person[] ReversedPeople = Utility.ReverseArray(people);

            //Console.WriteLine("\nPeople:");
            //foreach (Person person in ReversedPeople)
            //{
            //    Console.WriteLine(person.Name);
            //} 
            #endregion

            #region Problem2
            //MyStack<int> numbers = new MyStack<int>();
            //numbers.Push(10);
            //numbers.Push(20);
            //numbers.Push(30);
            //Console.WriteLine($"Peek: {numbers.Peek()}");
            //Console.WriteLine($"Pop: {numbers.Pop()}");
            //Console.WriteLine($"Pop: {numbers.Pop()}");

            //MyStack<string> names = new MyStack<string>();
            //names.Push("Ahmed");
            //names.Push("Mohamed");
            //Console.WriteLine($"Peek: {names.Peek()}");
            //Console.WriteLine($"Pop: {names.Pop()}"); 
            #endregion

            #region Problem3
            //int[] numbers = { 10, 20, 30, 40 };

            //Utility.Swap(numbers, 1, 3);

            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //} 
            #endregion



            #endregion



            Console.ReadKey();
        }
    }
}
