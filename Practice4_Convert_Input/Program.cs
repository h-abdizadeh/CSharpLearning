//تمرین 4 _ تبدیل انواع داده   
//practice 4 _ convert data types 
//                                     
//content
//  '=' operator rule
//  Cast
//  Parse
//  Convert
//  ToString

using static System.Console;


///////////////////////////////////////////////////////////////
//'=' operator rule (قانون مساوی)
//[مقادیر و متغیرها] = [متغیر]
//[variable] = [values or variable]

//int result;
//result = 5 + 7;

//هر دو سمت مساوی باید هم نوع باشند
//to side of equal(=) most be same data type
//[intDataType] = [intVariable or intDataType]


///////////////////////////////////////////////////////////////
//Cast
//([dataType]) [value]
//([dataType]) [variabl]

Write("/////////////// Cast ///////////////\n");
double dbl = 5.25;
WriteLine("double value : {0}", dbl);

//int n = dbl;
//Error : Cannot implicitly convert type 'double' to 'int'.

int n = (int)dbl;
WriteLine("double value cast to int : {0}", n);


///////////////////////////////////////////////////////////////
//Parse
//تبدیل رشته های متنی به سایر انواع داده
//just string data types to another data types
//[dataType].Parse([stringTypeValu])
//[dataType].Parse([stringTypeVariable])

Write("\n/////////////// Parse ///////////////\n");
//int num = ReadLine();
//Error : Cannot implicitly convert type 'string' to 'int'

Write("enter number : ");
int num = int.Parse(ReadLine());
WriteLine("input number * 2 : {0}", 2 * num);

///////////////////////////////////////////////////////////////
//Convert
//Convert.To[dataType][value]
//Convert.To[dataType][variable]

Write("\n/////////////// Convert ///////////////\n");

Write("enter number : ");
int number = Convert.ToInt32(ReadLine());//Int16 -> short // Int32 -> int // Int64 -> long
WriteLine("input number / 2 : {0}", number / 2);



///////////////////////////////////////////////////////////////
//ToString
//تبدیل هر مقدار به رشته متنی
//convert any value to string
//[variable].ToString()

Write("\n/////////////// ToString ///////////////\n");

char ch = 'a';
//string str = ch;
//Error : Cannot implicitly convert type 'char' to 'string'

string str = ch.ToString();

WriteLine("char + char -> {0}", ch + 'b');  //Read ASCII Table 
WriteLine("string + char -> {0}", str + 'b');
WriteLine("what happen? -> Read about ASCII Table");

Write("\n/////////////// finish ///////////////\n");