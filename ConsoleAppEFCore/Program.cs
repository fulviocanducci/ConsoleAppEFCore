using ConsoleAppEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppEFCore
{
   internal class Program
   {
      static void Main(string[] args)
      {
         using DatabaseContext database = new();
         //People people = new People("Cezario C. Dias");
         //database.Peoples.Add(people);
         //database.SaveChanges();

         //int id = 3;
         //People? people = database.Peoples.Find(id);
         //if (people != null)
         //{
         //   people.SetName("Cezario Canducci Dias");
         //   database.SaveChanges();
         //}

         foreach(var person in database.Peoples.AsNoTracking())
         {
            Console.WriteLine("{0:000} {1}", person.Id, person.Name);
         }

         Console.WriteLine("Done ...");
      }
   }
}