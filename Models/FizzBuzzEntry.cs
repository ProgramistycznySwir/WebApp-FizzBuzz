using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace WebApp_FizzBuzz.Models
{
    /// Oczywiście przechowywanie rezultatu w tym miejscu jest tragicznym pomysłem z racji, że da się go uzyskać z 
    ///  zmiennej entry, jednak ma to służyć tylko jako ćwiczenie serializacji danych więc, who cares :/
    /// Kluczem głównym tabeli jest date, typ 7 bajtowy, oraz nie koniecznie zapewniający unikatowość rekordów,
    ///  ale kogoto obchodzi :)
    public class FizzBuzzEntry
    {
        [Required]
        public int entry { get; set; }
        [Required]
        [MaxLength(64)]
        public string result { get; set; }
        /// <summary>
        /// DB main key.
        /// </summary>
        [Key]
        public DateTime date { get; set; }

        public FizzBuzzEntry(int entry)
        {
            this.entry = entry;
            this.date = DateTime.Now;
            this.result = ParseFizzBuzz(entry);

            // Powyższy kod jest zbyt długi :P
            //return ((input % 3 == 0 ? "Fizz" : "") + (input % 5 == 0 ? "Buzz" : "")) is string ii ? (ii != "" ? ii : input.ToString()) : "";
            // Niestety musiałem przerobić kod, ale dalej jestem dumny z tego potworka :3
        }

        static string ParseFizzBuzz(int entry)
        {
            string result = "";

            result += (entry % 3 == 0) ? "Fizz" : "";
            result += (entry % 5 == 0) ? "Buzz" : "";

            if (result != "")
                return $"Otrzymano: {result}";
            else
                return $"Liczba: {entry} nie spełnia kryteriów Fizz/Buzz";
        }


        public override string ToString()
        {
            return $"{date} - {entry} -> \"{result}\"";
        }
    }
}
