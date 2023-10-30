using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicKnowledge
{
    class StaticInClass
    {
        //Non static members
        public string message = "Hello World";
        public string Name { get; set; }
        public void DisplayName()
        {
            Console.WriteLine("Name = {0}", Name);
        }
        //static members
        public static string greetings = "Good morning";
        public static int Age { get; set; }
        public static void DisplayAge()
        {
            Console.WriteLine("Age = {0}", Age);
        }
    }
    public class Staff
    {
        //Constructor 
        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("--------------------------");
        }
        // Fields
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;
        //Properties
        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0) hWorked = value;
                else hWorked = 0;
            }

        }
        //Methods
        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }
        public int CalculatePay()
        {
            PrintMessage();
            int staffPay;
            staffPay = hWorked * hourlyRate;
            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }
        //Overloading function (2 function are same name)
        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();
            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }
        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + ", hourlyRate = " +
            hourlyRate + ", hWorked = " + hWorked;
        }
    }
    public class Person
    {
        //Fields (data members )
        private string name;
        private int age;
        //constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //Method 

    }
    public class BasicKnowledge_
    {
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            string inputString = "10";
            if (int.TryParse(inputString, out int number))
            {
                Console.WriteLine("Successful with number: " + number);
            }
            else
            {
                Console.WriteLine("Error");
            }
             
        }
        static void printArray(int[] arraytemp)
        {
            for (int i = 0; i < arraytemp.Length; i++)
            {
                Console.Write(arraytemp[i] + " ");
            }
            Console.WriteLine();
        }
        static void array()
        {
            int[] userAge1 = { 21, 22, 23, 24, 25 };
            Console.Write("Declaration array: ");
            for (int i = 0; i < userAge1.Length; i++)
            {
                Console.Write(userAge1[i] + " ");
            }
            Console.WriteLine();
            int[] userAge2;
            userAge2 = new[] { 12, 1, 5, -2, 16, 14 };
            string numbersString = string.Join(", ", userAge2);
            Console.Write("Declaration array: ");
            Console.WriteLine(numbersString);
            //Copy array 
            int[] userAge3 = { 1, 2, 3, 4 };
            Array.Copy(userAge2, userAge3, 3);  //21 22 24 4 
            Console.Write("Array after copying: ");
            printArray(userAge3);
            // Sort the array 
            Array.Sort(userAge2);
            Console.Write("Sorted array: ");
            printArray(userAge2);

            // Index of Value
            int ans = Array.IndexOf(userAge3, 4);
            Console.Write("Index of value 4 in userAge3: " + ans);
            Console.WriteLine();

            Console.Write("Reversed Array: ");
            Array.Reverse(userAge3);
            printArray(userAge3);
            Console.WriteLine();

             
        }
        static void String()
        {
            string str = "Hello, World!";
            //length
            int length = str.Length;
            Console.WriteLine("Length: " + length);
            // Contains
            bool contains = str.Contains("World");
            Console.WriteLine("Contains 'World': " + contains);
            // Substring
            string substring = str.Substring(7);
            Console.WriteLine("Substring: " + substring);
            substring = str.Substring(2, 8);
            Console.WriteLine("Substring1: " + substring);
            // IndexOf
            int index = str.IndexOf("World");
            Console.WriteLine("Index of 'World': " + index);

            // Replace
            string replaced = str.Replace("World", "Universe");
            Console.WriteLine("Replaced: " + replaced);

            // ToUpper
            string uppercase = str.ToUpper();
            Console.WriteLine("Uppercase: " + uppercase);

            // ToLower
            string lowercase = str.ToLower();
            Console.WriteLine("Lowercase: " + lowercase);

            // IsNullOrEmpty
            bool isNullOrEmpty = string.IsNullOrEmpty(str);
            Console.WriteLine("Is Null or Empty: " + isNullOrEmpty);

            // IsNullOrWhiteSpace
            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(str);
            Console.WriteLine("Is Null or WhiteSpace: " + isNullOrWhiteSpace);

            // split 
            str = str + ", My name is Quat ";
            string[] splitArray = str.Split(' ');
            Console.Write("Split Array:");
            foreach (string splitValue in splitArray)
            {
                Console.Write(splitValue.Trim() + "   ");
            }

             
        }
        static void List_()
        {
            var lists = new List<string>();
            lists.Add("Quat");
            var names = new List<string>() { "Mack", "Daisy", "Ward" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            names.Add("Thuan");
            // Check the number of elements in the list
            Console.WriteLine("Number of elements: " + names.Count);
            names.Remove("Ward");
            names.RemoveAt(0);
            // Check if an element exists in the list
            bool containsBanana = names.Contains("Ward");
            Console.WriteLine("Contains 'Ward': " + containsBanana);

            // Sort the list
            names.Sort();
            Console.WriteLine("List elements:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
             
        }
        static public void CalculateStaffWages()
        {
            //List_();
            int pay;
            Staff staff1 = new Staff("Peter");
            staff1.HoursWorked = 100;
            pay = staff1.CalculatePay(10, 40);
            Console.WriteLine("Pay = {0}", pay);

            Staff staff2 = new Staff("Jane");
            staff2.HoursWorked = 160;
            pay = staff2.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);

            Staff staff3 = new Staff("Carol");
            staff3.HoursWorked = -10;
            pay = staff3.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);

            string staff1_message = staff1.ToString();
            Console.WriteLine(staff1_message);
             
        }
        static void executingStaticClass()
        {
            StaticInClass classA = new StaticInClass();
            Console.WriteLine(classA.message);
            classA.Name = "Jamie";
            classA.DisplayName();

            Console.WriteLine(StaticInClass.greetings);
            StaticInClass.Age = 39;
            StaticInClass.DisplayAge();

             
        }
        static public void PrintNames(params string[] names)
        {
            for (int i =0; i < names.Length; i++)
            {
                Console.Write(names[i] + "  ");
            }
            Console.WriteLine();
        }
    }
    public class Enumeration
    {
        //Enum definition 
        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        //Enum value 
        enum DaysOfWeek1
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static public void usingEnum()
        {
            DaysOfWeek today = DaysOfWeek.Monday;
            Console.WriteLine(today);
            int dayValue =(int) DaysOfWeek1.Thursday;
            Console.WriteLine(dayValue);
        }
    }
public struct MyStruct
    {
        private int x;
        private int y;
        private AnotherClass myClass;
        private Days myDays;

        public MyStruct(int a, int b, int c)
        {
            myClass = new AnotherClass();
            myClass.Number = a;
            x = b;
            y = c;
            myDays = Days.Mon;
        }

        public void PrintStatement()
        {
            Console.WriteLine($"x = {x}, y = {y}, myDays = {myDays}");
        }
        // properties 
        public int X { set => x = value; get => x; }
    }

    public class AnotherClass
    {
        public int Number;
    }

    public enum Days { Mon, Tues, Wed }

}
