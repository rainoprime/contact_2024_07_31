// See https://aka.ms/new-console-template for more information
// 输出
Console.WriteLine("Hello World!");

//变量 字符串拼接
var name = "Jason";
Console.WriteLine("Hello " + name + "!");

//字符串内嵌
Console.WriteLine($"Hello {name}!");

// 字符串内嵌 调用方法
Console.WriteLine($"Hello {name.ToUpper()}");

// 字符串数组 循环遍历
var names = new[] {"Jason", "Jerry", "Pevm"};
foreach (var nameOne in names)
{
    Console.WriteLine($"Hello {nameOne.ToUpper()}");
}

// 调用.net类库生成随机数
Random random = new Random();
var next = random.Next(10, 20);
Console.WriteLine(next);

// 实现Math类中的一个方法，返回两个数字中的较大值
var max = Math.Max(10, 20 );
Console.WriteLine(max);

// if控制语句
var number1 = random.Next(10, 40);
var number2 = random.Next(10, 50);
var number3 = random.Next(10, 60);

if (number1 > number2)
{
    Console.WriteLine("1 > 2");
}
else if (number2 > number3)
{
    Console.WriteLine(" 2 > 3 ");
}
else if (number3 > number1)
{
    Console.WriteLine(" 3 > 1");
}
else
{
    Console.WriteLine($"1 {number1}, 2 {number2}, 3 {number3}");
}


// 初始化数组
string[] students = new string[3];
students[0] = "张三";
students[1] = "李四";
students[2] = "王五";

string[] numberArrays = new string[3];
numberArrays[0] = "1";
numberArrays[1] = "2";
numberArrays[2] = "20";

int[] intNumber = { 1, 2, 3, 4 };


Console.WriteLine($"students length = {students.Length}, numberArrays length = {numberArrays.Length}, intnumbers = {intNumber.Length}");



// foreach遍历数组
int i = 0;
foreach (var student in students)
{
    i++;
    Console.WriteLine($"{i} = {student}");
}


// 布尔
bool flag = true;
bool falseFlag = false;

Console.WriteLine(flag == true); // True
if (name.Contains("J"))
{
    Console.WriteLine(falseFlag == true); // False
}
    
// 条件运算符
int a = 10;
int b = a > 5 ? 20 : 1;
Console.WriteLine(b); // 20


// 硬币翻转
int coin = random.Next(0, 2);
Console.WriteLine(coin == 0 ? "heads" : "tails");

// if结构优化  如果不写大括号，只能有一条语句
int flagNum = 9;
if (flagNum == 9)
    Console.WriteLine(flagNum);
else
    Console.WriteLine("2");

// switch  如果case 存在代码，但没有break编译器会报错
/*
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

 */
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

Console.WriteLine(type);