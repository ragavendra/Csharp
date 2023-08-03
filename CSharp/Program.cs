using System;
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

var decrEncr = new DecrEncr();
decrEncr.EncryptFile("sample.txt");

decrEncr.DecryptFile("sample.txt");

}