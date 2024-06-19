# DotNet_Learn

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

6. for generate applicatio we need input and output
