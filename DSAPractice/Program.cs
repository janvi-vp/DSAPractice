// See https://aka.ms/new-console-template for more information
using System.Globalization;
using DSAPractice.Leetcode;

var pattern = "010";
var source = "amazing";
TestClass t1 = new();

var res = t1.Test1(source, pattern);
Console.WriteLine(res);

int[] nums = [4, 0, 1, -2, 3];
TestClass2 t2 = new();

var res2 = t2.Test(nums);
Console.WriteLine(string.Join(", ", res2));

int[][] grid = [[0,1,0,1,0],[2,1,0,1,2],[2,2,2,0,1],[2,2,2,2,2],[2,1,2,2,2]];
Problem1 p1 = new();

var res3 = p1.MinimumOperationsToWriteY(grid);
Console.WriteLine(res3);

long[] initialBalances = { 10, 100, 20, 50, 30 };
Problem2 bank = new Problem2(initialBalances);

Console.WriteLine(bank.Withdraw(3, 10));    
Console.WriteLine(bank.Transfer(5, 1, 20)); 
Console.WriteLine(bank.Deposit(5, 20));     
Console.WriteLine(bank.Transfer(3, 4, 15)); 
Console.WriteLine(bank.Withdraw(10, 50));