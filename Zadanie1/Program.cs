int a = 2;
int b = 10;
int max = a;
int min = b;

if (a > b) max = a;
if (b > a) max = b;

if (a < b) min = a;
if (b < a) min = b;


Console.Write("max = ");
Console.WriteLine(max); 

Console.Write("min = ");
Console.WriteLine(min);