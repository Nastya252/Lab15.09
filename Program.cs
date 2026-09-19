Console.WriteLine("Границы целочисленных типов");
Console.WriteLine($"{byte.MinValue} .. {byte.MaxValue}");
Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
Console.WriteLine($"long: {long .MinValue} .. {long.MaxValue}");

Console.WriteLine();
Console.WriteLine("Границы целочисленных типов");
Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");


Console.WriteLine();
Console.WriteLine("Переполнение byte");

byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte = {overflowed}");


Console. WriteLine( );
Console.WriteLine("char");

char firstLetter = 'A';
char separator = '-';
int charAsNumber = firstLetter; 
Console.WriteLine($"Символ: {firstLetter}, разделитель:{separator}");
Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}") ;
Console.WriteLine($"Табуляция: \tпосле таба");
Console.WriteLine($"Перенос: \nпосле переноса");

Console.WriteLine();
Console.WriteLine("decimal против double");
double priceDouble = 0.1 + 0.2;
decimal priceDecimal = 0.1m + 0.2m;
Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");


Console.WriteLine();
Console.WriteLine("var");

var studentAge = 20;
var gpa = 4.75;
var fullName = "Смирнова А.С."; 

Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");




// калькулятор имт
Console.Write("Введите ваш рост");
string height = Console.ReadLine();
double hheight = Convert.ToDouble(height);
Console.Write("Введите ваш вес");
string weight = Console.ReadLine();
double wweight = Convert.ToDouble(weight);
double imt = wweight / (hheight * hheight);
Console.WriteLine($"ИМТ: {imt:F4}");


//разбор фио через char
Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
Console.Write("Введите вашу фамилию: ");
string lastName = Console.ReadLine();
Console.WriteLine($"{lastName} {name[0]}.");

//TryParse на трёх типах
Console.Write("Введите число ");
string first = Console.ReadLine();
bool firstint = int.TryParse(first, out int firstresult);
if (firstint)
    Console.WriteLine($"Успешное преобразование в целое число: {firstresult}");
else 
    Console.WriteLine($"Не удалось преобразовать");

Console.Write("Введите число с запятой ");
string second = Console.ReadLine();
bool doublesecond = double.TryParse(second, out double secondresult);
if (doublesecond)
    Console.WriteLine($"Успешное преобразование в дробное число: {secondresult}");
else
    Console.WriteLine("Не удалось преобразовать");

Console.Write("Введите дату в формате дд.мм.гггг ");
string third = Console.ReadLine();
bool thirddate = DateTime.TryParse(third, out DateTime thirdresult);
if (thirddate)
    Console.WriteLine($"Успешное преобразование в дату: {thirdresult}");
else
    Console.WriteLine($"Не удалось преобразовать");