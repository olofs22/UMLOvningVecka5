namespace UMLOvning2
{
    public class Cat : Animal
    {
        public string Roll;
        private string BegForFood;

        public override void MakeSound()
        {
            Console.WriteLine("I make the sound Meow!");
        }

        public void WriteBeg()
        {
            string BegForFood = "I want food!";
            Console.WriteLine($"{BegForFood}");
        }
    }
}