using System;
using System.Globalization;

namespace C_sharp
{
    class Program
    {
        private static void whatIsCultureInvariant()
        {
            DateTime dt = DateTime.Parse(exampleDateTime, CultureInfo.InvariantCulture);
            Console.WriteLine("Time representation irrelevant to culture:");
            Console.WriteLine(dt.ToString("F", CultureInfo.InvariantCulture));
            foreach (var culture in cultures)
            {
                CultureInfo cultureTo = new CultureInfo(culture);
                var displayName = string.IsNullOrWhiteSpace(cultureTo.Name) ? "Culture-Invariant" : cultureTo.Name;
                Console.WriteLine($"Displaying the formatted timezone for {displayName}: ");
                Console.WriteLine(dt.ToString("F", cultureTo));
            }
        }
        private static void toUpperCulture()
        {
            var someText = "iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii";
            Console.WriteLine(someText.ToUpper(new CultureInfo("tr-TR"));
            Console.WriteLine(someText.ToUpperInvariant());

        }
        private static string[] cultures = { "fr-FR", "zh-CN", "", "en-US" };
        private static string exampleDateTime = "Tue, 15 May 2012 16:34:16 GMT";
        static void Main(string[] args)
        {
            whatIsCultureInvariant();
            toUpperCulture();
        }
    }
}
