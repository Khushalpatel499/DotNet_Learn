# DotNet_Learn(It is provided by Microsoft)

# Introduction

1. In dot net backend is c sarp, in java backend is core java ,advanced java ,spring boot and for other languages like php.
   2.why .net?
   Ans: for any website front end is important , but in other languages like java we have to do it manually but in .net we have asp.net where we can create content on base of drag and drop, means develper save their time to make website. ASP.net help to reduce time to make any website comapre to advanced java.
2. Asp.net have a tool box, Asp.net help in both front and backend , but mostly used in frontend.
3. .net provide same security level as java
4. Java say for data store we need mysql or oracle for data integration, in java we have to download first jar file of java and then use it, but .net said i have a framework, it used sql server and we can directly installed it inside. so we don't need to download other libraries they are already present in framework.

5. .net have all think inside but we have to know how to integrate that thinks.
6. for backend we used the language C#(c sarp)

7. C# is procedural oriented and object oriented language.
8. their are small or business type website which depends on the data set mean how much data required
   with C# and ASP.net we can make only small level application, we can prepare business level but it take more time which is not good.

9. IN c# and ASP.net we have to make table and database manually but in business level we have some thing different to fetch database, so in business level instead of concept of normal db we use ORM concept which is Object Relational Maper with the of this we can give our database integration part with backend.(it said whiel we write 7-8 step to store data in table, it give 1-2 steps ).
10. Business level applcation use MVC Structure Which is model(db),view (UI),COntroller(LOGIc). and ASP.net core.
11. For DB we use the concept of ORM in business level which used Entity framwork and small level use Sql server for db integration which used ADO.net language to wirte function. ADO.net said to do manually while ORM said we have annotations also called dependecy injections help to make table easily.

12. For reusable term we use web API, we can use api fuction code to reuse anywhere by written one time. test tool like postman,swagger

13. We need two thinks Visual Studio and Sql Server.

# C#

1. IT is a backend langugae.It provide functionality.
2. It is POP(top to bottom approach) and OOP (it have class and object which help to call different fuction that we made or calling same function for multiple objects), POP help to make function that cover conditonal ,looping ,Array .
3. code->compile->Run . there are two type: compiler: IT will compile entire code(for large lines of code)
   Interpreter: It will compile 1 line at a time.

4. C# is a compiler language not an interprter language. CLR(common language runtime is used to compile our code, it provided by the .net framework), for run their are different term used like JRM and JVM in java, CLR run and compile both work. To save file used .cs when compile it generate class file(.class) and we run that file.

5.Structure of C#:(It is object oriented language)
class is collection of object(class first letter is capital)

class classname {
//main function
public static void Main(string []args){
//body;
}
}

//public : access modifier: any one can access it.
// static: it make code constant means if duplicate generate than cannot be generated(no code duplication)
//void: it is a return type
//Main: memory it contain parameter like here it contain string data type means here code store in format of string
//args: it is arguments means when we passed code in main memory we don't know how much line or how much charater we pass, []= array bracket that is not contain any number means we can define n number of data.

6. for generate applicatio we need input and output.
   c#-> for console application
   input: Console.ReadLine()
   Read: scan line
   Line: generate new line

   But it give error because it command it require some library
   so for call any library in C# used using
   using= to import library

here we used library using System

Output: Console.WriteLine()
file name is same as class name 7. for command prompt:
save: className.cs
compile: csc className.cs
RUN: cs className

8. IMP: To put it simply, an IDE is a one-stop shop for the development of an application whereas a text-editor as the name suggests, is used for writing and editing code. Visual Studio is an IDE whereas VSCode is a text editor.

To run .net in vs code editor for low end devices
first download .net and vs code
then C# and C# extension

to create .net project type: dotnet new shortname
and for run type: donet run
for continue change (hot reload)use: donet watch run

9. Console.ReadKey();// to hold output screen

# Data types and Variables:

1. variable to store data
2. variable Naming : alphabet,alphanumeric,
3. variable name cannot start with numbers
4. space not allowed instead we can use underscore.
5. special character not allowed.
6. how to store data in variable,
   a=10; (= is assign)
