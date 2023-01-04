//تمرین 6 _ دستورات شرطی   
//practice 6 _ if else if
//                                     
//content
//  if else if
//  ToLower() method, +ToUpper()
//  Beep(,) method


///////////////////////////////////////////////////////////////////
//if else if
//
//وقتی بیش از دو حالت برای تصمیم گیری وجود دارد
//مثال: اگر در فصل بهار نباشیم نمی توان نتیجه گرفت در فصل تابستان هستیم
//حالت های زمستان و پاییز هم وجود دارد و باید بررسی شود
//
//when more than two condition for decition
//if not in spring can't be conclude in summer
//autumn and winter conditions should also be checked
//
// if (شرط اول)
// {
//  اگر پاسخ شرط مثبت بود
//  کد برنامه
// }
// else if (شرط دوم)
// {
//  اگر پاسخ شرط مثبت بود
//  کد برنامه
// }
// else if (شرط سوم)
// {
//  اگر پاسخ شرط مثبت بود
//  کد برنامه
// }
//  .......شرط های نامحدود.......
// else
// {
//  اگر پاسخ شرط منفی بود
//  کد برنامه
// }
/////////////////////////////////////////////
//
// if (condition 1)
// {
//  if condition is true
//  your code
// }
// else if (condition2)
// {
//  if condition is true
//  your code
// }
// else if (condition3)
// {
//  if condition is true
//  your code
// }
//  .......unlimited conditions.......
// else
// {
//  if condition is false
//  your code
// }

using Microsoft.VisualBasic;
using static System.Console;

START:

//چراغ راهنمایی_سه رنگ
//traffic light_tree color
Write("/////////////// traffic light (red, green, yellow) ///////////////\n");

Write("enter input color : ");
string lightColor = ReadLine().ToLower();//ToLower()
                                         //تمام حروف ورودی را به حرف کوچک تبدیل میکند
                                         //red , Red برابر نیستند
                                         //convert all input letters to lowercase 
                                         //red , Red not equal
                                         //check ToUpper()?

if (lightColor == "red")
{
    WriteLine("STOP X");
}
else if (lightColor == "green")
{
    WriteLine("GO ->");
}
else if (lightColor == "yellow")
{
    WriteLine("SLOW !");
}
else
{
    WriteLine("Alarm To Driver");
    Beep(850, 1500);//Beep(frequency,duration) just work on windows!
}


///////////////////////////////////////////////////////////////
//تعداد ارقام عدد ورودی
//number of digits
Write("\n/////////////// number of digits ///////////////\n");
Write("enter number : ");
int number = int.Parse(ReadLine());

if (number < 10)
{
    WriteLine("1 digit");
}
else if (number < 100)
{
    WriteLine("2 digits");
}
else if (number < 1000)
{
    WriteLine("3 digits");
}
else
{
    WriteLine("4 digits or more");
}

//اگر عدد ورودی منفی باشد چه اتفاقی خواهد افتاد؟
//what happens if the input number is negative
//تمرین 7 را ببینید
//see practice 7


///////////////////////////////////////////////////////////////
//نام فصل بر اساس حرف اول
//name of session based on first letter
Write("\n/////////////// name of session based on first letter ///////////////\n");

Write("enter letter : ");
char letter = ReadKey().KeyChar;

if (letter=='s')
{
    WriteLine("\nspring , summer");
}
else if(letter=='a')
{
    WriteLine("\nautumn");
}
else if (letter=='w')
{
    WriteLine("\nwinter");
}
else
{
    WriteLine("\ninvalid letter");
}

//اگر ورودی حرف بزرگ بود چه اتفاقی خواهد افتاد؟
//what happens if input is uppercase (like 'A')
//تمرین 7 را ببینید
//see practice 7

///////////////////////////////////////////////////////////////
//Note:
//if else , if else if can be writen without else
//
// if(condision)
// { ... }
//
//
// if(condition 1)
// { ... }
// else if(condition 2)
// { ... }
// else if(condition 3)
// { ... }




Write("\npress any key to again...");
ReadKey();
Clear();

goto START;//about goto in Program1_Simple_Calculations