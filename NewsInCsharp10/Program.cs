// See https://aka.ms/new-console-template for more information

// Constructor for Struct


struct Person
{
    public string name;
    public int age;

    public Person() // error
    {

    }
}

record class Employee(int x,int y); // classy record
record struct Employee2(int x,int y); // structy record


