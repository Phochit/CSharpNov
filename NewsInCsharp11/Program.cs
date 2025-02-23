// See https://aka.ms/new-console-template for more information

string s = @"C:\windows\newfolder";

string s2 = """C:\windows\newfolder""";

string json =
    """
     {
      "Name":"abc",
       "Age":18
     }
     """;

Console.WriteLine(json);


int[] num = { 0, 1, 2, 3, 4 };

var res1 = num[..];
//var res2 = num[0,..];

if(num is [0,..])
    Console.WriteLine("start with zero");


if (num is [0, _, _, _, _])
    Console.WriteLine("start with zero and has 5 values");

if (num is [_,_,_,_,var last])
    Console.WriteLine(last);

if (num is [0,..var after])
    foreach(var aft in after)
        Console.Write(aft);

Console.WriteLine();

if (num is [0,..var middle,4])
    foreach(var mid in middle)
        Console.Write(mid);


Console.WriteLine();

var pw = "Password".Select(_ => "*");
foreach(var inp in pw)
    Console.Write(inp);


class Employee(int i, int j)
{

}
