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

Console.WriteLine();
Console.WriteLine("Ввод текста");
Console.Write("Введите ваше имя: ");
string enteredName = Console.ReadLine();
Console.Write("Введите название вашей группы: ");
string enteredGroup = Console.ReadLine();
Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

Console.WriteLine();
Console.WriteLine("Ввод чисел: Convert и Parse");
Console.Write("Введите ваш год рождения: ");
string birthYearInput = Console.ReadLine();
int birthYearConvert = Convert.ToInt32(birthYearInput);
int birthYearParse = int.Parse(birthYearInput);
Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
Console.WriteLine($"int.Parse: {birthYearParse}");
Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

Console.WriteLine();
Console.WriteLine("Ввод чисел: TryParse");
Console.Write("Введите количество прочитанных книг за семестр: ");
string booksInput = Console.ReadLine();
bool wasSuccessful = int.TryParse(booksInput, out int booksCount);
Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
Console.WriteLine($"Значение переменной bookscount: {booksCount}");


//анкета студента
Console.Write("Введите ваше имя и фамилию: ");
string name = Console.ReadLine();
Console.Write("Введите вашу группу: ");
string group = Console.ReadLine();
Console.Write("Введите ваш год рождения: ");
string year = Console.ReadLine();
int yearbirth = int.Parse(year);
Console.Write("Введите ваш средний балл за прошлый семестр: ");
string middlemark = Console.ReadLine();
double middle = double.Parse(middlemark);
bool bigger = middle >= 4.0;
Console.Write("Введите вашу любимую букву алфавита: ");
string favalp = Console.ReadLine();

Console.WriteLine($"Введите имя и фамилию: {name}");
Console.Write($"Введите группу: {group}");
Console.WriteLine($"Введите год рождения: {year}");
Console.WriteLine($"Введите средний балл: {middlemark}");
Console.Write($"Введите любимую букву: {favalp}");
Console.WriteLine("\n");
Console.WriteLine("    Анкета");
Console.WriteLine($"{name}, {group}");
Console.WriteLine($"Год рождения: {year} (в 2030 году исполнится {2030-yearbirth})");
Console.WriteLine($"Средний балл: {middle}");
Console.WriteLine($"Балл >=4.0: {bigger}");
Console.WriteLine($"Любимая буква: {favalp}");

// калькулятор имт
Console.Write("Введите ваш рост");
string height = Console.ReadLine();
double hheight = Convert.ToDouble(height);
Console.Write("Введите ваш вес");
string weight = Console.ReadLine();
double wweight = Convert.ToDouble(weight);
double imt = wweight / (hheight * hheight);
Console.WriteLine($"ИМТ: {imt:F4}");


// //разбор фио через char
Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
Console.Write("Введите вашу фамилию: ");
string lastName = Console.ReadLine();
Console.WriteLine($"{lastName} {name[0]}.");

// //TryParse на трёх типах
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