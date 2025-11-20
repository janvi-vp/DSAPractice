// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;
using DSAPractice.Leetcode;

// var pattern = "010";
// var source = "amazing";
// TestClass t1 = new();

// var res = t1.Test1(source, pattern);
// Console.WriteLine(res);

// int[] nums = [4, 0, 1, -2, 3];
// TestClass2 t2 = new();

// var res2 = t2.Test(nums);
// Console.WriteLine(string.Join(", ", res2));

// int[][] grid = [[0,1,0,1,0],[2,1,0,1,2],[2,2,2,0,1],[2,2,2,2,2],[2,1,2,2,2]];
// Problem1 p1 = new();

// var res3 = p1.MinimumOperationsToWriteY(grid);
// Console.WriteLine(res3);

// long[] initialBalances = { 10, 100, 20, 50, 30 };
// Problem2 bank = new Problem2(initialBalances);

// Console.WriteLine(bank.Withdraw(3, 10));    
// Console.WriteLine(bank.Transfer(5, 1, 20)); 
// Console.WriteLine(bank.Deposit(5, 20));     
// Console.WriteLine(bank.Transfer(3, 4, 15)); 
// Console.WriteLine(bank.Withdraw(10, 50));

// int m = 3;
// int n = 3;
// int[][] coordinates = [[0, 0], [1, 1], [0, 2]];
// Problem3 p3 = new();

// var res4 = p3.CountBlackBlocks(m, n, coordinates);
// Console.WriteLine(string.Join(",",res4));

// int[] nums = [1,2,3,4,5,6];
// int[] pattern = [1,1];
// Problem4 p4 = new();

// int res5 = p4.CountMatchingSubarrays(nums, pattern);
// Console.WriteLine(res5);

// string path = "/home//foo/";
// Problem5 p5 = new();

// string res6 = p5.SimplifyPath(path);
// Console.WriteLine(res6);

// int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
// Problem6 p6 = new();

// p6.Rotate(matrix);

// int[][] intervals = [[1, 3], [2, 6], [8, 10], [15, 18]];
// Problem7 p7 = new();

// var res8 = p7.Merge(intervals);
// foreach (var interval in res8)
// {
//     Console.WriteLine($"[{interval[0]}, {interval[1]}]");
// }

// char[][] boxGrid = [['#', '.', '#']];
// Problem8 p8 = new();

// var res9 = p8.RotateTheBox(boxGrid);
// foreach (var row in res9)
// {
//     Console.WriteLine("[" + string.Join(",", row.Select(c => "'" + c + "'")) + "]");
// }

LRUCache lRUCache = new LRUCache(2);
lRUCache.Put(1, 1); 
lRUCache.Put(2, 2);
Console.WriteLine(lRUCache.Get(1));
lRUCache.Put(3, 3);
Console.WriteLine(lRUCache.Get(2));
lRUCache.Put(4, 4);
Console.WriteLine(lRUCache.Get(1));
Console.WriteLine(lRUCache.Get(3));
Console.WriteLine(lRUCache.Get(4));