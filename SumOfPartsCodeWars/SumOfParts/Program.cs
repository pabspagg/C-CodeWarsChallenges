var z = (SumParts.PartsSums(new int[] { 0, 1, 3, 6, 10 }));
for (int i = 0; i < z.Length; i++)
{
    Console.Write(z[i] + " ");
}
Console.WriteLine();

var t = (SumParts.PartsSums(new int[] { 744125, 935, 407, 454, 430, 90, 144, 6710213, 889, 810, 2579358 }));
for (int i = 0; i< t.Length; i++)
{
    Console.Write(t[i] + " ");
}
Console.WriteLine();

Console.ReadKey();
class SumParts
{
    public static int[] PartsSums(int[] ls)
    {
        int[] sum = new int[ls.Length + 1];
        sum[ls.Length] = 0;
        for (int i = ls.Length - 1; i >= 0; i--)
        {
            sum[i]+= sum[i+1] + ls[i];
        }
         return sum;
    }
}