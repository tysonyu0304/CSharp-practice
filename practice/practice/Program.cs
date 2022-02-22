/*

// 字串的方法如下

string name = "nMSl";
System.Console.WriteLine(name.Contains('n')); // 看該字元或字串在哪個位置
System.Console.WriteLine(name[name.IndexOf('l')]); // []是指定位置 InDexOf()是找出位置
System.Console.WriteLine(name.ToUpper() + ' ' + name.ToLower()); // 大寫和小寫
System.Console.WriteLine(name.Substring(1,1)); // 分割字串 (位置,往後幾位)
System.Console.WriteLine(name.Length); // 顯示字串的長度


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


// 加法計算機

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

string[] name = { "kevin", "amy" };
Console.WriteLine(name[0]);

string[] phones = new string[2];
phones[0] = "0123456789";
Console.WriteLine(phones[0]);


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

bool BOOL2 = false;
Console.WriteLine("你餓嗎 Y/N");
string input2 = Console.ReadLine();
if (!BOOL2 || !input2.ToUpper().Contains('Y'))
{
    Console.WriteLine("去吃飯");
}
else
{
    Console.WriteLine("去休息");
}


// 進階計算機

Console.Write("請輸入第一個數字: ");
double First = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入要做的運算( +, -, *, / ): ");
string Mark = Console.ReadLine();
Console.Write("請輸入第二個數字: ");
double Second = Convert.ToDouble(Console.ReadLine());

if (Mark.Contains('+'))
{
    Console.Write("答案是 ");
    Console.WriteLine(First + Second);
}
else if (Mark.Contains('-'))
{
    Console.Write("答案是 ");
    Console.WriteLine(First - Second);
}
else if (Mark.Contains('*'))
{
    Console.Write("答案是 ");
    Console.WriteLine(First * Second);
}
else if (Mark.Contains('/'))
{
    Console.Write("答案是 ");
    Console.WriteLine(First / Second);
}
else
{
    Console.WriteLine("不合法的運算符號");
}

// while 迴圈

int num = 1;
while (num <= 100)
{
    Console.Write(Convert.ToString(num) + ' ');
    num ++;
}



do
{
    Console.WriteLine(Convert.ToString(num) + ' ');
    num++;
}
while (num < 200);


// 猜數字遊戲

Console.WriteLine("歡迎來到數字猜猜樂");
int first = 0, second = 100;
const int ans=87, times = 5;

do
{
    Console.WriteLine("目前數字介於" + Convert.ToString(first) + "到" + Convert.ToString(second));
    Console.WriteLine("您目前還剩" + Convert.ToString(times) + "次可猜");
    Console.Write("請輸入要猜的數字: ");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input > ans && input < second)
    {
        second = input;
        Console.WriteLine("您猜的數字比答案大喔");
    }
    else if (input < ans && input > first)
    {
        first = input;
        Console.WriteLine("您猜的數字比答案小喔");
    }
    else if (input == ans)
    {
        Console.WriteLine("恭喜結束");
        break;
    }
    else
    {
        Console.WriteLine("您猜的答案可能不在範圍內 或 不是數字");
    }
    times --;
}
while (times > 0);
if (times == 0)
{
    Console.WriteLine("\n好可惜失敗了 下次加油吧");
}

// for 迴圈

for (int i =5; i<10; i++)
{
    Console.WriteLine(i);
}

int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
string name2 = "Kevin";
for (int i = 0; i < name2.Length; i++)
{
    Console.WriteLine(name2[i]);
}


// 二維陣列

// row 橫排
// column 直排

// [,] 是二維陣列 [,,] 是三維陣列 以此類推...
//               三維陣列需要包三層的大括號 四維陣列需要包四層的大括號 ...

int[,] Nums = { 
    { 1, 2, 3 }, 
    { 4, 5, 6 }, 
    { 7, 8, 9 }
};
for (int i = 0; i < Nums.GetLength(0); i++)
{
    for (int j = 0; j < Nums.GetLength(1); j++)
    {
        Console.Write(Nums[i,j]);
        Console.Write(' ');
    }
}
Console.WriteLine(' ');
int[,] Nums2 = {
    { 1,2 },
    { 3,4 },
    { 5,6 },
};
for (int i = 0; i < Nums2.GetLength(0); i++)
{
    for (int j = 0; j < Nums2.GetLength(1); j++)
    {
        System.Console.Write(Nums2[i, j]);
        Console.Write(' ');
    }
}


// class & object 類別 & 物件
//  請配合 Person.cs 一同服用

Person person1 = new Person();
person1.height = 165;
person1.name = "name";
person1.age = 17;

Console.WriteLine("這個人的年紀是 " + Convert.ToString(person1.age));


Person person2 = new Person();
person2.height = 175;
person2.name = "name2";
person2.age = 17;

Console.WriteLine("這個人的身高是 " + Convert.ToString(person2.height));


// namespace & using & method
//  請配合 Person.cs 一同服用
//  注意: 這裡的程式碼跟上面 "class & object" 的程式碼不能同時出現(因為class會衝突)

using Character;
using Character.QQ;
using calculate;

Persons person1 = new Persons();
person1.weight = 80;
person1.name = "name";
person1.age = 17;
person1.IsOldThan18();

Console.WriteLine("這個人的年紀是 " + Convert.ToString(person1.age));


Persons person2 = new Persons();
person2.weight = 87;
person2.name = "Kevin";
person2.age = 19;
person2.SayHi();
if (person2.IsOldThan18())
{
    Console.WriteLine("true");
}

Console.WriteLine("這個人的體重是 " + Convert.ToString(person2.weight));

QQ q1 = new QQ();
q1.name = "haha";
q1.SayQQ();

Console.WriteLine(q1.name);

number add = new number();
Console.WriteLine(add.add(person2.age, 2));


// Main 方法
// 這是程式的進入點 電腦會從這裡找到程式開始的第一行 如果你沒有用這個的話 C#會自動在後台處理

namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}


// Constructor 建構方法
// 請配合 Person.cs 一同服用
// 注意 建構函式的名字必須與類型的名字一致

using Constructor;

Test Name = new Test("Andy",18);
Console.WriteLine(Name.name);
Console.WriteLine(Name.age);


// getter & setter
// 請配合 Person.cs 一同服用

using Character;

video test1 = new video("好廢", "我", "廢片");
video test2 = new video("真的廢", "你", "哈哈");

Console.WriteLine(test1.Type);
Console.WriteLine(test2.Type);


// static attribute 靜態屬性
// 請配合 Person.cs 一同服用

using Character;

video test1 = new video("好廢", "我", "廢片");
video test2 = new video("真的廢", "你", "哈哈");

Console.WriteLine(test1.Type);
Console.WriteLine(test2.Type);
Console.WriteLine(video.video_count);
Console.WriteLine(test2.GetVideoCount());


// static method & static class 靜態類別
// 此方法所創建之類別是不需要宣告的
// 請配合 Person.cs 一同服用

using practice;

Console.WriteLine(Math.Sqrt(36));
Tool.SayHi();


// inheritance 繼承
// 請配合 Person.cs 一同服用

using Character;

Student student = new Student("Spica", 80, 160.9, "HCHS");
student.SayHi();
*/