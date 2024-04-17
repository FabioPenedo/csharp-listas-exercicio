using System;
using System.Collections.Generic;
using System.Globalization;

namespace App // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("How many employee will be registered? ");
      int quantidade = int.Parse(Console.ReadLine() ?? "");
      List<Employee> list = [];
      for (int i = 1; i <= quantidade; i++)
      {
        Console.WriteLine();
        Console.WriteLine($"Emplyoee #{i}:");
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Salary: ");
        double salary = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);
        list.Add(new Employee(id, name, salary));
      }

      Console.Write("Enter the employee id that will have salary increase: ");
      int searchId = int.Parse(Console.ReadLine() ?? "");

      Employee filter = list.Find(emp => emp.Id == searchId)!;

      if (filter != null)
      {
        Console.Write("Enter the percentage: ");
        double percentage = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);
        filter.increaseSalary(percentage);
      }
      else
      {
        Console.WriteLine("This id does not exist!");
      }

      Console.WriteLine();
      Console.WriteLine("Updated list of employees:");
      foreach (Employee item in list)
      {
        Console.WriteLine(item);
      }

    }
  }

}