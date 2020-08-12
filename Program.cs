#define CHAE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp;

namespace ConsoleApp1
{
    class Program : IMyInterface2 {
        class Rectangle {   // 矩形
            private double wide;    // 宽
            private double height;  // 高

            public void Assignment() {  // 赋值
                this.wide = 4.5;
                this.height = 3.5;
            }

            public double GetArea() {
                return this.wide * this.height;
            }

            public void Print() {
                Console.WriteLine("宽：{0}", wide);
                Console.WriteLine("高：" + this.height);
                Console.WriteLine("面积：" + this.GetArea());
                Console.WriteLine("ToString：" + this.wide.ToString());
            }
        }


        public int TestFuntion(int a, int b) {
            return a + b;
        }



        // 随机数
        public static void RanDom() {
            Random random = new Random();   // 设置随机函数

            char[] ary = new char[5];

            // 赋随机值
            for (int i = 0; i < 5; i++) {
                ary[i] = (char)random.Next(65, 90);     // 产生随机值并赋值给数组
                Console.WriteLine("ary[{0}] = {1}", i, ary[i]); // 将随机值打印出来
            }

            // 排序数组
            Array.Sort(ary);

            bool ret = true;

            while (true) {
                Console.Write("请输入一个字符：");
                char c = char.Parse(Console.ReadLine());    // 输入字符
                // 小写字母转大小字母
                if (c >= 97 && c <= 122) {
                    c -= (char)32;
                }

                // 循环判断
                for (int i = 0; i < 5; i++) {
                    if (ary[i] == c) {
                        Console.WriteLine("恭喜您猜对啦！");
                        ret = false;    // 结束条件
                        break;
                    }
                }

                // ret == false  说明猜对了，break结束
                if (!ret) { 
                    break; 
                } 

                Console.WriteLine("很抱歉您猜错了");
            }

        }

