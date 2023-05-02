
// lab 1
//Console.WriteLine("---Student 1---"); 
//Console.Write("Name: ");
//string Name1 = Console.ReadLine(); 
//Console.Write("Input Weight (kg): ");
//double W1 = double.Parse(Console.ReadLine()); 
//Console.Write("Input Height (cm) : ");
//double H1 = double.Parse(Console.ReadLine());

//Console.WriteLine("---Student 2---"); 
//Console.Write("Name: ");
//string Name2 = Console.ReadLine(); 
//Console.Write("Input Weight (kg): ");
//Console.Write("Input Height (cm): ");

//double W2 = double.Parse(Console.ReadLine()); 
//double H2 = double.Parse(Console.ReadLine());
//double BMI1 = Math.Round(W1 / Math.Pow(H1 / 100, 2), 2); 
//double BMI2 = Math.Round(W2 / Math.Pow(H2 / 100, 2), 2);

//Console.WriteLine($"\n {Name1.ToUpper()} BMI = {BMI1}"); 
//Console.WriteLine($" {Name2.ToUpper()} BMI = {BMI2}");
//Console.WriteLine($"\nMax BMI = {Math.Max(BMI1, BMI2)}");

// lab 2
/*Console.Write("position: ");
string position = Console.ReadLine();
Console.Write("salary: ");
float salary = int.Parse(Console.ReadLine());
if (position == "Assistant Developer")
{
    float A = salary + ((salary * 5) / 100);
    Console.WriteLine($"Your Salary will be increased to =  {A}");
}
else if (position == " IT Suport")
{
    float I = salary + ((salary * 7) / 100);
    Console.WriteLine($"Your Salary will be increased to =  {I}");
}
else if (position == "Senior Developer")
{
    float S = salary + ((salary * 10) / 100);
    Console.WriteLine($"Your Salary will be increased to =  {S}");
}
else if (position == "Administrator")
{
    float Ad = salary + ((salary * 8) / 100);
    Console.WriteLine($"Your Salary will be increased to =  {Ad}");
}
else
{
    float e = salary + ((salary * 3) / 100);
    Console.WriteLine($"Your Salary will be increased to =  {e}");
}
*/


//lab 3



//lab4

using System.Security.Cryptography;

public class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

}
public class Student : Person
{
    public static void main()
    {

    }
    
   
}

