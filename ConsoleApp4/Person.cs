using System.Runtime.Serialization;

namespace ConsoleApp4
{

    public class Person : Human
    {
        public string PetName { get; set; }
        public Person(string name, int speed, int time) : base(speed, time)
        {
            PetName = name;
        }
        public override string ToString()
        {
            var result = $"Name:{PetName} Speed:{CurrentSpeed} Time:{Time}";
            return result;
        }
    }






}
