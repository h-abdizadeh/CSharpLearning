//تمرین 5 _ دستورات شرطی   
//practice 5 _ if else
//                                     
//content
//  logical operators
//  if else
//  if else if


///////////////////////////////////////////////////////////////
//logical operators
// >            >=
// <            <=
// == (equal)   != (notEqual)
// !  (not)
//هرمقایسه شامل این عملگرها تنها دومقدار درست و نادرست دارد
//any compare contains this operatos just  make a true or false result
// 5 > 3 -> true
// 5 < 3 -> false
// 5 <= 3 -> true
// 5 != 3 -> true
// 5 == 3 -> false
// !(5 == 3) -> true 

///////////////////////////////////////////////////////////////
//if else
//
// if (شرط)
// {
//  اگر پاسخ شرط مثبت بود
//  کد برنامه
// }
// else
// {
//  اگر پاسخ شرط منفی بود
//  کد برنامه
// }
//////////////////////////
//
// if (condition)
// {
//  if condition is true
//  your code
// }
// else
// {
//  if condition is false
//  your code
// }

using static System.Console;

START:


//رمز عبور درست یا اشتباه
//input password right or wrong
Write("/////////////// right password or wrong ///////////////\n");

string password = "abc1234";

Write("enter password : ");
string userPass = ReadLine();

if (userPass == password)
{
    WriteLine("oK!");
}
else
{
    WriteLine("wrong password");
}

///////////////////////////////////////////////////////////////
//عدد ورودی منفی یا مثبت
//input number negative or positive
Write("\n/////////////// negative or positve number ///////////////\n");

Write("enter a number : ");
double inputNum = double.Parse(ReadLine());

if (inputNum > 0)
{
    WriteLine("{0} is positive", inputNum);
}
else
{
    WriteLine("{0} is negative", inputNum);
}


///////////////////////////////////////////////////////////////
//تشخیص زوج یا فرد بودن عدد وروردی
//input number even or odd
Write("\n/////////////// even or odd ///////////////\n");

Write("enter a number : ");
int number = int.Parse(ReadLine());

if (number % 2 == 0)
{
    WriteLine("even");
}
else
{
    WriteLine("odd");
}

Write("\npress any key to again...");
ReadKey();
Clear();

goto START;//about goto in Program1_Simple_Calculations
