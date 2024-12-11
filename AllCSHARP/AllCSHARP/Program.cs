//using System;

//class AllCSPARP
//{
//    static void Main(String[] args)
//    {
//Console.WriteLine("Enter your name");
//string name = Console.ReadLine();
////Console.WriteLine(name);

//Console.WriteLine("How many chocalate do you want eat ?");
//int a = 3;
// a = int.Parse(Console.ReadLine());

////Console.WriteLine(a);
//Console.WriteLine("Total is " + name + " " + a);
//Console.ReadLine();

//Operator 
//Arithmetic Operators
//int a = 3;
//int c = 1;
//Console.WriteLine(a + c);
//Console.WriteLine(a - c);
//Console.WriteLine(a * c);
//Console.WriteLine(a / c);
//Console.ReadLine();

//Assignment Operators
//int a = 3;
//int c = 1;

//a -= 1;
//a += 1;
//a *= 2;
//a /= 1;
//Console.WriteLine(a);
//Console.ReadLine();

//Logical Operators

//Console.WriteLine(true && false);
//Console.WriteLine(true || false);
//Console.WriteLine(!false);
//Console.ReadLine();

//Comparison Operators 
//Console.WriteLine(20 > 40);
//Console.WriteLine(20 < 40);
//Console.WriteLine(20 >= 40);
//Console.WriteLine(20 <= 40);
//Console.WriteLine(20 == 40);
//Console.WriteLine(20 != 40);


//double a = Math.Sqrt(25);
//int a = Math.Min(2, 4);
//int a = Math.Max(2, 4);
//Console.WriteLine(a);

//Console.ReadLine();

//string hello = "we are anonymous";
//Console.WriteLine(hello.Length);
//Console.WriteLine(hello.ToLower());
//Console.WriteLine(hello.ToUpper());
//Console.WriteLine(hello + " " +  "how are you ?");

//string interpolation
//string a = Console.ReadLine();
//string c = Console.ReadLine();
//Console.WriteLine($"how are you {a} and  {c}");

//Console.WriteLine("Enter a number");
//int a = Convert.ToInt32(Console.ReadLine());
//if (a%2 == 0)
//{
//    Console.WriteLine("It is even number");
//}
//else
//{
//    Console.WriteLine("It is odd number");
//}
//Console.ReadLine();

//int i = 10;
//int j = 20;
//int count;
//Console.WriteLine( count = i + j);
//Console.WriteLine("It is even number", count );




//string a = Console.ReadLine();
//string b = Console.ReadLine();
//Console.WriteLine($"Your name is {a}. Your age is {b}");
//string q = "hello world";
//Console.WriteLine(q.IndexOf("o"));
//Console.WriteLine(q.Substring(5));

//Console.ReadLine();




//Console.WriteLine("Enter a first number");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter second Number");
//int c = Convert.ToInt32(Console.ReadLine());
//int Total = 0;
//Console.WriteLine("Enter You Want to operation +, -, *, /");
//char op = Convert.ToChar(Console.ReadLine());
//switch (op)
//{
//    case '+': Total = a + c;
//        break;
//    case '-': Total = a - c;
//        break;
//    case '*': Total = a * c;
//        break;
//    case '/': Total = a / c;
//        break;
//    default: Console.WriteLine("Wrong Input");
//        break;
//}
//Console.WriteLine(Total);
//Console.ReadLine();

//for loop in c#

//for(int i = 1; i<10; i++)
//{
//    Console.WriteLine(i);
//}
//Console.ReadLine();

//nested for loop
//Console.WriteLine("i  j");
//for (int i = 1; i<=5; i++)
//{
//    for(int j = 1; j<=3; j++)
//    {
//        Console.WriteLine(i  +  " " + j);
//    }
//}
//Console.ReadLine();

//while loop
//all odd number
//int i = 1;
//while (i <= 20)
//{
//    Console.WriteLine(i);
//    i = i + 2;
//}

//int i = 100;
//do
//{
//    Console.WriteLine(i);
//    i++;
//}
//while (i < 20);
//Console.ReadLine();

//break and continue

//for(int i = 1; i<=5; i++)
//{
//    for (int j =1; j<=5; j++)
//    {
//      if (i == 3)   
//        break;
//    Console.WriteLine(i + " " + j);

//    } 
//}

//for (int i = 1; i <= 10; i++)
//{
//    if (i == 4)
//        continue;
//    Console.WriteLine(i);

//}
//Console.ReadLine();

//use goto
//l1:

//    Console.WriteLine("Enter a number ");
//    int i = Convert.ToInt32(Console.ReadLine());
//    if (i <= 10)
//    { 
//        Console.WriteLine("number is less than 10");
//        goto l1;
//    }else
//    {
//    Console.WriteLine("number is greater than 10");
//    }
//Console.ReadLine();
//Console.WriteLine("Enter your age");
//int age = Convert.ToInt32(Console.ReadLine());
//if(age > 18)
//{
//    Console.WriteLine("You can give vote");
//}
//else if(age <10 && age >3)
//{
//    Console.WriteLine("You complete you education");

//}else 
//{
//    Console.WriteLine("you can't give vote");
//}
//Console.ReadLine();

//Console.WriteLine("Enter your number");
//int age = Convert.ToInt32(Console.ReadLine());
//switch (age) {
//    case 18:
//        Console.WriteLine("you are 18");
//        break;
//    case 20:
//        Console.WriteLine("You are 20");
//        break;
//    case 1:
//        Console.WriteLine("You are 1");
//        break;
//    default:
//        Console.WriteLine("you enter wrong number");
//        break;
//}

//for(int i = 1; i<=5; i++)
//{
//    if (i == 1)
//    {
//      continue;
//    } 
//    Console.WriteLine(i);
//break;

//}
//Console.ReadLine();
//    }
//} 


//Methods in c#
//using System;
//class Csharp
//{
//static void greet(string name)
//{
//    Console.WriteLine("Good Morning" + " " + name);
//}
//static float average(int a, int b, int c)
//{
//    float sum = a + b + c;
//    return sum / 3;
//}
//static void Main(string[]args)
////{
////    greet("we");
////}
//{
//    Console.WriteLine(average(3,3,3));


//    }
//} 

using System;
using AllCSHARP;

class Program
{
    static void Main(string[]args)
    {
        Player q = new Player();
        Console.WriteLine(q.name);
        Console.WriteLine(q.getHealth());
        q.setHealth(36);
        Console.WriteLine(q.getHealth());
    }
}