        static void Main(string[] args) {
            //Console.WriteLine("Hellow World\n");

            //Rectangle r = new Rectangle();
            //r.Assignment();
            //r.Print();

            //int a = 10;
            //float b = 20.2f;
            //char c = 'c';
            //string d = "d";
            //bool e = true;

            //Console.WriteLine("a = {0}; b = {1}; c = {2}; d = {3}; e = {4}\n", a, b, c, d, e);

            //Console.Write("请输入一个整数值：");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("n = {0}\n", n);


            //Class1 cc = new Class1();
            //Console.WriteLine(cc.GetSum());



            //Console.WriteLine("计算阶乘：");
            //Test1 t1 = new Test1();
            //int result = t1.Jc(Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine("result:{0}", result);


            //Test2 t2 = new Test2();
            //t2.test();


            //Program p = new Program();

            //Console.WriteLine("a + b 等于：" + p.TestFuntion(1, 2));
            //Console.WriteLine("a + b 等于：" + p.TestFuntion(1, 2));
            //Console.WriteLine("a + b 等于：" + p.TestFuntion(1, 2));



            //// 阶乘二
            //Test3 t3 = new Test3();
            //Console.WriteLine("六的阶乘是：{0}", t3.Jie(6));



            //// 引用两数交换
            //Test4 t4 = new Test4();
            //int one = 100;
            //int two = 200;

            //Console.WriteLine("两数交换前：one = {0}  two = {1} ", one, two);
            //t4.tt(ref one, ref two);
            //Console.WriteLine("两数交换后：one = {0}  two = {1} ", one, two);


            //int? a1 = null;
            //int? a2 = new int?();
            //int? a3 = 12;
            //Console.WriteLine("a1 = {0}  a2 = {1}  a3 = {2}", a1, a2, a3);



            //// 数组
            //Test5 t5 = new Test5();
            //t5.arr();
            //t5.arr2();

            //// 交错数组输出
            //t5.InterveinArray();


            //// 交错数组作为参数传入
            //int[][] array = new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 2, 4, 6, 8 } };
            //double s = t5.ParameterArray(array);
            //Console.WriteLine("array数组的平均值是：{0}", s);


            //// 数组逆序与排序
            //t5.text();
            //Console.WriteLine("\n");



            //// 字符串
            //Test6 t6 = new Test6();
            //t6.Contrast();      // 字符串比较
            //t6.StrIncludeStr(); // 字符串包含字符串
            //t6.GainSonStr();    // 获取子字符串
            //t6.LinkStr();       // 链接两个字符串
            //t6.StrCopy();       // 字符串的拷贝


            //// 结构体
            //MyBook myBook = new MyBook();

            //myBook.bookId = 1;
            //myBook.bookName = "C#从入门到放弃";
            //myBook.bookPress = "清华大学出版社";

            //Console.WriteLine("id = {0}\n书名 = {1}\n出版社 = {2}", myBook.bookId, myBook.bookName, myBook.bookPress);


            //MyBookTwo myBookTwo = new MyBookTwo();

            //myBookTwo.GiveValue("C/C++从入门到精通", "特朗普特颁", 2);
            //myBookTwo.Print();



            //// 枚举类型
            //Console.Write("枚举类型:");
            //Console.Write((int)C_Enum.ZERO + ", ");
            //Console.Write((int)C_Enum.ONE + ", ");
            //Console.Write((int)C_Enum.TWO + ", ");
            //Console.Write((int)C_Enum.THREE + ", ");
            //Console.Write((int)C_Enum.FOUR + ", ");
            //Console.Write((int)C_Enum.FIVE);

            //Console.WriteLine();

            //Console.Write("枚举类型:");
            //Console.Write((int)CEnum.ONE + ", ");
            //Console.Write((int)CEnum.TWO + ", ");
            //Console.Write((int)CEnum.THREE + ", ");
            //Console.Write((int)CEnum.FOUR + ", ");
            //Console.Write((int)CEnum.FIVE);

            //Console.WriteLine();


            //ClassOne classOne = new ClassOne(12.5f, 22.5f, 32.5f);
            //classOne.Description();

            //ClassOne classTwo = new ClassOne();
            //classTwo.SetHeight(11.1f);
            //classTwo.SetLength(22.2f);
            //classTwo.SetWide(33.3f);
            //classTwo.Description();



            //// 静态Static
            //Static s1 = new Static(10);
            //Static s2 = new Static(12);

            //// 静态成员函数必须使用“类”来调用
            //Static.AgePlush();
            //Static.AgePlush();

            //Console.WriteLine("s1.age = {0}", s1.GetAge());


            //// 猜字母游戏
            //RanDom();



            // get 与 set
            ClassA A = new ClassA(12);
            A.Name = "你的名字";

            Console.WriteLine("A.Name = {0}", A.Name);

            ClassB B = new ClassB(13, 5);
            B.Name = "天气之子";

            Console.WriteLine("B.Name = {0}", B.Name);

            B[0] = "hello";
            B[1] = "world";
            B[2] = "你好";
            B[3] = "世界";

            for (int i = 0; i < B.GetSize(); i++) {
                Console.WriteLine("B[{0}] = {1}", i, B[i]);
            }

            B.GetAge();



            // 虚函数实现多态
            Message M = new Message(12, "小明");
            M.Description();
            M.Print();

            M = new Information(13, "小黄");
            M.Description();
            M.Print();

            M = new Information2(14, "小红");
            M.Description();
            M.Print();


            // 隐藏注意:*****************************************************************************************
            // 父类对象被赋值子类对象，那么调用隐藏函数是会调用父类的隐藏函数，只有子类对象才会调用自己的隐藏函数
            Message message = new Information(111, "666");
            message.Print();
            Information information = new Information(666, "666");
            information.Print();



            // 抽象类
            Shape shape = new Rectangle1();
            shape.Descirption(11.5, 22.5);

            shape = new Rectangle2();
            shape.Descirption(4.5, 2.5);



            Cow c = new Cow(100);
            Cow c1 = new Cow(200);
            Sheep s = new Sheep(300);
            Cow cc;

            cc = c + c1;
            cc.Description();

            cc = c * c1;
            cc.Description();

            Pig p = cc - s;
            p.Description();


            if (c == s) {
                Console.WriteLine("牛和羊体重相等！");
            } else {
                Console.WriteLine("牛和羊体重不想等！");
            }

            if (c != s) {
                Console.WriteLine("牛和羊体重不相等");
            }


            Program program = new Program();
            Console.WriteLine("10 + 20 = {0}", program.Isum(10, 20));
            Console.WriteLine("10 + 20 + 30 = {0}", program.Isum(10, 20, 30));

            InTerFace inTerFace = new InTerFace();
            Console.WriteLine("类实现接口：" + inTerFace.Isum(111, 222));
            ConsoleApp.Test.A.Print();




            Test7 t7 = new Test7();
            t7.TestPrint();


            Anomaly anomaly = new Anomaly(0);
            anomaly.Compare(0);


            StreamFile streamFile = new StreamFile();
            streamFile.Test();
            ////streamFile.Test2();
            //streamFile.Test3();
            //streamFile.Test4();
            //streamFile.Test5();
            //streamFile.Test6();
            //streamFile.test7();
           // for (int i = 0; i < 1000; i++) {
               // Console.WriteLine(i);
           // }



#if CHAR
            Console.WriteLine("CHAR");
#elif CHAE
            Console.WriteLine("CHAE");
#else
            Console.WirteLine("啥也不是！");
#endif
            Console.ReadKey();



        }

        public int Isum(int A, int B) {
            return A + B;
        }

        public int Isum(int A, int B, int C) {
            return A + B + C;
        }


    }

}
