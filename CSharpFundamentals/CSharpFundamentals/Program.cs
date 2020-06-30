using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var John = new Person();
            John.FirstName = "John";
            John.LastName = "Smith";
            John.Introduce();
        }
    }
}
