using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        double num1, num2;

        do

        {
            Console.Clear();
            Console.WriteLine("Console Calculator in C#");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("5. Exit");
            Console.WriteLine("\nMasukkan Pilihan Anda: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Tolong Masukkan Angka Pertama: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Tolong Masukkan Angka Kedua: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Hasil: {num1 + num2}");
                    break;
                case 2:
                    Console.Write("Tolong Masukkan Angka Pertama: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Tolong Masukkan Angka Kedua: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Hasil: {num1 - num2}");
                    break;
                case 3:
                    Console.Write("Tolong Masukkan Angka Pertama: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Tolong Masukkan Angka Kedua: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Hasil: {num1 * num2}");
                    break;
                case 4:
                    Console.Write("Tolong Masukkan Angka Pertama: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Tolong Masukkan Angka Kedua: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (num2 != 0)
                        Console.WriteLine($"Hasil: {num1 / num2}");
                    else
                        Console.WriteLine("Error: Pembagian dengan angka 0 tidak diperbolehkan:(");
                    break;
                case 5:
                    Console.WriteLine("Terimakasih karena telah menggunakan kalkulator:)");
                    break;
                default:
                    Console.WriteLine("Maaf pilihan yang anda pilih tidak tersedia:(");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        } while (choice != 5);
    }
}