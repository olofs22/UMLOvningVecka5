namespace UMLOvning2
{
    public class Dog : Animal
    {
        public string Jump;

        public override void MakeSound()
        {
            Console.WriteLine("I make the sound Woof!");
        }
    }
}