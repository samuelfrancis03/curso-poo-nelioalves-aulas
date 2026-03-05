using System.Globalization;

//inferencia de tipos
//o var define o seu tipo de acordo com o da variavel 
var x = 10;
var y = 20.0;
var z = "Maria";

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

//Switch-case
/*Estrutura opcional a vários if-else encadeados, quando a condição envolve o teste
do valor de um variavel*/

int x = int.Parse(Console.ReadLine());
string day;

switch (x) 
{
    case 1:
        day = "Sunday";
        break;
    case 2:
        day = "Monday";
        break;
    case 3:
        day = "Tuesday";
        break;
    case 4:
        day = "Wednesday";
        break;
    case 5:
        day = "Thursday";
        break;
    case 6:
        day = "Friday";
        break;
    case 7:
        day = "Saturay";
        break;
    default:
        day = "Invalid value";
        break;
}

Console.WriteLine("Day: " + day);

//expressao condicional ternária
//Estrutura opcional ao if-else quando se deseja decidir um valor com bsse em uma condição

double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

Console.WriteLine(desconto);

//Funcões para strigs
string original = "abcde FHIJ ABC abc DEFG";

//converte para maiusculo
string s1 = original.ToUpper();
//converte para minusculo
string s2 = original.ToLower();
//apagando os espaçoes em branco
string s3 = original.Trim();
//Procura de index
int n1 = original.IndexOf("bc");
int n2 = original.LastIndexOf("bc");
//Recortar string
string s4 = original.Substring(3);
string s5 = original.Substring(3, 5);
//Substituir uma parte da string
string s6 = original.Replace('a', 'x');
string s7 = original.Replace("abc", "xy");
//teste de string vazia
bool b1 = string.IsNullOrEmpty(original);
bool b2 = string.IsNullOrWhiteSpace(original);

Console.WriteLine("Original: -" + original + "-");
Console.WriteLine("ToUpper: -" + s1 + "-");
Console.WriteLine("ToLower: -" + s2 + "-");
Console.WriteLine("Trim: -" + s3 + "-");
Console.WriteLine("IdexOf('bc'): " + n1);
Console.WriteLine("LastIdexOf('bc'): " + n2);
Console.WriteLine("Substring(3): " + s4);
Console.WriteLine("Substring(3, 5): " + s5);
Console.WriteLine("Replace('a', 'x') " + s6);
Console.WriteLine("Replace('abc', 'xy') " + s7);
Console.WriteLine("IsNullOrEmpty(original): " + b1);
Console.WriteLine("IsNullOrWhiteSpace(original): " + b2);

//Date Time - Instante
//Usando Construtores
DateTime d1 = new DateTime(2026, 03, 03);
DateTime d2 = new DateTime(2026, 03, 03, 11, 14, 04);
DateTime d3 = new DateTime(2026, 03, 03, 11, 14, 04, 500);

//Builders
DateTime d4 = DateTime.Now;
DateTime d5 = DateTime.Today;
DateTime d6 = DateTime.UtcNow;

//Parse
DateTime d7 = DateTime.Parse("2000-08-15");
DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
DateTime d9 = DateTime.Parse("15/08/2000");
DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

//Parse Exact
DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
Console.WriteLine(d5);
Console.WriteLine(d6);
Console.WriteLine(d7);
Console.WriteLine(d8);
Console.WriteLine(d9);
Console.WriteLine(d10);
Console.WriteLine(d11);
Console.WriteLine(d12);

//Propiedades e operações com DateTime
DateTime d = new DateTime(2026, 03, 03, 11, 14, 04, 500);
Console.WriteLine("1) Date: " + d.Date);
Console.WriteLine("2) Day: " + d.Day);
Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
Console.WriteLine("5) Hour: " + d.Hour);
Console.WriteLine("6) Kind: " + d.Kind);
Console.WriteLine("7) Millisecond: " + d.Millisecond);
Console.WriteLine("8) Minute: " + d.Minute);
Console.WriteLine("9) Month: " + d.Month);
Console.WriteLine("10) Second: " + d.Second);
Console.WriteLine("11) Ticks: " + d.Ticks);
Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
Console.WriteLine("13) Year: " + d.Year);

Console.WriteLine();
Console.WriteLine(d.ToLongDateString());
Console.WriteLine(d.ToShortDateString());
Console.WriteLine(d.ToLongTimeString());
Console.WriteLine(d.ToShortTimeString());
Console.WriteLine(d.ToString());
Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));





//TimeSpan - DURAÇÃO
//Construtores
TimeSpan t1 = new TimeSpan();
TimeSpan t2 = new TimeSpan(9000000000L); //ticks
TimeSpan t3 = new TimeSpan(2, 11, 21); //(hh, mm, ss)
TimeSpan t4 = new TimeSpan(1, 2, 11, 21); //(dd, hh, mm, ss)
TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321); //(dd, hh, mm, ss, milisegundos)

//Metodos From
TimeSpan t6 = TimeSpan.FromDays(1.5);
TimeSpan t7 = TimeSpan.FromHours(1.5);
TimeSpan t8 = TimeSpan.FromMinutes(1.5);
TimeSpan t9 = TimeSpan.FromSeconds(1.5);
TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
TimeSpan t11 = TimeSpan.FromTicks(900000000L);

Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);
Console.WriteLine(t4);
Console.WriteLine(t5);
Console.WriteLine(t6);
Console.WriteLine(t7);
Console.WriteLine(t8);
Console.WriteLine(t9);
Console.WriteLine(t10);
Console.WriteLine(t11);

//Propiedades e operações com TimeSpan

TimeSpan t12 = TimeSpan.MaxValue;
TimeSpan t13 = TimeSpan.MinValue;
TimeSpan t14 = TimeSpan.Zero;

TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

Console.WriteLine("Days: " + t.Days);
Console.WriteLine("Hours: " + t.Hours);
Console.WriteLine("Minutes: " + t.Minutes);
Console.WriteLine("Milliseconds: " + t.Milliseconds);
Console.WriteLine("Seconds: " + t.Seconds);
Console.WriteLine("Ticks: " + t.Ticks);

Console.WriteLine("TotalDays: " + t.TotalDays);
Console.WriteLine("TotalHours: " + t.TotalHours);
Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);


//DateTImeKind 
//Tipo enumerado especila que define três valores possiveis para a localidade da data
DateTime dk1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
DateTime dk2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
DateTime dk3 = new DateTime(2000, 8, 15, 13, 5, 58);

Console.WriteLine("d1: " + dk1);
Console.WriteLine("d1 Kind: " + dk1.Kind);
Console.WriteLine("d1 to Local: " + dk1.ToLocalTime());
Console.WriteLine("d1 to UTC: " + dk1.ToUniversalTime());
Console.WriteLine();
Console.WriteLine("d2: " + dk2);
Console.WriteLine("d2 Kind: " + dk2.Kind);
Console.WriteLine("d2 to Local: " + dk2.ToLocalTime());
Console.WriteLine("d2 to UTC: " + dk2.ToUniversalTime());
Console.WriteLine();
Console.WriteLine("d3: " + dk3);
Console.WriteLine("d3 Kind: " + dk3.Kind);
Console.WriteLine("d3 to Local: " + dk3.ToLocalTime());
Console.WriteLine("d3 to UTC: " + dk3.ToUniversalTime());

//Padrão ISO 8601
DateTime dt1 = DateTime.Parse("2000-08-15 13:05:58");
DateTime dt2 = DateTime.Parse("2000-08-15T13:05:58Z");

Console.WriteLine(dt1);
Console.WriteLine(dt2);
