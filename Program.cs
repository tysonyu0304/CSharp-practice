﻿// 字串的方法如下

string name = "nMSl";
System.Console.WriteLine(name.Contains('n')); // 看該字元或字串在哪個位置
System.Console.WriteLine(name[name.IndexOf('l')]); // []是指定位置 InDexOf()是找出位置
System.Console.WriteLine(name.ToUpper() + ' ' + name.ToLower()); // 大寫和小寫
System.Console.WriteLine(name.Substring(1,1)); // 分割字串 (位置,往後幾位)

// 數字的方法如下

System.Console.WriteLine(System.Math.Abs(-565)); // 取絕對值
System.Console.WriteLine(System.Math.Pow(3,2)); // 次方(底數,次數)
System.Console.WriteLine(System.Math.Sqrt(8)); // 開根號
System.Console.WriteLine(System.Math.Max(2,78)); 
System.Console.WriteLine(System.Math.Min(2,78)); // 兩數比大小