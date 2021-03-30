using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_FizzBuzz
{
    public static class FizzBuzz
    {
        public static string Parse(int input)
        {
            // Behaviour:
            string result = "";

            result += (input % 3 == 0) ? "Fizz" : "";
            result += (input % 5 == 0) ? "Buzz" : "";

            if (result != "")
                return $"Otrzymano: {result}";
            return $"Liczba: {input} nie spełnia kryteriów Fizz/Buzz";

            // Powyższy kod jest zbyt długi :P
            //return ((input % 3 == 0 ? "Fizz" : "") + (input % 5 == 0 ? "Buzz" : "")) is string ii ? (ii != "" ? ii : input.ToString()) : "";
            // Niestety musiałem przerobić kod, ale dalej jestem dumny z tego potworka :3
        }
    }
}
