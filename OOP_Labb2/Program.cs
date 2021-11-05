using System;

namespace OOP_Labb2
{
    public class Djur
    {
        public string name;
        public string color;
        public string typeOfAnimal;
        public bool carnivore;
        public int age;

        public Djur() : this("no name give", "no color", "Unknow type", false, 0) { } //Default constructor

        public Djur(string _name, string _color, string _typeOfAnimal, bool _carnivore, int _age) //Constructor för att skapa nya djur
        {
            this.name = _name;
            this.color = _color;
            this.typeOfAnimal = _typeOfAnimal;
            this.carnivore = _carnivore;
            this.age = _age;
        }

        public void printAnimalInfo()
        {
            Console.WriteLine("Animal info: \n Name: " + name + "\n Color: " + color + "\n Type of animal: " + typeOfAnimal + "\n Carnivore = " + carnivore + "\n Animal age: " + age);
        }

        public void animalEating()
        {
            Console.WriteLine("The animal is eating!");
        }

        public void animalSleeping()
        {
            Console.WriteLine("The animal is sleeping!");
        }
    }

    public class Dog : Djur
    {
    

        public Dog(string Dogname, string Dogcolor, string DogtypeOfAnimal, bool Dogcarnivore, int Dogage, bool DogisPlaying) : base(Dogname,Dogcolor,DogtypeOfAnimal,Dogcarnivore,Dogage)
        {

            this.isPlaying = DogisPlaying;
        }
        public bool isPlaying = false;


        public void playing(bool isPlaying)
        {
            if (isPlaying == true)
            {
                Console.WriteLine("The dog is playing!");
            }
            else
            {
                Console.WriteLine("The dog is not playing!");
            }
        }



        public virtual void makeSound()
        {
            Console.WriteLine("WOOF!");
        }
    }

    public class goldenRetriever : Dog

    {
        public goldenRetriever() : this("no name give", "no color", "Unknow type", false, 0, false) { } //Default constructor

        public goldenRetriever(string Goldenname, string Goldencolor, string GoldentypeOfAnimal, bool Goldencarnivore, int Goldenage, bool GoldenisExcited) : base(Goldenname, Goldencolor, GoldentypeOfAnimal, Goldencarnivore, Goldenage,GoldenisExcited)
        {
            
            this.isExcited = GoldenisExcited;

        }
        public bool isExcited = false;


        public void wantsToPlay()
        {
            if (isExcited == true)
            {
                Console.WriteLine("The Golden Retriever wants to play!");
            }
            else
                Console.WriteLine("The Golden Retriever do not want to play!");
        }

        public override void makeSound()
        {
            Console.WriteLine("Golden Retriever WOOF!");
        }

    }

    public class germanShepherd : Dog
    {

        public germanShepherd() : this("no name give", "no color", "Unknow type", false, 0, false, "No gender") { } // Default constructor

        public germanShepherd(string Germanname, string Germancolor, string GermantypeOfAnimal, bool Germancarnivore, int Germanage, bool GermanisExcited, string Germangender) : base(Germanname, Germancolor, GermantypeOfAnimal, Germancarnivore, Germanage, GermanisExcited)
        {
            this.gender = Germangender;
        }
        public string gender;


        public void genderOfDog()
        {
            Console.WriteLine("The German shepherd is: " + gender);
        }

        public override void makeSound()
        {
            Console.WriteLine("German Shepherd WOOF!");
        }

    }
    




        public class Lion : Djur
        {
        public Lion() : this("no name give", "no color", "Unknow type", false, 0, false, 0) { } // Default constructor

        public Lion(string Lionname, string Lioncolor, string LiontypeOfAnimal, bool Lioncarnivore, int Lionage, bool LionisPlaying, int LionAmountOfChildren) : base(Lionname,Lioncolor, LiontypeOfAnimal,Lioncarnivore,Lionage)
        {
            this.amountOfChildren = LionAmountOfChildren;
        }
        public int amountOfChildren;

        public void family()
            {
                Console.WriteLine("The lion has " + amountOfChildren + " children ");
            }
            public void makeSound()
            {
                Console.WriteLine("RAWR!");

            }

        }

        public class Deer : Djur
        {
        public Deer() : this("no name give", "no color", "Unknow type", false, 0,0) { } // Default constructor

        public Deer(string Deername, string Deercolor, string DeertypeOfAnimal, bool Deercarnivore, int Deerage, int DeerAmountOfSpots) : base(Deername, Deercolor, DeertypeOfAnimal, Deercarnivore, Deerage)
        {
            this.amountOfSpots = DeerAmountOfSpots;
        }
        public int amountOfSpots;

            public void spots()
            {
                Console.WriteLine("The deer has" + amountOfSpots + " spots");
            }
            public void makeSound()
            {
                Console.WriteLine("ÄÄÄÄ!");

            }
    }
    

    class Program
    {
        static void Main(string[] args)
        {

            Dog dog1 = new Dog("Laban", "Grey", "Chiuahua", false,10,true);
            dog1.printAnimalInfo();
            Console.Write("Animal sound: "); dog1.makeSound();
            Console.WriteLine();

            goldenRetriever Golden1 = new goldenRetriever("Fido", "Yellow", "Golden", true, 8, true);
            Golden1.printAnimalInfo();
            Console.Write("Animal sound: ");  Golden1.makeSound();
            Console.WriteLine();

            germanShepherd German1 = new germanShepherd("Zelda", "Yellow", "Golden",  true, 5, true, "Female");
            German1.printAnimalInfo();
            German1.genderOfDog();
            Console.Write("Animal sound: "); German1.makeSound();
            Console.WriteLine();

            Lion Lion1 = new Lion("Simba" , "Gold/Brown", "Lion", true, 3, false,1);
            Lion1.printAnimalInfo();
            Lion1.family();
            Console.Write("Animal sound: "); Lion1.makeSound();
            Console.WriteLine();

            Deer deer1 = new Deer("Bambi", "Brown", "Deer", false, 5, 25);
            deer1.spots();
            deer1.printAnimalInfo();
            Console.Write("Animal sound: "); deer1.makeSound();







            Console.ReadKey();

        }
    }
}
