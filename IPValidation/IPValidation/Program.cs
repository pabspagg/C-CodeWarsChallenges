Console.WriteLine(Kata.is_valid_IP("137.255.156.100"));
Console.WriteLine(Kata.is_valid_IP(""));
Console.WriteLine(Kata.is_valid_IP("abc.def.ghi.jkl"));
Console.WriteLine(Kata.is_valid_IP("123.456.789.0"));
Console.WriteLine(Kata.is_valid_IP("0.0.0.0"));
Console.WriteLine(Kata.is_valid_IP("12.34.56"));
Console.WriteLine(Kata.is_valid_IP("12.255.56.1"));
Console.WriteLine(Kata.is_valid_IP("12.34.56.00"));
Console.WriteLine(Kata.is_valid_IP("12.34.56.7.8"));
Console.WriteLine(Kata.is_valid_IP("12.34.256.78"));
Console.WriteLine(Kata.is_valid_IP("1234.34.56"));
Console.WriteLine(Kata.is_valid_IP("pr12.34.56.78"));
Console.WriteLine(Kata.is_valid_IP("12.34.56.78sf"));
Console.WriteLine(Kata.is_valid_IP("12.34.56 .1"));
Console.WriteLine(Kata.is_valid_IP("12.34.56.-1"));
Console.WriteLine(Kata.is_valid_IP("123.045.067.089"));

class Kata
{
    public static bool is_valid_IP(string ipAddres)
    {
        string[] iparray = ipAddres.Split(".").Select();
            if (iparray.Length != 4) {
            return false;


        }
        foreach (string ip in iparray) {
            char[] c = ip.ToCharArray();
            int count = 0;
            foreach (char t in c)
            {
                if (!char.IsDigit(t)) return false;
                if ((count == 0) && t == '0') return false;
            }
           
            try
            {
                int octeto = Convert.ToInt32(ip);
                if (!((octeto >= 0) && (octeto <= 255))) return false;
            }
            catch (FormatException) {
                return false;
            }          
        }
        return true;
    }
}
