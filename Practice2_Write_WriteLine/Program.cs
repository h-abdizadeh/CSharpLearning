//تمرین 2 _ نمایش خروجی برنامه   
//practice 2 _ Write and WriteLine (output)
//                                     
//content
//  Write
//  WriteLine

using static System.Console;


///////////////////////////////////////////////////////////////
//write
//نمایش خروجی و ماندن در همان خط
//show output and stay same line
Write("/////////////// Write ///////////////\n");
Write("my name is : ");
Write("h.abdizadeh");

//next line string command ==> "\n"
Write("\n");

Write("my name is :\nh.abdizadeh");


///////////////////////////////////////////////////////////////
//WriteLine
//نمایش خروجی و انتقال به خط بعدی
//show output and go next line
WriteLine("\n\n/////////////// WriteLine ///////////////");
WriteLine();//equal by Write("\n);
WriteLine("my name is :");
WriteLine("h.abdizadeh");



///////////////////////////////////////////////////////////////
//مثال 1
//example 1
WriteLine("\n/////////////// example 1 ///////////////\n");

int n = 5;
int m = 6;
string str = "5";

WriteLine(n + m);
WriteLine(str + m);


///////////////////////////////////////////////////////////////
//مثال 2
//example 2
//Write or WriteLine("your static text {0}", variable}
WriteLine("\n/////////////// example 2 ///////////////\n");
string name = "h.abdizadeh";
WriteLine("my name is : {0}", name);

WriteLine("\n/////////////// finish ///////////////\n");
