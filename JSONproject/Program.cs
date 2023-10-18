using System.Text.Encodings.Web;
using System.Text.Json;

namespace JSONproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Sergey";
            person.Surname = "Shuraev";
            person.Age = 31;
            person.Birthday = new DateTime(1992, 6, 5);
            person.NominalOfMoney = new int[]{10, 15, 25};
            person.Colors = new List<string> { "Red", "Green", "Blue" };


            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            }; 

            string personJson = JsonSerializer.Serialize(person, typeof(Person), options);

            StreamWriter file = File.CreateText("person.json"); // создан объект файла
            file.WriteLine(personJson); 
            file.Close();

            string jsonData = File.ReadAllText("person.json");

            Person personNew = JsonSerializer.Deserialize<Person>(jsonData);

            string bananaFile = File.ReadAllText("product.json");

            Product banana = JsonSerializer.Deserialize<Product>(bananaFile);

            Console.WriteLine("{0} {1} {2}", banana.Name, banana.Price, banana.Description);
            
        }
    }

    class Person
    {       
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }

        public int[] NominalOfMoney { get; set; } = new int[3];
        public List<string> Colors {  get; set; } = new List<string>();
       
    }

    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}