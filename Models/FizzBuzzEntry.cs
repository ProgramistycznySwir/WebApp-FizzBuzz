using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_FizzBuzz.Models
{
    /// Oczywiście przechowywanie rezultatu w tym miejscu jest tragicznym pomysłem z racji, że da się go uzyskać z 
    ///  zmiennej entry, jednak ma to służyć tylko jako ćwiczenie serializacji danych więc, who cares :/
    public struct FizzBuzzEntry
    {
        public int entry { get; set; }
        public string result { get; set; }
        public DateTime date { get; set; }

        public FizzBuzzEntry(int entry)
        {
            this.entry = entry;
            date = DateTime.Now;

            // FizzBuzz Parsing:
            string result = "";

            result += (entry % 3 == 0) ? "Fizz" : "";
            result += (entry % 5 == 0) ? "Buzz" : "";

            if (result != "")
                this.result = $"Otrzymano: {result}";
            else
                this.result = $"Liczba: {entry} nie spełnia kryteriów Fizz/Buzz";

            // Powyższy kod jest zbyt długi :P
            //return ((input % 3 == 0 ? "Fizz" : "") + (input % 5 == 0 ? "Buzz" : "")) is string ii ? (ii != "" ? ii : input.ToString()) : "";
            // Niestety musiałem przerobić kod, ale dalej jestem dumny z tego potworka :3
        }

        public override string ToString()
        {
            return $"{date} - {entry} -> \"{result}\"";
        }
    }
}
