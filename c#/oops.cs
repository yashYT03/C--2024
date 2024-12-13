//using System;

//class A
//{
//   public  int i = 10;
//}
//class B: A
//{
//    int j = 20;
//   public void m1()
//    {
//        Console.WriteLine(i + j);
//    }
//}
//class c
//{
//    public static void Main(String[] args)
//    {
//        B e = new B();
//        e.m1();
//        Console.ReadLine();
//    }
//}




//using System;
//class A
//{
//   public int i = 10;
//   public void q2()
//    {
//        Console.WriteLine("good world hello");
//    }

//}
//class B : A
//{
//    int j = 20;

//    public void q1()
//    {
//        Console.WriteLine(i + j);
//    }
//}
//class c
//{
//    public static void Main(String[] args)
//    {
//        B e = new B();
//        e.q2();
//        Console.ReadLine();
//    }
//}


//multilevel inheritance

//using System;
//class A
//{

//    public void q1()
//    {
//        Console.WriteLine("good world hello");
//    }

//}
//class B : A
//{


//    public void q2()
//    {
//        Console.WriteLine("hello how are you? ");
//    }
//}
//class C : B 
//{
//  public void q3()
//    {
//        Console.WriteLine ("we are fine here right now");
//    }
//}

//class Player{
//    public static void Main(String[] args)
//    {
//        C e = new C();
//        e.q1();
//        e.q2();
//        e.q3();
//        Console.ReadLine();
//    }
//}

//Method overloading same name but differet parameters

//using System;
//class A
//{
//  public void q1(int i)
//    {
//        Console.WriteLine(i);

//    }
//        public void q1(float i)
//        {
//         Console.WriteLine(i);
//        }
//    }
//    class C { 
//    public static void Main(String[] args)
//        {
//        A e = new A();
//        e.q1(4);
//        e.q1(3.2f);
//        }
//    }


//Method Overriding same name function and also parametrs


//using System;
//class A
//{
//    public void q1()
//    {
//        Console.WriteLine("good morning");
//    }
//}
//class B: A
//{
//    public void q1()
//    {
//        Console.WriteLine("derived class");
//    }
//}
//class c
//{
//    static  void Main(String[] args)
//    {
//        B e = new B();
//        e.q1();
//    }
//}

//abstract

//using System;
//public abstract class A
//{
//    public abstract void q1();
//public void q2()
//    {
//        Console.WriteLine("q2");
//    }
//}
//class B : A
//{
//    public override void q1()
//    {
//        Console.WriteLine("q1");
//    }

//}
//class C
//{
//    public static void Main(string[] args)
//    {
//        B e = new B();
//        e.q1();
//        e.q2();
//    }
//}

//interface 

//using System;
//public interface A
//{
//    public void q1();
//}
//class B: A
//{
//    public void q1()
//    {
//        Console.WriteLine("q1 ");
//    }
//}
//class C
//{
//    public static void Main(String[] args)
//    {
//        B e = new B();
//        e.q1();
//    }
//}


//Exception handling

//try  catch
//using System;
//class Player
//{
//    public static void Main(String[] args)
//    {
//    Console.WriteLine("Enter a number" );
//        int j = Convert.ToInt32(Console.ReadLine());
//        int i = 10;
//        int result = 0;
//        try
//        {
//             result = i / j;
//        }catch(Exception e)
//        {
//            Console.WriteLine("can't  divide by zero");
//        }     
//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}

//using System;
//public class notvalidage: Exception
//{
//    public notvalidage(string s): base(s)
//    {

//    }
//}
//class A
//{
//   static void checkage(int age)
//    {
//        if(age < 18)
//        {
//            throw new notvalidage("age is not valid");
//        }
//    }
//    public static void Main(String[]args)
//    {
//        try
//        {
//            checkage(20);
//        }
//        catch (notvalidage e)
//        {
//            Console.WriteLine(e);
//        }

//        Console.ReadLine();

//    }


// Collection List, stack, queue


//list in csharp

//using System;
//using System.Collections.Generic;
//class A {
//    public static void Main(String[] args)
//    {
//     var student = new List<string>();
//        student.Add("anonymous");
//        student.Add("anony");
//        student.Add("anony");
//        student.Add("mous");
//        student.Add("ymous");

//        foreach(var q in student)
//        {
//            Console.WriteLine(q);
//        }

//    }

//}

//stack in csharp

//using System;
//using System.Collections.Generic;
//class A
//{
//    public static void Main(String[] args)
//    {
//        Stack<int> i = new Stack<int>();
//        i.Push(1);
//        i.Push(2);
//        i.Push(3);    
//        foreach(var q in i)
//        {
//            Console.WriteLine(q);
//        }
//        i.Pop();
//        Console.WriteLine("after pop of one elements");
//        foreach(var q in i)
//        {
//            Console.WriteLine(q);
//        }
//    }
//}

//Queue in csharp

