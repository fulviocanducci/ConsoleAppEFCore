namespace ConsoleAppEFCore.Models
{
   public class People
   {
      protected People() { }

      public People(string name)
      {
         Name = name;
      }

      public int Id { get; private set; }
      public string Name { get; private set; } = null!;


      public People SetId(int id)
      {
         Id = id;
         return this;
      }

      public People SetName(string name)
      {
         Name = name;
         return this;
      }
   }
}