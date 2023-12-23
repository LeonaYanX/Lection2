internal class Program
{
    private static void Main(string[] args)
    {
          int[] array = new int[10];
   
   for (int i = 0; i < array.Length; i++)
   {
       Console.WriteLine($"Enter the element {i}");
       array[i] = int.Parse(Console.ReadLine());
   }
   for (int j = 0; j < array.Length; j++)
   {
    if(array[j]%2==0)
    {
        Console.Write(array[j] + "\t");
    }
   }
   
    }
}