7. data types are of two type : Primitive(it is costant means not other data type are formed)(int,float,char) and non Primitive(double,string)(other datatype can easily form).

8. 1 byte =8 bits =2^n =2^8 =256 numbers
   for char 1 byte = 1 letter
   int ------> numeric 4bytes
   float-----> decimal 4bytes
   char-------> only two letter 2bytes
   double-----> decimal 8bytes
   byte-------> store array 1 byte
   bool------> true or false 1byte
   string---->set of character no fixed size.

9. syntax: datatype variableName;// declaration
   or dataype variableName =value;// initialization

10. by default in c# and java , the decimal value consider as double.( float a=15.6(error) , float a=15.6f (no error))
11. when we read data from Console.ReadLine() it pass as an string format.so we have to typecast it.(we use datatype.Parse).
12. String interpolation: $"Emp Id is : {id}"

# Operators

1. Operators is which operation we going to perform and on which are operands.
2. Types of Operators: Unary(it contain at least one operands )and Binary operator(contain atleast two operands).
3. Uniary operators:(++) increment(pre and post) and (--)decrement(pre and post).
4. Binary: Arithmetic(+,-,\*,/,%), Assignmet(+=,-=,\*=,%=), Relational(<,>,<=,=>,==,!=) return true or false. Loigcal(&&,||, !),Bitwise(&,},^,~).
5. Typecast: implicit (it convert lower datatype into higher datatype)
   ex: int x=10;
   long y=x; (correct)
   and explicit(reverse of implicit);
   ex: double x =12.4;
   int y=x; (wrong)
   int y=int(x); correct

# Decision making

1. if statement
2. if-else statement
3. nested if-else statement
4. Else if ladder
5. switch case statement

to check condition which is help of debugger can add break points

# loops

1.finite
a. Entry controlled loop
x.for loop
y.while loop
b. exit controlled loop
x.do- while loop
2.infinite

# control statements

1. break: to exit the loop
2. continue: skip the values according to condition

# Array

1. Collection of similar type of data
2. static : size is fix for dynamic used collection in C#
3. Homogenous: same type definition
4. types: 1D: to define indexing,multi D
5. Length - define array length
6. two types of syntax:
   a. datatype []variablename = new datatype[size];
   b. datatype []variablename ={elements};

# foreach loop

1. use when store more than one element, use to collect array and object
   2.syntex: foreach(datatype variable in array){}

# Multi D array

1. syntex: datatype [,]varname =new datatype[rowSize,columnsize];
   Ex: int [,]arr= new int [3,3];
   arr[1,1]=10

2. Datatype [,]varname ={};

3. By foreach
   foreach(int y in arr){

   Console.Write(y+" ");

   }

# OPPS

1. Opps- bottom to top
2. pop - top to bottom
3. class - blue print, it is collection of object, class name can be anythink
4. object - reference of class ,to communicate with method(member function )

# Methods:

1. It is basically a function or member function.
2. function vs memeber function: function can be anythink normal function or memeber of any class while memeber function is member of the given class.
3. method syntax: access_modifier return_type methodname(parameter ){
   //body;
   }
4. Access modifiers: 1. Private: data availabe only for the specific class, data cannot be share from one class to another 2. public:access the data anywhere. 3.protected: same as private but the difference is that class can share data with only relationship classes.(like inheritance) 4. internal: within the assembly means within pakage,like in one package i have 4-5 classes then i can share 4-5 class data in same package.

5. return types: 1. void: it doesn't return any 2. datatype:int,float,string they require return statement.
6. Methodname: userdefined method
7. parameters: extra data or variables , optionals

8. we have two class A,B . A have method disc1(), B have method disc2(), and other method is disc3()
   here disc3 is function while disc1 and disc2 is member function.
9. to communicate with method with object use obj1.disc1()
10. Advantages: reusable method
11. types of methods: 1. static method:this method can access only the static memeber, it define with static keyword , no need to create object to call static memeber, we can access method by using class name or directly method. 2. nonstatic method(dynamic method): in this method we can access static and non static data, no use of static keyword, neccesary to create object to call object.

12. syntax: static method:
    access_modifier staitc returntype methodname(para){
    //body;
    }
    non-static:
    access_modifier returntype methodname(par){
    //body;  
     }
