namespace Character
{
    namespace QQ
    {
        class QQ
        {
            public string name;

            public void SayQQ()
            {
                Console.WriteLine("QQ");
            }
        }
    }
    class Persons
    {
        public string name;
        public int age;
        public double weight;

        public void SayHi()
        {
            Console.WriteLine("Hi");
            Console.WriteLine("My name is " + name);
        }

        public bool IsOldThan18()
        {
            if (age > 18)
            {
                Console.WriteLine("Adult");
                return true;
            }
            else
            {
                Console.WriteLine("Not Adult");
                return false;
            }
        }
    }
    class Student : Persons
    {
        public string school;

        public Student(string name, int age, double weight, string school)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.school = school;
            Console.WriteLine(name+" "+school);
        }
    }

    class Animal
    {
        public string animal_race;
        public double age;
        public double weight;
    }

    class video
    {
        public string title;
        public string author;
        public static int video_count = 0;
        private string type; // 這個type 只能在這個class裡被取用 所以外面是不能修改的
        public string Type // 而這個Type 可以在外面被修改 所以我們利用這個代理type 來做處理 
        {
            get { return type; }
            set
            {
                if (value == "教育" || value == "娛樂" || value == "廢片" || value == "音樂")
                {
                    type = value;
                }
                else
                {
                    type = "其他";
                }
            }
        }

        // 限制影片種類 EX:教育 娛樂 廢片 音樂
        public video(string title, string author, string Type)
        {
            this.title = title;
            this.author = author;
            this.Type = Type;
            video_count++;
        }

        public int GetVideoCount()
        {
            return video_count;
        }
    }
    
}
namespace House
{
    class Apartment
    {
        public int age;
        public int height;
        public int rooms;
    }
}
namespace calculate
{
    class number
    {
        public int add(int num1,int num2)
        {
            return num1+num2;
        }
    }
}
namespace Constructor
{
    class Test
    {
        public string name;
        public int age;

        public Test(string Name, int age) // 前面class 的名字是Test 所以這裡的名字也要是Test
        {
            name = Name;
            this.age = age;
            Console.WriteLine("創建成功");
        }
    }
}