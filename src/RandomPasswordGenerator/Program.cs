using System;
using SilentDevNull.Utilities.Security;

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Password Length 10");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(10)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(10)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(10)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(10)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(10)}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(10))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(10))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(10))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(10))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(10))}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Password Length 15");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(15)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(15)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(15)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(15)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(15)}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(15))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(15))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(15))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(15))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(15))}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Password Length 20");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(20))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(20))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(20))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(20))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(20))}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Password Length 25");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(25)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(25)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(25)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(25)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(25)}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(25))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(25))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(25))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(25))}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword(25))}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword())}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword())}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword())}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword())}");
            Console.WriteLine($"{Encoder.Base64Encode(RandomPassword.CreateRandomPassword())}");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
