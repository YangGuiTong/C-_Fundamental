using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        private int sum = 0;
        private int a1 = 10;
        private int a2 = 20;

        public int GetSum()
        {
            sum = a1 + a2;
            return sum;
        }
    }

    class Test1 {

        // 阶乘递归算法
        public int Jc(int num) {
            if (num <= 0) {
                Console.WriteLine("请输入大于0的数！");
                return 0;
            }
            return num > 1 ? num * Jc(num - 1) : 1;
        }
    }



    class Test2 {

        public void test() {
            Console.WriteLine("请输入一个整型数：");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("得出数据是：{0}", i);
        }
    }

    class Test3 {

        public int Jie(int num) {
            int result;

            if (num == 1) {
                return 1;
            } else {
                result = Jie(num - 1) * num;
                return result;
            }
        }
    }


    // 引用
    class Test4 {

        // 引用方式：两数交换
        public void tt (ref int a, ref int b) {
            int ret = a;
            a = b;
            b = ret;
        }
    }


    // 数组
    class Test5 {

        // 一维数组
        public void arr () {
            int[] array = new int[10];

            for (int i=0; i<10; i++) {
                array[i] = i + 100;
            }

            Console.WriteLine("输出数组：");

            foreach (int i in array) {
                Console.WriteLine(i);
            }
        }


        // 二维数组
        public  void arr2 () {
            int[,] array2 = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            for (int i = 0; i < array2.GetLength(0); i++) {              
                for (int j = 0; j < array2.GetLength(1); j++) {
                    Console.WriteLine("array2[{0},{1}] = {2}", i, j, array2[i, j]);
                }
            }
        }


        // 交错数组
        public void InterveinArray () {
            int[][] IA = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, 7, 8 },
                                       new int[] { 9, 10, 11, 12 , 111, 222, 333}, new int[] { 666, 999 } };

            for (int i = 0; i < IA.Length; i++) {

                for (int j = 0; j < IA[i].Length; j++) {
                    Console.WriteLine("IA[{0}][{1}] = {2}\n", i, j, IA[i][j]);
                }
            }
        }


        // 函数作为参数
        public double ParameterArray (int[][] array) {
            int sum = 0;
            int score = 0;
            double var = 0.0;

            for (int i = 0; i < array.Length; i++) {

                foreach (int s in array[i]) {
                    sum += s;
                    score++;
                }
            }

            var = sum / score;

            return var;
            
        }



        // 逆转和排序
        public void text () {
            int[] array = new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8 };

            // 正常输出
            Console.WriteLine("正常输出数组：");
            foreach (int a in array) {
                Console.Write(a + " ");
            }
            Console.Write("\n");


            // 逆转数组
            Console.WriteLine("逆转数组后输出:");
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i] + " ");
            }
            Console.Write("\n");


            // 排序数组
            Console.WriteLine("排序数组后输出：");
            Array.Sort(array);
            foreach (int a in array) {
                Console.Write(a + " ");
            }
            Console.Write("\n");
        }
    }




    // 字符串
    class Test6 {
        
        // 字符串比较
        public void Contrast () {
            string str1 = "This is a string";
            string str2 = "This is a not string";

            if (String.Compare(str1, str2) == 0) {
                Console.WriteLine("两个字符串相等！");
            } else {
                Console.WriteLine("两个字符串不相等！");
            }
        }





        // 字符串包含字符串
        public void StrIncludeStr () {
            string str1 = "Today is vary beautyful";
            string str2 = "beautyful";

            if (str1.Contains(str2)) {
                Console.WriteLine("有包含子字符串！");
            } else {
                Console.WriteLine("没有包含子字符串！");
            }
        }



        // 获取子字符串
        public void GainSonStr () {
            string str1 = "Tonight, I goning to Sleep";

            string str2 = str1.Substring(20);

            Console.WriteLine("获取到的子字符串是：{0}:", str2);
        }



        // 连接字符串
        public void LinkStr () {
            string str1 = "My name is ";
            string str2 = "Gui Tong Yang!";

            string str = String.Concat(str1, str2);

            Console.WriteLine("链接字符串后：" + str);
        }



        // 字符串的拷贝
        public void StrCopy () {
            string str1 = "Are you ok?";

            string str2 = string.Copy(str1);

            Console.WriteLine("str1 = {0} str2 = {1}", str1, str2);
        }
    }



    class Test7 {
        private const int SCORE = 10;

        public void TestPrint() {
            for (int i = 0; i < SCORE; i++) {
                Console.WriteLine("第{0}个数", i + 1);
            }
        }
    }
}
