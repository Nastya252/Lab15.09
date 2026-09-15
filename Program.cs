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



Console.Write("Введите ваш рост в метрах: ");
string heightInput = Console.ReadLine();
double hheight = Convert.ToDouble(heightInput);

Console.Write("Введите ваш вес в килограммах: ");
string weightInput = Console.ReadLine();
double wweight = Convert.ToDouble(weightInput);

Console.WriteLine($"Рост: {hheight}, Вес: {wweight}"); // <-- диагностика

double imt = wweight / (hheight * hheight);
Console.WriteLine($"ИМТ: {imt:F2}");
