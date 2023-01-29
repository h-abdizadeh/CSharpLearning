//تمرین 7 _ ترکیب های شرطی   
//practice 7 _ and(&&) or(||)
//                                     
//content
//  And Table
//  Or Table
//  

///////////////////////////////////////////////////////////////////
// And (&&) (& --> Shift + 7)
//
//تمام شرط ها در کنار هم باید برقرار باشند
//مثال: برای قبولی در درس باید شرط 1--> نمره بالای 10 داشته باشید 'و' شرط 2--> پروژه کلاسی را تحویل دهید
//
//all conditions most be True
//To pass the course, you must have condition 1--> score above 10 'and' condition 2--> do a project
//
//And(&&) Table
//_____________________________________
// condition 1 | condition 2 | result 
//-------------|-------------|---------
//     True    |    True     |  True
//     True    |    False    |  False
//     False   |    True     |  False
//     False   |    False    |  False
//_____________|_____________|_________
//

using static System.Console;

START:

float score;
string project;


//قبولی در در درس _ حالت اول
//condition 1--> score above 10 'and' condition 2--> do a project
Write("/////////////// condition 1--> score above 10 'and' condition 2--> do a project ///////////////\n");

ForegroundColor = ConsoleColor.White;//change console background text color
BackgroundColor = ConsoleColor.Black;//change console text color

Write("enter student score : ");
score = float.Parse(ReadLine());

Write("project state (yes --> y , no--> any) : ");
project = ReadLine();


if (score >= 10 && project == "y")
{
    ForegroundColor = ConsoleColor.Yellow;
    BackgroundColor = ConsoleColor.Green;

    WriteLine("pass");
}
else
{
    ForegroundColor = ConsoleColor.Yellow;
    BackgroundColor = ConsoleColor.Red;

    WriteLine("fail");
}

//back to default
ForegroundColor = ConsoleColor.White; 
BackgroundColor = ConsoleColor.Black; 

///////////////////////////////////////////////////////////////////
// Or (||)  (| --> Shift + \)
//
//یک شرط از میان شرط ها برقرار باشد
//مثال: برای قبولی در درس باید شرط 1--> نمره بالای 15 داشته باشید 'یا' شرط 2--> پروژه کلاسی را تحویل دهید
//
//on condition in conditions most be True
//To pass the course, you must have condition 1--> score above 15 'or' condition 2--> do a project
//
//And(&&) Table
//_____________________________________
// condition 1 | condition 2 | result 
//-------------|-------------|---------
//     True    |    True     |  True
//     True    |    False    |  True
//     False   |    True     |  True
//     False   |    False    |  False
//_____________|_____________|_________
//


//قبولی در در درس _ حالت دوم
//condition 1--> score above 10 'and' condition 2--> do a project
Write("\n/////////////// condition 1--> score above 10 'and' condition 2--> do a project ///////////////\n");

Write("enter student score : ");
score = float.Parse( ReadLine());

Write("project state (yes --> y , no--> any) : ");
project =  ReadLine();


ForegroundColor = ConsoleColor.Yellow; //change console background text color

if (score>=15 || project=="y")
{
    BackgroundColor = ConsoleColor.Green; //change console background text color
    WriteLine("pass");
}
else
{
    BackgroundColor = ConsoleColor.Red; //change console background text color
    WriteLine("fail");
}

//back to default
ForegroundColor = ConsoleColor.White;
BackgroundColor = ConsoleColor.Black;



////////////////////////////// از تمرین 6 - from practice 6 /////////////////////////////////
//تعداد ارقام عدد ورودی + اعداد منفی
//number of digits + Negative numbers
Write("\n/////////////// number of digits + Negative numbers ///////////////\n");
Write("enter number : ");
int number = int.Parse(ReadLine());

if (number < 10 && number>-10)
{
    WriteLine("1 digit");
}
else if (number < 100 && number > -100)
{
    WriteLine("2 digits");
}
else if (number < 1000 && number > -1000)
{
    WriteLine("3 digits");
}
else
{
    WriteLine("4 digits or more");
}


//////////////////////////// از تمرین 6 - from practice 6 ///////////////////////////////////
//نام فصل بر اساس حرف اول + ورودی حرف بزرگ
//name of session based on first letter + uppercase input
Write("\n/////////////// name of session based on first letter + uppercase input ///////////////\n");

Write("enter letter : ");
char letter = ReadKey().KeyChar;

if (letter == 's' || letter == 'S')
{
    WriteLine("\nspring , summer");
}
else if (letter == 'a' || letter == 'A')
{
    WriteLine("\nautumn");
}
else if (letter == 'w' || letter == 'W')
{
    WriteLine("\nwinter");
}
else
{
    WriteLine("\ninvalid letter");
}


Write("\npress any key to again...");
ReadKey();
Clear();

goto START;//about goto in Program1_Simple_Calculations