int [] array =  {1,2,3,4,5};
int n = 5;
int index = 0;

while (index < n)
{
    if (array[index] % 2 == 0)
    {
        Console.WriteLine (array[index]);
    }
    
    index ++;
}