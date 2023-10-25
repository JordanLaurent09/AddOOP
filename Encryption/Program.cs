namespace Encryption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "Bogdan";

            char[] charedPass = password.ToCharArray();
            byte[] bytes = new byte[charedPass.Length];

            for(int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)charedPass[i];
            }

            int[] encrypting = new int[charedPass.Length];

            for(int i = 0; i < encrypting.Length; i++)
            {
                encrypting[i] = bytes[i] ^ 5;
            }

            for(int i = 0; i < encrypting.Length; i++) 
            {
                Console.WriteLine($"Symbol {charedPass[i]} - {bytes[i]} - {encrypting[i]}");
            }
            int[] decrypting = new int[charedPass.Length];

            for(int i = 0; i < decrypting.Length; i++)
            {
                decrypting[i] = encrypting[i] ^ 5;
            }

            for (int i = 0; i < decrypting.Length; i++)
            {
                Console.WriteLine($"Symbol {charedPass[i]} - {bytes[i]} - {decrypting[i]}");
            }



            char symbol = 'f';
            Console.WriteLine(symbol);
            int code = (byte)symbol;
            Console.WriteLine(code);
            int enc = code ^ 10;
            Console.WriteLine(enc);
            int dec = enc ^ 10;
            Console.WriteLine(dec);
            char s1 = (char)dec;
            Console.WriteLine(s1);
        }
    }
}