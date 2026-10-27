using System;
using System.Globalization;

// Console.WriteLine("Границы целочисленных типов");
// Console.WriteLine($"byte:    {byte.MinValue} .. {byte.MaxValue}");
// Console.WriteLine($"short:   {short.MinValue} .. {short.MaxValue}");
// Console.WriteLine($"int:     {int.MinValue} .. {int.MaxValue}");
// Console.WriteLine($"long:    {long.MinValue} .. {long.MaxValue}");

// Console.WriteLine();
// Console.WriteLine("Границы дробных типов");
// Console.WriteLine($"float:   {float.MinValue} .. {float.MaxValue}");
// Console.WriteLine($"double:  {double.MinValue} .. {double.MaxValue}");
// Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");


// Console.WriteLine();
// Console.WriteLine("Переполнение byte");
// byte maxByte = 255;
// byte overflowed = (byte)(maxByte + 1);
// Console.WriteLine($"255 + 1 для byte = {overflowed}");


// Console.WriteLine();
// Console.WriteLine("char");
// char firstLetter = 'A';
// char separator = '-';
// int charAsNumber = firstLetter; 
// Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
// Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
// Console.WriteLine($"Табуляция:\tпосле таба");
// Console.WriteLine($"Перенос:\nпосле переноса");

// Console.WriteLine();
// Console.WriteLine("decimal против double");
// double priceDouble = 0.1 + 0.2;
// decimal priceDecimal = 0.1m + 0.2m;
// Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
// Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");

// Console.WriteLine();
// Console.WriteLine("var");
// var studentAge = 20;            
// var gpa = 4.75;                 
// var fullName = "Смирнова А.С."; 
// Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");



// Console.WriteLine();
// Console.WriteLine("Ввод текста");
// Console.Write("Введите ваше имя: ");
// string enteredName = Console.ReadLine();
// Console.Write("Введите название вашей группы: ");
// string enteredGroup = Console.ReadLine();
// Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

// Console.WriteLine();
// Console.WriteLine("Ввод чисел: Convert и Parse");
// Console.Write("Введите ваш год рождения: ");
// string birthYearInput = Console.ReadLine();
// int birthYearConvert = Convert.ToInt32(birthYearInput);
// int birthYearParse = int.Parse(birthYearInput);
// Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
// Console.WriteLine($"int.Parse: {birthYearParse}");
// Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");


// Console.WriteLine();
// Console.WriteLine("Ввод чисел: TryParse");
// Console.Write("Введите количество прочитанных книг за семестр: ");
// string booksInput = Console.ReadLine();
// bool wasSuccessful = int.TryParse(booksInput, out int booksCount);
// Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
// Console.WriteLine($"Значение переменной booksCount: {booksCount}");



Console.WriteLine();
Console.WriteLine("--- Анкета студента ---");
Console.Write("Введите имя и фамилию: ");
string anketaName = Console.ReadLine();

Console.Write("Введите группу: ");
string anketaGroup = Console.ReadLine();

Console.Write("Введите год рождения: ");
int anketaYear = int.Parse(Console.ReadLine());

Console.Write("Введите средний балл: ");
double anketaGpa = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

Console.Write("Введите любимую букву: ");
char anketaLetter = Console.ReadLine()[0];

Console.WriteLine();
Console.WriteLine("Анкета");
Console.WriteLine($"{anketaName}, группа {anketaGroup}");
Console.WriteLine($"Год рождения: {anketaYear} (в 2030 будет {2030 - anketaYear} лет)");
Console.WriteLine($"Средний балл: {anketaGpa.ToString(CultureInfo.InvariantCulture)}");
Console.WriteLine($"Балл >= 4.0: {anketaGpa >= 4.0}");
Console.WriteLine($"Любимая буква: {anketaLetter}");


// Console.WriteLine();
// Console.WriteLine("--- Задание 1: Калькулятор ИМТ ---");
// Console.Write("Введите рост в метрах (например, 1.75): ");
// double height = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

// Console.Write("Введите вес в килограммах (например, 68.5): ");
// double weight = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

// double bmi = weight / (height * height);
// Console.WriteLine($"ИМТ: {bmi:F2}");


// Console.WriteLine();
// Console.WriteLine("--- Задание 2: Разбор ФИО ---");
// Console.Write("Введите фамилию: ");
// string surname = Console.ReadLine();

// Console.Write("Введите имя: ");
// string firstName = Console.ReadLine();

// char initial = firstName[0];
// Console.WriteLine($"Результат: {surname} {initial}.");


// Console.WriteLine();
// Console.WriteLine("--- Задание 3: TryParse (int, double, DateTime) ---");


// Console.Write("Введите целое число: ");
// string intInput = Console.ReadLine();
// bool isIntSuccess = int.TryParse(intInput, out int intVal);
// Console.WriteLine($"int.TryParse: успешно = {isIntSuccess}, значение = {intVal}");


// Console.Write("Введите дробное число: ");
// string dblInput = Console.ReadLine().Replace(',', '.');
// bool isDblSuccess = double.TryParse(dblInput, NumberStyles.Any, CultureInfo.InvariantCulture, out double dblVal);
// Console.WriteLine($"double.TryParse: успешно = {isDblSuccess}, значение = {dblVal.ToString(CultureInfo.InvariantCulture)}");


// Console.Write("Введите дату (в формате дд.мм.гггг, например 15.03.2006): ");
// string dateInput = Console.ReadLine();
// bool isDateSuccess = DateTime.TryParseExact(
//     dateInput, 
//     "dd.MM.yyyy", 
//     CultureInfo.InvariantCulture, 
//     DateTimeStyles.None, 
//     out DateTime dateVal
// );

// if (!isDateSuccess)
// {
//     isDateSuccess = DateTime.TryParse(dateInput, out dateVal);
// }
// Console.WriteLine($"DateTime.TryParse: успешно = {isDateSuccess}, значение = {(isDateSuccess ? dateVal.ToString("dd.MM.yyyy") : DateTime.MinValue.ToString("dd.MM.yyyy"))}");





