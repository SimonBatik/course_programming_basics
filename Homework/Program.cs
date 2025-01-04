namespace Homework
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"\nZadejte údaje pro osobu {i}:\n");

                Console.Write("Jméno: ");
                string jmeno = Console.ReadLine();

                Console.Write("Příjmení: ");
                string prijmeni = Console.ReadLine();

                Console.Write("Věk: ");
                int vek = int.Parse(Console.ReadLine());

                Console.Write("Váha (v kg): ");
                double vaha = double.Parse(Console.ReadLine());

                Console.Write("Výška (v cm): ");
                double vyskaCm = double.Parse(Console.ReadLine());

                double vyskaM = vyskaCm / 100.0; // Převod na metry
                double bmi = vaha / (vyskaM * vyskaM); // Výpočet BMI

                Console.WriteLine($"\n{jmeno} {prijmeni} je starý(á) {vek} let. Váží {vaha} kilogramů a je {vyskaCm} centimetrů vysoký(á).");
                Console.WriteLine($"Jeho/její BMI je: {bmi:F2}\n");
            }

            Console.WriteLine("\nProgram ukončen. Stiskněte libovolnou klávesu pro ukončení.");
            Console.ReadKey();
        }
    }

}
