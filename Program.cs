// See https://aka.ms/new-console-template for more information
// 输出

using System.Threading.Channels;

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
int c = 0;
foreach (var student in students)
{
    c++;
    Console.WriteLine($"{c} = {student}");
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


// 练习 for和if
/*
在迭代语句的代码块内输出从 1 到 100 的值，每行一个数字。
如果当前值可被 3 整除，则在该数字旁打印 Fizz。
如果当前值可被 5 整除，则在该数字旁打印 Buzz。
如果当前值可同时被 3 和 5 整除，则在该数字旁打印 FizzBuzz。
*/
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
    if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
}



// do while 和 while
int aNum = 0;
do
{
    aNum++;
    Console.WriteLine(aNum);
} while( aNum != 7);

while (aNum != 10)
{
    aNum++;
    Console.WriteLine(aNum);
}

// 声明变量
string? userName = null;
string userNameBak = null;  // 不写? 编译器会发出警告
Console.WriteLine(userNameBak);

// 声明二维数组
string[,] twoArray = new string[2,2];
twoArray[0,0] = "1";
twoArray[0,1] = "2";
twoArray[1,0] = "3";
twoArray[1,1] = "4";
foreach (var se in twoArray)
{  
    Console.WriteLine($"{se} ");
}

// for 循环遍历二维数组
for (var i = 0; i < twoArray.GetLength(0); i++)
{
    for (var i1 = 0; i1 < twoArray.GetLength(1); i1++)
    {
        Console.WriteLine($"{twoArray[i, i1]}");
    }
}



// 有符号整形
Console.WriteLine("-------------------");
Console.WriteLine($"sbyte:{sbyte.MinValue} and {sbyte.MaxValue}"); // sbyte 表示有符号性，  byte表示无符号
Console.WriteLine($"short:{short.MinValue} and {short.MaxValue}");
Console.WriteLine($"int:{int.MinValue} and {int.MaxValue}");
Console.WriteLine($"long:{long.MinValue} and {long.MaxValue}");


// 无符号整形
Console.WriteLine("---------------------------");
Console.WriteLine($"byte: {byte.MinValue} and {byte.MaxValue}");
Console.WriteLine($"ushort: {ushort.MinValue} and {ushort.MaxValue}");
Console.WriteLine($"uint: {uint.MinValue} and {uint.MaxValue}");
Console.WriteLine($"ulong:{ulong.MinValue} and {ulong.MaxValue}");



// 浮点型
Console.WriteLine("-----------------------------");
Console.WriteLine($"float: {float.MinValue} and {float.MaxValue}");
Console.WriteLine($"double: {double.MinValue} and {float.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} and {decimal.MaxValue}");


// 引用数据类型
int[] numberInt = new int[3];


// 类型转换
// 编译器进行安全转换(扩大转换)
int numb1 = 10;
decimal numb2 = 20m;
decimal numb3 = numb1 + numb2;
Console.WriteLine(numb3);

// 强制转换(所需转换
decimal numbf4 = 2222.12345667889m;
float numbf5 = (float)numbf4;
Console.WriteLine(numbf5);  // 编译器进行安全转换


// 字符串转数字
string abc = "10";
string bbb = "20";
Console.WriteLine($"{abc.ToString()} ,  {bbb.ToString()}");
Console.WriteLine($"{int.Parse(abc)} , {int.Parse(bbb)}");


// 字符串转数字2
Console.WriteLine($"{Convert.ToInt32(abc)},    {Convert.ToInt32(bbb)}");


// Conver 适合小数转换。 ooo 被舍去小数位变为1，  Convert.ToInt32 会进行四舍五入
int ooo = (int)1.5m;
int ppp = Convert.ToInt32(15m);
Console.WriteLine($"{ooo} , {ppp}");

// 无法将十进制转为int， 需要强转
//int ddbbb = 222m;



// 使用 TryParse进行字符串转数字，防止出现转换异常的问题
string sA = "123";
int  result = 0;
if (int.TryParse(sA, out result)) 
{
    Console.WriteLine($"转换成功，{result}");
}
else
{
    Console.WriteLine("转换失败");
}

string bas = "Bob";
int result1 = 0;
if (int.TryParse(bas, out result1))
{
    Console.WriteLine($"转换成功，{bas}");
}
else
{
    Console.WriteLine("转换失败");
}

if (result1 > 0)
{
    Console.WriteLine("xxxxx");
}



// 练习
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string? message = null;

decimal total1 = 0m;
foreach (var value in values)
{
    decimal total;
    if (!decimal.TryParse(value, out total))
    {
        message += value;
    }
    else
    {
        total1 += total;
    }
}

Console.WriteLine($"message:{message} \n total :{total1}");


// 练习2
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {(int)(value1 / value2)}");
Console.WriteLine($"Divide value1 by value2, display the result as an int: {Convert.ToInt32(value1 / value2)}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {value2 / (decimal) value3}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {value3 / value1}");