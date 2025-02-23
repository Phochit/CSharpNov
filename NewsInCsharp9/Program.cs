
/*using System.Collections;


Console.WriteLine("Hello, World!");
ShowOutput();

string s = "";
Person p = new Person { FName = "Mg", LName = "Aung Aung" };
Console.WriteLine(p.FName+" "+p.LName);
p.FName = s==null?"abcd":s;

// ==,!= .. ? Yes : No
if(s==null)
{

}
else
{

}

// EULA
// End user license aggrement

static void ShowOutput()
{
    Console.WriteLine("ABCD");
}

// record - special kind of class

public record Person
{
    public string? FName { get; set;}
    public string? LName { get; init; }
}

// Top-Level Statement

*/

// Vital Sign
// BMI


// weight(lb)
// height(ft,inches)
// formula
// result

// < 18.5 - Under Weight
// < 25 - Normal
// < 30 - Over Weight

//Console.Write("Weight : ");
//double w = double.Parse(Console.ReadLine());
//Console.Write("Height : ");
//double h = double.Parse(Console.ReadLine());

double res = 29;

//if (res < 18.5)
//    Console.WriteLine("Under Weight");
//else if (res >= 18.5 && res < 25)
//    Console.WriteLine("Normal");
//else if (res >= 25 && res < 30)
//    Console.WriteLine("Over Weight");
//else
//    Console.WriteLine("Very Over Weight");

string GetBMIResult(double bmi) =>
    bmi switch
    {
        < 18.5 => "Under Weight",
        < 25 => "Normal",
        < 30 => "Over Weight",
        _ => "Very Over Weight"
    };

Console.WriteLine(GetBMIResult(res));

char c = 'k';

//if (c == 'a' || c == 'e' || c == 'i')
//    Console.WriteLine("Vowel");
//else
//    Console.WriteLine("Not Vowel");

if (c is 'a' or 'e' or 'i' or 'o' or 'u')
    Console.WriteLine($"{c} is vowel");
else
    Console.WriteLine("Not vowel");

//var s = new object();

//if (s is not string)

//if(!(s is int))
