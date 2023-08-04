using System;
using System.Text;
using System.Diagnostics;
using System.Diagnostics.Metrics;

// namespace Csharp
{

// var arr_ = new int[] { 98, 87, 75, 66, 55, 33 };

/*
var rnd = new Random();
var arr_ = new int[] { rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100) };

var mergeSort = new MergeSort(arr_);
mergeSort.Split(0, arr_.Length - 1);*/

/*
var decrEncr = new DecrEncr();
decrEncr.EncryptFile("sample.txt");

decrEncr.DecryptFile("sample.txt");*/

var bytes = Encoding.ASCII.GetBytes("Some string here");

// dec 97 to 122 is lcase
// dec 65 to 90 is ucase
// nos 30 to 39
foreach (byte b in bytes)
{
    Console.WriteLine(b);
}

// get the str back
var same = Encoding.ASCII.GetString(bytes);

Console.WriteLine(same);

}