//using System;
//using System.Collections.Generic;
//class A
//{
//    public static void Main(String[] args)
//    {
//        Queue<int> i = new Queue<int>();
//        i.Enqueue(1);
//        i.Enqueue(2);
//        i.Enqueue(3);
//        foreach (var q in i)
//        {
//            Console.WriteLine(q);
//        }
//        i.Dequeue();
//{
//    Console.WriteLine("After removing of the elements");
//    foreach(var q in i)
//    {
//        Console.WriteLine(q);
//    }
//}

//    }
//}

//Collection hash set , sort set


//using System;
//class A
//{
//    public static void Main(String[] args)
//    {
//        var student = new HashSet<string>();
//        student.Add("anonymous");
//        student.Add("anony");
//        student.Add("mous");
//        foreach(var i in student)
//        {
//            Console.WriteLine(i);
//        }
//        Console.WriteLine("Enter Student name to delete");
//        string s = Console.ReadLine();
//        student.Remove(s);
//        Console.WriteLine("after deletion");
//        foreach(var e in student)
//        {
//            Console.WriteLine(e);
//        }
//    }
//}



//using System;
//class A
//{
//    public static void Main(string[] args)
//    {
//        var collage = new SortedSet<int>();
//        collage.Add(5);
//        collage.Add(9);
//        collage.Add(1);
//        foreach(var e in collage)
//        {
//            Console.WriteLine(e);

//        }
//        Console.WriteLine("after deletation");
//        int q = Convert.ToInt32(Console.ReadLine());
//        collage.Remove(q);
//        foreach(var i in collage)
//        {
//            Console.WriteLine(i);
//        }

//    }
//}



//link list csharp


//using System;
//class A
//{
//    public static void Main(string[] args)
//    {
//        var q = new LinkedList<string>();
//        q.AddLast("amous");
//        q.AddLast("anonymous");
//        q.AddFirst("hacker");
//        LinkedListNode<string> node = q.Find("amous");
//        q.AddAfter(node, "who");
//        q.AddBefore(node, "evil");

//        foreach(var i in q)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}



//Collection dictionary, sorted dictionary , sorted list


//using System;
//class A
//{
//    public static void Main(String[] args)
//    {
//        Dictionary<int, string> student = new Dictionary<int, string>();
//        student.Add(1, "anonymous");
//        student.Add(2, "mous");
//        student.Add(3, "anony");
//        //student.Add(3, "anony");
//        foreach (KeyValuePair<int,string> i in student)
//        {
//            Console.WriteLine(i.Key + " "  + i.Value);
//        }
//        Console.WriteLine("Enter the  number");
//        int q = Convert.ToInt32(Console.ReadLine());
//        if (student.ContainsKey(q))
//        {
//            Console.WriteLine(student[q]);
//        }else
//        {
//            Console.WriteLine("404 not found");
//        }
//        student.Remove(q);
//        Console.WriteLine("after removing");
//        foreach (KeyValuePair<int,string> i in student)
//        {
//            Console.WriteLine(i.Key + " " + i.Value);
//        }

//        Console.ReadLine();
//    }
//}//

//SortedDictionary

//using System;
//class A
//{
//    public static void Main(String[] args)
//    {
//        SortedDictionary<int, string> student = new SortedDictionary<int, string>();
//        student.Add(3, "anonymous");
//        student.Add(1, "mous");
//        student.Add(2, "anony");
//        //student.Add(3, "anony");
//        foreach (KeyValuePair<int, string> i in student)
//        {
//            Console.WriteLine(i.Key + " " + i.Value);
//        }
//        Console.WriteLine("Enter the  number");
//        int q = Convert.ToInt32(Console.ReadLine());
//        if (student.ContainsKey(q))
//        {
//            Console.WriteLine(student[q]);
//        }
//        else
//        {
//            Console.WriteLine("404 not found");
//        }
//        student.Remove(q);
//        Console.WriteLine("after removing");
//        foreach (KeyValuePair<int, string> i in student)
//        {
//            Console.WriteLine(i.Key + " " + i.Value);
//        }

//        Console.ReadLine();
//    }
//}

//sortedlist


//using System;
//class A
//{
//    public static void Main(String[] args)
//    {
//        SortedList<int, string> student = new SortedList<int, string>();
//        student.Add(1, "anonymous");
//        student.Add(2, "mous");
//        student.Add(3, "anony");
//        //student.Add(3, "anony");
//        foreach (KeyValuePair<int, string> i in student)
//        {
//            Console.WriteLine(i.Key + " " + i.Value);
//        }
//        Console.WriteLine("Enter the  number");
//        int q = Convert.ToInt32(Console.ReadLine());
//        if (student.ContainsKey(q))
//        {
//            Console.WriteLine(student[q]);
//        }
//        else
//        {
//            Console.WriteLine("404 not found");
//        }
//        student.Remove(q);
//        Console.WriteLine("after removing");
//        foreach (KeyValuePair<int, string> i in student)
//        {
//            Console.WriteLine(i.Key + " " + i.Value);
//        }

//        Console.ReadLine();
//    }
