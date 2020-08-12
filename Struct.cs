using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct MyBook {
        public string bookName;     // 书名
        public string bookPress;    // 出版社
        public int bookId;          // 编号


        public MyBook (string bookName, string bookPress, int bookId) {
            this.bookName = bookName;
            this.bookPress = bookPress;
            this.bookId = bookId;
        }
    };


    struct MyBookTwo {
        private string bookName;
        private string bookPress;
        private int bookId;

        public void GiveValue(string BN, string BP, int BI) {
            this.bookName = BN;
            this.bookPress = BP;
            this.bookId = BI;
        }

        public void Print() {
            Console.WriteLine("编号：{0}", this.bookId);
            Console.WriteLine("书名：{0}", this.bookName);
            Console.WriteLine("出版社：{0}", this.bookPress);
        }
    };




    enum C_Enum {
        ZERO,
        ONE,
        TWO,
        THREE,
        FOUR,
        FIVE
    };


    enum CEnum
    {
        ONE = 1,
        TWO,
        THREE = 2,
        FOUR = 1,
        FIVE
    };







    class ClassOne {
        private float length;
        private float wide;
        private float height;

        public ClassOne() {
            Console.WriteLine("创建无参对象成功！");
        }

        public ClassOne(float length, float wide, float height) {
            this.length = length;
            this.wide = wide;
            this.height = height;
            Console.WriteLine("创建有参对象成功！");
        }

        ~ClassOne() {
            Console.WriteLine("~析构函数调用啦！");        
        }

        public void Description() {
            Console.Write("length = {0} --- wide = {1} --- height = {2}\n", this.length, this.wide, this.height);
        }


        public void SetLength(float length) {
            this.length = length;
        }

        public void SetWide(float wide) {
            this.wide = wide;
        }

        public void SetHeight(float height) {
            this.height = height;
        }
    }



    // 静态变量 static
    class Static {
        static int age;

        public Static(int age1) {
            age = age1;
        }

        public static void AgePlush() {
            age++;
        }

        public int GetAge() {
            return age;
        }
    }



    class ClassA {
        private int age;
        private string name;

        public ClassA (int age) {
            this.age = age;
        }

        public int GetAge() {
            return age;
        }

        public string Name {
            get {
                return name;
            }

            set {
                this.name = value;
            }
        }
    }



    class ClassB : ClassA {
        private int size;
        private string name;
        private string[] strArr;

        // 构造器 base
        public ClassB (int age, int size) : base (age) {
            this.size = size;
            strArr = new string[size];

            for (int i = 0; i < size; i++) {
                strArr[i] = "空";
            }
        }

        public int GetSize() {
            return this.size;
        }

        public new string Name {
            get {
                return name;
            }

            set {
                this.name = value;
            }
        }

        // 索引器 [ ]
        public string this[int index] {
            get {
                if (index >=0 && index < size) {
                    return strArr[index];
                } else {
                    return null;
                }
            }

            set {
                if (index >=0 && index < size) {
                    strArr[index] = value;
                }
            }
        }
    }

}
