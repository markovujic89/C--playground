// See https://aka.ms/new-console-template for more information

using Definition;
using Definition.Abstract_Class;
using Definition.Delegate;
using Definition.ExceptionHandling;
using Definition.Structures;
using System;
using System.Text;

Example example = new Example();
RefKeyword refKeyword = new RefKeyword();
var delegatExample = new DelegateExample();

int number = 1;

// good example
// 1. create test instance with Value = 1, test2 = test, that means that test2 is equal with test by value and refence.
// test, test2, test3, test4 all objects has reference on same object
var test = new Test { Value = 1, Id=1, Name="Test test 22" };

var test2 = test;

var test3 = test;

var test4 = test;

test.Value = 2;

test4.Value = 3;

Console.WriteLine($"Test {test.ToString()}");

//var text = "test test";

//var text1 = text.Replace('t','w');

//var text2 = text;

delegatExample.PrintText(delegatExample.ErrorMessage, "text!!");

//Console.WriteLine(text);

//Console.WriteLine(text1);

//Console.WriteLine(text2);

//Console.WriteLine($"Test base: {test.Value}");
//Console.WriteLine($"Test: 2 {test2.Value}");
//Console.WriteLine($"Test: 3 {test3.Value}");
//Console.WriteLine($"Test: 4 {test4.Value}");


var playWithException = new PlayWithExceptions();

// playWithException.TestExceptionThrow();

refKeyword.UpdateValueByReference(ref number);

Console.WriteLine($"The number passed by reference is: {number}");

var bookLibrary = new BookLibrary(100, "name");

bookLibrary.GetMinStorageSize(100);

Console.ReadLine();

int[] array = new int[10];

array[0] = number;
array[1] = number;

Console.WriteLine($"Array average: {array.Average()}");

var price = new Price(10, 40);
var realPrice = price.CalculatePrice(10, 40);

Console.WriteLine($"Price calculation {realPrice}"); 

array.Append(5);
example.AsAndIsOperators();


class Test
{
    public int Id { get; set; }

    public int Value { get; set; }

    public string Name { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var other = (Test)obj;
        return Name == other.Name && Id == other.Id;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {

        return $"Id: {Id}, Value: {Value}, Name: {Name}";
    }
}