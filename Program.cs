using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using parprogrammering2;

Main();

public partial class Program
{
    public static void Main()
    {
        Console.WriteLine("Skriv 'help' om du trenger hjelp.");
        Pet currentPet = null;
        var Pets = new List<Pet>
        {
            new Pet("Martin", 28, 100, 5, true),
            new Pet("Marie", 36, 20, 78, false),
            new Pet("Terje", 2, 0, 100, true)
        };



        while (true)
        {
            var userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "list":
                    ListPets();
                    break;

                case "choose":
                    ChoosePet();
                    break;

                case "feed":
                    FeedPet();
                    break;

                case "play":
                    Play();
                    break;

                case "walk":
                    Walk();
                    break;

                case "help":
                    HelpMenu();
                    break;

                case "exit":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Unknown command, type 'help' for commands");
                    break;
            }
        }

        void ListPets()
        {

            //Chat GPT formaterte listen for oss :)
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10}", "Index", "Name", "Age", "Hunger", "Happiness");
            Console.WriteLine(new string('-', 50));

            for (int i = 0; i < Pets.Count; i++)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10}",
                    i,
                    Pets[i].Name,
                    Pets[i].Age,
                    Pets[i].Hunger,
                    Pets[i].Happines);
            }

            Console.WriteLine(new string('-', 50));
        }


        void ChoosePet()
        {
            Console.Write("Choose Index : ");
            int userIndex = Convert.ToInt32(Console.ReadLine());
            currentPet = Pets[userIndex];

            Console.WriteLine($"You have chosen {currentPet.Name}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"They are {currentPet.Happines}% happy");
            Console.WriteLine();
            Console.WriteLine($"They are {currentPet.Hunger}% hangry");
            Console.WriteLine();
            Console.WriteLine($"Do they need to potty? {currentPet.PottyTime}");
        }


        void HelpMenu()
        {
            Console.WriteLine("'help - list commands'");
            Console.WriteLine("'exit' - exit application");
            Console.WriteLine("'choose' choose index of pet you want to interact with");
            Console.WriteLine("'feed' - feed current pet");
            Console.WriteLine("'walk' - Go potty with your pet");
            Console.WriteLine("'play' - play with current pet");
        }



        void FeedPet()
        {

            if (currentPet.Hunger > 0)
            {
                currentPet.Hunger -= 15;
                Console.WriteLine($"{currentPet.Name} has now {currentPet.Hunger} in hunger.");
            }
        }

        void Play()
        {
            Console.WriteLine("Play ball");
            Console.WriteLine("Throw stick");
            Console.Write("What do you want to do? (stick / ball) : ");
            var userInput = Console.ReadLine().ToLower();
            if (userInput == "stick" && currentPet.Happines < 100)
            {
                currentPet.Happines += 20;
                Console.WriteLine($"{currentPet.Name} caught the stick and is now {currentPet.Happines}% happy");
            }
            else if (userInput == "ball" && currentPet.Happines < 100)
            {
                currentPet.Happines += 30;
                Console.WriteLine($"{currentPet.Name} caught the ball and is now {currentPet.Happines}% happy");
            }
            else if (currentPet.Happines > 100)
            {
                Console.WriteLine($"{currentPet.Name} is already {currentPet.Happines}% happy sending you back too menu");
                return;
            }
            else if (userInput == "back")
            {
                return;
            }
            else
            {
                Console.WriteLine("unknown command, returning to menu");
                return;
            }

        }

        void Walk()
        {
            Console.WriteLine("Go for a Walk?");
            Console.Write("Yes/No : ");
            var userInput = Console.ReadLine().ToLower();
            if (userInput == "yes" && currentPet.PottyTime == true)
            {
                currentPet.PottyTime = false;
                return;
            }
            else if (userInput == "yes" && currentPet.PottyTime == false)
            {
                Console.WriteLine($"{currentPet.Name} Does not need a walk! >:( fuck u we`re returning to menu! (biatch)");
                return;
            }
            else if (userInput == "no")
            {
                return;
            }
            else
            {
                Console.WriteLine("unknown command, returning to menu");
                return;
            }
        }
        
    }
    
}