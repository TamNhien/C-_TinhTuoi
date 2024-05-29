using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap ngay thang nam sinh (yyyy-mm-dd): ");
        DateTime birthDay = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

        int age = DateTime.Now.Year - birthDay.Year;
        if (DateTime.Now < birthDay.AddYears(age)) age--;

        Console.WriteLine("Tuoi cua ban la: " + age);
    }
}