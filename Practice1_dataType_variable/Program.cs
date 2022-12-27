//تمرین ا _ انواع داده و تعریف متغیر   
//practice 1 _ data types and variables  
//                                     
//content                              
//  variable definition pattern       
//  data types                    
//  const                         
//  var                           

///////////////////////////////////////////////////////////////
//الگوی تعریف متغیر
//[مقدار اولیه] = [نام متغیر] [نوع داده];
// یا
//[نام متغیر] [نوع داده];
//[مقدار] = [نام متغیر];

//variable definition pattern
//[dataType] [variableName] = [defaultValue];
// or
//[dataType] [variableName];
//[variableName] = [value];


//انواع داده عدد صحیح
//integer number data type
byte bt = 5;    //size 8 bit   // 0 -> 255
sbyte sbt = -5; //size 8 bit   // -128 -> 127

short s = -35;  //size 16 bit  // -32768 -> 32767
ushort us;      //size 16 bit  // 0 -> 65535

int i = 1245;   //size 32 bit  // -2147483648 -> 2147483647
uint ui;        //size 32 bit  // 0 -> 4294967295
ui = 1221;


long l;         //size 64 bit  // -9223372036854775808 -> 9223372036854775807
ulong lng;      //size 64 bit  // 0 -> 18446744073709551615

l = 2131;

//انواع داده عدد اعشاری
//decimal number data type
float flt = 3.5f;       //size 32 bit  // 7-8 decimal   //رقم دقت اعشار
double dbl = 2.5;       //size 64 bit  // 15-16 decimal //رقم دقت اعشار
decimal dcml = 3.5m;    //size 128 bit // 28-29 decimal //رقم دقت اعشار

//داده متنی یا رشته متنی
//text(string) data type
string str = "hello";

//داده کاراکتری، حرف یا علامت 
//character data type
char ch = 'a';

//داده نوع منطقی
//logical(boolean) data type
bool b = true;//false


///////////////////////////////////////////////////////////////
// مقادیر ثابت 
// const (unchangeable)
const double pi = 3.14;
const string key = "R293";

///////////////////////////////////////////////////////////////
// var : نوع داده بر اساس مقدار اولیه 
// var : data type base on default value
var number = 15;
var userName = "h.abdizadeh";


