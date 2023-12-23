Console.WriteLine("Enter the number of weigths");
int N = int.Parse(Console.ReadLine());
int[] weigths = new int [N];
for(int i = 0; i < weigths.Length ; i++)
{
    Console.WriteLine($"Enter the wegth {i+1}");
    weigths[i] = int.Parse(Console.ReadLine());
}
//int maxWeigth = weigths[0];
// for(int j = 1; j<weigths.Length ; j++)
// {
//     if(maxWeigth<weigths[j])
//     {
//         maxWeigth = weigths[j];
//     }
// }
// Console.WriteLine(maxWeigth);
int max = weigths[0] ;
foreach(int e in weigths)
{
    if (e>max)
    {
        max = e;
    }
}
Console.WriteLine(max);
