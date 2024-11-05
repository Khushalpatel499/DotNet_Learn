class Test{

    public void dis1(){
        Console.WriteLine("This is Non-Static Method");
    }
    public static void dis2(){
        Console.WriteLine("This is static method");
    }
     static void Main(strings[] args){
    //   new Test().dis1();

    Test obj1 =new Test();
    obj1.dis1();
    Test.dis2();
    dis2();

     }
}
