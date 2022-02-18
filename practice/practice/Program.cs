/*

// 字串的方法如下

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
System.Console.WriteLine(System.Math.Round(55.5)); // 小數的四捨五入

// 取得輸入

System.Console.Write("請輸入您的名字: ");
string Name = System.Console.ReadLine();
System.Console.Write("請輸入您的年紀: ");
string age = System.Console.ReadLine();
System.Console.WriteLine("你好! " + age + "歲的" + Name);

System.Console.Write("請輸入第一個數字: ");
double first = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("請輸入第二個數字: ");
double second = System.Convert.ToDouble(System.Console.ReadLine());
double ans = first + second;
System.Console.WriteLine("答案是 " + ans);
Console.WriteLine("謝謝");

// Array 陣列

int[] height = { 150, 160, 170, 130, 120 };
Console.WriteLine(height[0]);

//string[] name = { "kevin", "amy" };
Console.WriteLine(name[0]);

//string[] phones = new string[2];
phones[0] = "0123456789";
Console.WriteLine(phones[0]);


*/
// if 判斷句

bool hungry = true;
Console.WriteLine("你餓嗎 Y/N");
string input = Console.ReadLine();
if (hungry && input.ToUpper().Contains('Y'))
{
    Console.WriteLine("去吃飯");
}
else
{
    Console.WriteLine("去休息");
}