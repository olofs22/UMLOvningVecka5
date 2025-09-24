namespace UMLOvning2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog Lilli = new Dog();
            Lilli.Legs = 4;
            Lilli.Jump = "I can jump";

            Cat Musse = new Cat();
            Musse.Legs = 4;
            Musse.Roll = "I can roll";
            
            Lilli.MakeSound();

            Musse.MakeSound();

            Musse.WriteBeg();
        }
        

    }
}
