namespace Batch1_DET_2022
{
    internal static class AnimalsmainHelpers
    {
        public static void Main()
        {

            List<Animal> list = new List<Animal>();
            list.Add(new dog { Age = 4, Name = "Shino", Gender = "Male" });
            list.Add(new Cat { Age = 4, Name = "Shino", Gender = "Male" });
            foreach (var item in list)
            {
                Console.WriteLine(item.MakeSound());

            }

        }
    }
}