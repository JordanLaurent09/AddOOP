namespace Theme_35_Lesson_4_OOPTasks
{
    public class Animal
    {
        public string Name { get; set; }

        public string Species { get; set; }
        public double Weight { get; set; }


        public Animal(string name, string species, double weight):this(name, species)
        {            
            Weight = weight;
        }

        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public Animal()
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("SOUND");
        }

        public void MakeSound(string animalSound)
        {
            Console.WriteLine(animalSound);
        }

        public void Feed()
        {
            Console.WriteLine("MnomMnomMnom");
        }

        public static void FeedAll(Animal[] animals)
        {
            foreach(Animal animal in animals)
            {
                animal.Feed();
            }
        }

    }
}
