using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    // 多态
    class Message
    {
        protected int age;
        protected string name;


        public Message(int age, string name)
        {
            this.age = age;
            this.name = name;
        }


        public void Print()
        {
            Console.WriteLine("年龄：" + age + "姓名：" + name);
        }


        public virtual void Description()
        {
            Console.WriteLine("Message的描述：年龄 = {0}  姓名 = {1}", age, name);
        }
    }

    class Information : Message
    {
        public Information(int age, string name) : base(age, name) { }

        // 隐藏
        new public void Print()
        {
            Console.WriteLine("Informtion中的Print执行啦！");
            Console.WriteLine("子类的年龄：{0}  子类的姓名：{1}", age, name);
        }

        // 虚函数实现多态
        public override void Description()
        {
            Console.WriteLine("Information的描述：年龄 = {0}  子类的姓名 = {1}", age, name);
        }
    }


    class Information2 : Message
    {
        public Information2(int age, string name) : base(age, name) { }

        public override void Description()
        {
            Console.WriteLine("Information2的描述：年龄 = {0}  子类的姓名 = {1}", age, name);
        }
    }


    // 抽象类
    abstract class Shape {
        public abstract void Descirption(double wide, double hight);
    }

    class Rectangle1 : Shape {
        public override void Descirption(double wide, double hight) {
            Console.WriteLine("矩形的面积是：" + wide * hight);
        }
    }

    class Rectangle2 : Shape {
        public override void Descirption(double wide, double hight) {
            Console.WriteLine("其他矩形的面积是：" + wide * hight);
        }
    }


    // 关系运算符重载
    class Cow {
        public Cow() { }
        public Cow(double weight) {
            this.weight = weight;
        }

        public void SetWeight(double weight) {
            this.weight = weight;
        }

        public double GetWeight() {
            return this.weight;
        }

        public void Description() {
            Console.WriteLine("牛的体重是：{0}", this.weight);
        }

        public static Cow operator +(Cow c1, Cow c2) {
            return new Cow(c1.weight + c2.weight);
        }

        public static Cow operator *(Cow c1, Cow c2) {
            Cow cc = new Cow();
            cc.weight = c1.weight * c2.weight;

            return cc;
        }

        public static Pig operator -(Cow c1, Sheep s1) {
            return new Pig(c1.weight - s1.GetWeight());
        }


        public static bool operator >(Cow c1, Sheep s1) {
            return c1.weight > s1.GetWeight();
        }


        public static bool operator <(Cow c1, Sheep s1) {
            return c1.weight < s1.GetWeight();
        }


        public static bool operator== (Cow c1, Sheep s1) {
            return c1.weight == s1.GetWeight();
        }

        public static bool operator!= (Cow c1, Sheep s1) {
            return c1.weight != s1.GetWeight();
        }


        private double weight;
    }


    class Sheep {
        public Sheep() { }
        public Sheep(double weight) {
            this.weight = weight;
        }

        public void SetWeight(double weight) {
            this.weight = weight;
        }

        public double GetWeight() {
            return this.weight;
        }


        public void Description() {
            Console.WriteLine("羊的体重是：{0}", this.weight);
        }

        private double weight;

    }



    class Pig {
        public Pig () { }
        public Pig (double weight) {
            this.weight = weight;
        }

        public double GetWeight() {
            return this.weight;
        }


        public void Description() {
            Console.WriteLine("猪的体重是：{0}", this.weight);
        }

        private double weight;
    }




    // 接口 Interface
    interface IMyInterface {
        int Isum(int A, int B);
    }

    interface IMyInterface2 : IMyInterface {
        int Isum(int A, int B, int C);
    }


    class InTerFace : IMyInterface, IMyInterface2 {
        public int Isum(int A, int B) {
            return A + B;
        }

        public int Isum(int A, int B, int C) {
            return A + B + C;
        }
    }


    // 嵌套命名空间
    namespace Test
    {
        public class A
        {
            public static void Print()
            {
                Console.WriteLine("这是一个内嵌的命名空间！");
            }
        }
    }


    // 异常处理
    class Anomaly {
        public Anomaly(int abc) {
            this.abc = abc;
        }

        public void Compare(int efg) {
            try {
                abc /= efg;
            }
            catch (DivideByZeroException e){
                Console.WriteLine("发生错误啦！！！" + e);
            }
            finally {
                Console.WriteLine("finally执行了！");
            }
            
        }

        private int abc;
    }



    // 文件
    class StreamFile {
        public StreamFile() { }


        // 文件读写操作
        public void Test() {
            FileStream fs = null;       // 文件流
            StreamWriter fw = null;     // 文件流写入器
            StreamReader fr = null;     // 文件流读取器
            string path = "file.txt";

            // 判断文件是否存在，存在返回true，不存在返回false
            if (!File.Exists(path)) {
                // 创建文件，文件所在目录：
                // 工程文件夹下bin文件夹下debug文件夹中
                fs = File.Create(path);
                Console.WriteLine("没有{0}该文件，已创建该文件成功", path);
            } else {
                // 打开文件，以具体的文件打开方式去打开指定文件
                fs = File.Open(path, FileMode.Open);
                Console.WriteLine("文件打开成功！");
            }
            
            // 使用文件流对象去实例化文件流写入器
            fw = new StreamWriter(fs);
            fw.WriteLine("将字符串写入文件，并且换行");
            fw.Write("将字符串写入文件");

            

            fr = new StreamReader(fs);
            string str;
            while (fr.Peek() != -1) {
                str = fr.ReadLine();
                Console.WriteLine("读取到的文件内容是:{0}", str);

            }

        
            // 刷新文件中的文本内容，并清空输入缓冲区的数据流
            fw.Flush();

            // 关闭文件流写入器
            fw.Close();
            fr.Close();

            // 关闭文件流
            fs.Close();
            

        }


        public void Test2 () {
            string path = "ttt.txt";
            StreamWriter sw = new StreamWriter(path);

            sw.WriteLine("小明");
            sw.WriteLine("小红");


            

            sw.Flush();
            sw.Close();


            StreamReader sr = new StreamReader(path);
            while (sr.Peek() != -1)
            {
                string str = sr.ReadLine();
                Console.WriteLine(str);
            }
            
            sw.Close();
        }




        // 创建文件夹
        public void Test3() {
            // 获取当前目录路径
            string dirPath = Directory.GetCurrentDirectory() + "/MyDir";
            Console.WriteLine(dirPath);

            // 判断目录是否存在，存在返回true，不存在返回false
            if (!Directory.Exists(dirPath)) {
                // 创建目录
                Directory.CreateDirectory(dirPath);
                Console.WriteLine("文件夹创建成功！");
            } else {
                Console.WriteLine("文件夹已存在！");
            }

            string filePath = dirPath + "/" + "a.txt";
            Console.WriteLine(filePath);

            // 实例化FileInfo对象    
            FileInfo fi = new FileInfo(filePath);

            if (!fi.Exists) {   // 判断文件是否存在
                fi.Create();    // 创建文件
                Console.WriteLine("文件已创建！");
            } else {
                Console.WriteLine("文件已存在！");
            }



        }


        // 获取当前目录的文件个数
        public void Test4() {
            // 获取工程目录
            string dirPath = Directory.GetCurrentDirectory();

            // 获取工程目录下的所有文件路径
            string[] str = Directory.GetFiles(dirPath);
            Console.WriteLine(dirPath + "  文件个数：" + str.Length);
            
            // 输出所有的工程路径下的文件路径
            foreach (string s in str) {
                Console.WriteLine(s);
            }
        }


        // 文件定位指针
        public void Test5() {
            string filePath = "text.txt";

            using (FileStream fs = File.Open(filePath, FileMode.OpenOrCreate)) {
                string str = "不是吧，阿sir！  yes!";

                // 定义字节数组，并将字符串转换为byte类型赋值给它
                byte[] strByte = Encoding.UTF8.GetBytes(str);

                // 将转换为byte类型的字符串写入文件中
                fs.Write(strByte, 0, strByte.Length);

                // 定义一个字节数组
                byte[] readRead = new byte[strByte.Length];

                // 文件指针定位到起始位置
                fs.Seek(0, SeekOrigin.Begin);

                // 读取文件的一行
                fs.Read(readRead, 0, strByte.Length);

                // 输出字节数组中的字符串
                Console.WriteLine(Encoding.UTF8.GetString(readRead));
            }
        }



        // 读取器与写入器
        public void Test6() {
            string strFIleName = "test.txt";          
            FileStream fileStream = File.Open(strFIleName, FileMode.OpenOrCreate);
            string str = "读入器写入的字符串与读取器读取的字符串！";

            // 写入器
            StreamWriter streamWriter = new StreamWriter(fileStream);

            // 写入操作
            streamWriter.WriteLine(str);

            // 读取器
            StreamReader streamReader = new StreamReader(fileStream);

            // 读取操作
            Console.WriteLine(streamReader.ReadToEnd());

            streamWriter.Close();
            streamReader.Close();
            fileStream.Close();

        }



        // 异步
        public void test7() {
            string str = "test.txt";
            FileInfo info = new FileInfo(str);
            FileStream fs = null;

            // 如果文件不存在
            if (!info.Exists) {
                info.Create();
                Console.WriteLine("文件创建成功！");
            } else {
                Console.WriteLine("文件已存在！");
            }

            fs = new FileStream(str, FileMode.Open, FileAccess.Write, FileShare.None, 4096, true);

            string sss = "BeiJing";

            byte[] vsByte = Encoding.UTF8.GetBytes(sss);

            Console.WriteLine("开始异步！");
            IAsyncResult asyncResult = fs.BeginWrite(vsByte, 0, vsByte.Length, new AsyncCallback(callBackFunc), fs);
        }

        public static void callBackFunc(IAsyncResult asynResult) {
            Console.WriteLine("回调函数！");
            FileStream stream = asynResult.AsyncState as FileStream;

            if (stream != null) {
                stream.EndWrite(asynResult);
                stream.Close();
                Console.WriteLine("异步结束！");
            }
        }
    }




}
