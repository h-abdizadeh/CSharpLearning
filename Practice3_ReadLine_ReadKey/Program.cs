//تمرین 3 _ دریافت ورودی   
//practice 3 _ ReadLine and ReadKey (input)
//                                     
//content
//  ReadLine
//  ReadKey

using static System.Console;


///////////////////////////////////////////////////////////////
//ReadLine
//توقف برنامه در خط اجرا، تایپ ورودی و ادامه برنامه تنها با فشار دادن کلید اینتر
//wait program in command line user type input continue(get input) just by press ENTER
Write("/////////////// ReadLine ///////////////\n");
Write("enter your name and press ENTER : ");
string name = ReadLine();//ورودی در متغیر تعریف شده ذخیره می شود
                         //input store in variable 

WriteLine("your name is {0}\n", name);
//نکته: نوع داده ورودی به صورت پیش فرض متن (رشته) است
//note : ReadLine data type is string as default



///////////////////////////////////////////////////////////////
//ReadKey
//توقف برنامه در خط اجرا
//ادامه برنامه با فشار دادن هر کلیدی
//wait program in command line
//continue(get input) by press any key
Write("/////////////// ReadKey ///////////////\n");
Write("press any key on keyboard : ");
var inputKey = ReadKey();//ورودی در متغیر تعریف شده ذخیره می شود
                         //input store in variable 

WriteLine("\nyou press {0}\n", inputKey.KeyChar);



///////////////////////////////////////////////////////////////
//empty readkey
Write("press any key on finish");
ReadKey();
Write("\n/////////////// finish ///////////////\n");
