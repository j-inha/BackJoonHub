namespace drainage
{
    class Program
    {
        static void Main(string[] args)
        {
           int total = int.Parse(Console.ReadLine());
           int count = total / 4;
            string stringToAdd = "";
            string end = "int";
            for (int i = 0; i < count; i++) 
            {
                stringToAdd += "long ";
            }
            string text = stringToAdd + end;
            Console.WriteLine(text);
        }
    }
}