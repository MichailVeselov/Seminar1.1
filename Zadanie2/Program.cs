int a = 700;
int b = 2;
int c = 701;
int max = a;


if (a > b) max = a;
if (b > a) max = b;
if (c > a) max = c;

Console.Write("max = ");
Console.WriteLine(max); 


