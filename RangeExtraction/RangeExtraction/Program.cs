
//A format for expressing an ordered list of integers is to use a comma separated list of either

//individual integers
//or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'. The range includes all integers in the interval including both endpoints. It is not considered a range unless it spans at least 3 numbers. For example "12,13,15-17"
//Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.

//Example:

//solution([-6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
//// returns "-6,-3-1,3-5,7-11,14,15,17-20"


//Assert.AreEqual(
//        "-6,-3-1,3-5,7-11,14,15,17-20",
//               RangeExtraction.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 })
using System.Linq;
///
Console.WriteLine(RangeExtraction.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 }));

public class RangeExtraction
{
    public static string Extract(int[] args)
    {
        var lista = args.ToList();
        int soma = 0;
        string results = lista[0].ToString() + ",";
        bool iniciorange = false;
        bool printed = false;
        for (int i = 1; i < lista.Count - 1; i++)
        {
            soma = Math.Abs(Math.Abs(lista[i + 1]) - Math.Abs(lista[i]));
            printed = false;
            if (soma > 1)
            {
                results += lista[i].ToString() + ",";
                iniciorange = false;
                printed = true;

            }

            if ((soma == 1) && ((!iniciorange))){
                results += lista[i].ToString() + "-";
                iniciorange = true;
            }
            if ((iniciorange) && (i == lista.Count - 2) && (!printed))
            {
                results += lista[i+1].ToString();
            }
        }
        return results;
    }
}