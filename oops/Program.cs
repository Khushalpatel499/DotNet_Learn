
using System;
using oops;
class Test{

    // public void dis1(){
    //     Console.WriteLine("This is Non-Static Method");
    // }
    // public static void dis2(){
    //     Console.WriteLine("This is static method");
    // }
     static void Main(string[] args){
    //   new Test().dis1();

    // Test obj1 =new Test();
   // obj1.dis1();// non static method calling
   // Test.dis2();//static method calling
   // dis2(); //static method calling

        //   new operation().display();
          operation obj =new operation();// obj is a referece of operation
          obj.display();
          obj.Add(6,9);
          string s=obj.disName("khushal");
          //to display
          Console.WriteLine($"Name is {s}");
        int x= obj.disSub(9.5,4.2);
          Console.Write($"Sub is {x}");
          obj.mymethod2();//non static
        //   mymethod();//it give error because the classes are in different location 
          //if it is in the same location then we can access by method name
          operation.mymethod();

     }
}
