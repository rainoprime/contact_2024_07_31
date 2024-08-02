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




// 数组排序
string[] pallets = { "B12", "A11", "B13", "A14"};

Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine(pallet);
}

Console.WriteLine("------------------------");
// 数组反向排序
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine(pallet);
}


// 清除元素以及扩容数组
Array.Clear(pallets, 0, 2); // 从下标0开始，清除两个元素
Console.WriteLine("");
foreach (var pallet in pallets)
{
    Console.WriteLine(pallet);
}

// 清除元素后，不是空字符串，而是null
// foreach (var pallet in pallets)
// {
//     // Console.WriteLine(pallet.ToUpper());  报错
// }

// 扩容
Console.WriteLine("");
Array.Resize(ref pallets, 6);

pallets[4] = "C22";
pallets[5] = "C66";

foreach (var pallet in pallets)
{
    Console.WriteLine(pallet);
}

// 通过减少容量达到清楚元素的目的
Console.WriteLine("-------");

Array.Resize(ref pallets, 3);

foreach (var pallet in pallets)
{
    Console.WriteLine(pallet);
}

Console.WriteLine("------");
// 将字符串转为数组
string items = "abc123456";
char[] charArray = items.ToCharArray();
foreach (char c1 in charArray)
{
    Console.WriteLine(c1);
}

// 反向排列数组合并为新的字符串
Array.Reverse(charArray);
string newItems = new string(charArray);

Console.WriteLine(newItems);

Console.WriteLine("------");

// 使用join 将所有字符合并为新的逗号分隔值字符串
string joinItem = string.Join(',', charArray);

Console.WriteLine(joinItem);

Console.WriteLine("--------");

// 使用split 拆分字符串数组
string[] strings = joinItem.Split(',');
foreach (string se in strings)
{
    Console.WriteLine(se);
}

 
// 字符串练习 打印ehT kciuq nworb xof spmuj revo eht yzal god
string pangram = "The quick brown fox jumps over the lazy dog";

var pangramSplit = pangram.Split(" ");

for (var i = 0; i < pangramSplit.Length; i++)
{
    var array = pangramSplit[i].ToCharArray();
    Array.Reverse(array);
    pangramSplit[i] = new string(array);
}

var join = string.Join(" ", pangramSplit);
Console.WriteLine(join);


// 字符串练习 长度不是4的标记为Error

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

var orderStreamArray = orderStream.Split(",");

Array.Sort(orderStreamArray);
for (var i = 0; i < orderStreamArray.Length; i++)
{
    if (orderStreamArray[i].Length != 4)
    {
        orderStreamArray[i] = string.Concat(orderStreamArray[i], "- Error");
    }

    Console.WriteLine(orderStreamArray[i]);
}




// ================================================================================
Console.WriteLine("===========================================");

//重点： 字符串的格式化以及货币的处理
string myName = "json";
string yourName = "kjh";
var format = string.Format("我叫{0}, 你叫{1}，我们都是程序员！", myName, yourName);
var formatMyName = string.Format("{0}，{0}，{0}", myName, yourName);
Console.WriteLine(format);
Console.WriteLine(formatMyName);

int numT1 = 10000;
double numT2 = 923234534248.56555d;
Console.WriteLine("以货币的方式展现");
Console.WriteLine($"{numT1:C}");
Console.WriteLine($"{numT2:C}");

// 货币格式化
Console.WriteLine("================================");
Console.WriteLine($"{numT1:N1}");
Console.WriteLine($"{numT2:N4}");

// 设置百分比
Console.WriteLine("================================");
Console.WriteLine($"{numT1:P1}");
Console.WriteLine($"{numT2:P3}");

// 结合使用
var s = string.Format("你有{0:C}这么多钱，我要{1:C} 这么多钱", numT2 - numT1, numT2);
Console.WriteLine(s);
s += $"{numT2:P} 占这个百分比";
Console.WriteLine(s);



// 字符串填充
Console.WriteLine("---------------------------------");
string testString = " pad _ this";
var padRight = testString.PadLeft(20);
Console.WriteLine(padRight);

Console.WriteLine("==========================");

// 填充替换
var right = testString.PadRight(20, '=');
Console.WriteLine(right);

Console.WriteLine("=============================================");

// 练习 - 完成将字符串内插应用于套用信函的挑战
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
string messageT = string.Format("Dear {0}, \n As a customer of our {1} offering we are excited to tell you about a new financial product that would dramatically increase your return. \n Currently, you own {2:N2} shares at a return of {3:P2}.\n Our new product, {4} offers a return of {5:P2} .  Given your current volume, your potential profit would be {6:C2}."
    ,customerName, currentProduct, currentShares, currentReturn, newProduct, newReturn, newProfit);

Console.WriteLine(messageT);
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
var padRight1 = string.Format("{0:P2}", currentReturn).PadRight(9);
var right1 = string.Format("{0:C2}", currentProfit).PadRight(20);

var s1 = $"{newReturn:P2}".PadRight(9);
var padRight2 = $"{newProfit:C2}".PadRight(20);

comparisonMessage += string.Format("{0}{1}{2}\n", currentProduct.PadRight(20),padRight1,right1);
comparisonMessage += string.Format("{0}{1}{2}\n", newProduct.PadRight(20),s1,padRight2);

Console.WriteLine(comparisonMessage);