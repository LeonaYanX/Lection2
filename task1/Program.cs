Console.WriteLine("Enter the number of elements");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
int i = 0;
while(i<array.Length)
{
    array[i]=i+1;
    Console.Write($"{array[i]}\t");
    i= i+1;
}
