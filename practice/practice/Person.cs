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

    class Animal
    {
        public string animal_race;
        public double age;
        public double weight;
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

        public Test(string QQ) // 前面class 的名字是Test 所以這裡的名字也要是Test
        {
            Console.WriteLine("創建成功" + QQ);
        }
    }
}