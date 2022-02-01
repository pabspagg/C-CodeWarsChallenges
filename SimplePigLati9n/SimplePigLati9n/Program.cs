/*Move the first letter of each word to the end of it, 
 then add "ay" to the end of the word. Leave punctuation marks untouched.
 */
using System.Text;
Console.WriteLine(Kata.PigIt("Pig latin is cool !"));

public class Kata
{
    public static string PigIt(string str)
    {
        return string.Join(" ", str.Split(' ').Select(w => w.Any(char.IsPunctuation) ? w : w.Substring(1) + w[0] + "ay"));
    }
}



