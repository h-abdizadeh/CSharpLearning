//برنامه 1 _ محاسبات ساده   
//program 1 _ simple calculations 
//                                     
//دریافت دو عدد از کاربر و محاسبه جمع، تفریق، ضرب و تقسیم
//get two number and calculate sum, sub, multypy, division


using static System.Console;

START:

WriteLine("-----------< simple calculations >-----------\n");

Write("enter first number : ");
double num1 = double.Parse(ReadLine());//چرا دابل؟
                                       //why double?
Write("enter second number : ");
double num2 = Convert.ToDouble(ReadLine());

WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);//چه خطایی امکان دارد؟
                                                      //what wrong[exception] is possible?

Write("\npress any key to again...");
ReadKey();

Clear();


goto START;//با هربار پایان برنامه به ابتدای برنامه پرش خواهد کرد
           //jump to START key in first line
           //goto [key]; jump to line by [key]:


//چه خطاهایی در زمان اجرای این برنامه ممکن است
//what wrongs[exceptions] is possible at this program runtime