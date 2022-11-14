namespace CsharpOOP.InheritancePolymorphism
{   // Child Class
    internal class Eagle : Animal
    {
        public string Species { get; set; }
        public override string MakeSound()
        {
            return "ChiiiiHIiii";
        }
        public string Fly()
        {
            return "Eagle is Flying.";
        }
        public string Attack()
        {
            return "Eagle is attacking.";
        }
    }
}
