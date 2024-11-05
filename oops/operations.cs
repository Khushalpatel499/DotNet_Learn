// this class use for prform operation only

using System;
using System.Text;
using System.Threading.Tasks;

namespace oops {

    internal class operation{
        int p=2;
        static int q=4;
        public void display(){
            Console.WriteLine("This is non-static method");
        }
        public void Add(int a,int b){
             
             int c=a+b;
             Console.WriteLine(c);

        }
        public string disName(string name){
           return name;
        }

        public int disSub(double a,double b){

          int c=  (int)(a-b);
          return c;
        }
        public static void mymethod(){
                //   Console.WriteLine($"Value of p is {p}");//here p cannot be access becuase static method can only access static variable.
                  Console.WriteLine($"Value of q is {q}");
        }
        public void mymethod2(){
            Console.WriteLine($"Value of p is {p}");
            Console.WriteLine($"Value of q is {q}");
        }
    }
}