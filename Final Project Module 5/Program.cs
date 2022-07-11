namespace FinalProject {
    class Program {
        static void Main() {
            (string name, string lastName, int age, bool havePet, string[] petNames, string[] favColors) = Anketa();
            PrintAnketa(name, lastName, age, havePet, petNames, favColors);
            

        }

        static (string name, string lastName, int age, bool havePet, string[] petNames, string[] favColors) Anketa()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("How old are you? ");
            int age = Correction();

            Console.WriteLine("Do you have pets? Y/N ");
            bool havePet = false;
            string check = Console.ReadLine();
            if (check == "Y")
                havePet = true;

            string[] petNames = {"None"};

            if (havePet == true)
            {
                Console.Write("How many pets do you have? ");
                int petCount = Correction();
                petNames = GetPetNames(petCount);
            }

            Console.Write("How many colors do you like? ");
            int colorsCount = Correction();
            string[] favColors = GetFavColors(colorsCount);

            return (name, lastName, age, havePet, petNames, favColors);
        }

        static void PrintAnketa(string name, string lastName, int age, bool havePet, string[] petNames, string[] favColors)
        {
            Console.WriteLine("Your name is {0} {1}. You are {2} years old.", name, lastName, age);
            if (havePet == true)
                if (petNames.Length == 1)
                    Console.WriteLine("You have a beautiful pet called {0}", petNames[0]);
                else
                {
                    Console.Write("You have {0} beautiful pets called: ");
                    PrintArray(petNames);
                }
            Console.Write("Your favourite colos are: ");
            PrintArray(favColors);


        }

        static string[] GetPetNames(int number) {
            string[] petNames = new string[number];
            for (int i = 0; i < number; i++) {
                Console.Write("Enter your {0} pet's name: ", i+1);
                petNames[i] = Console.ReadLine();
            }
            return petNames;
        }

        static void PrintArray(string[] array)
        {            
            foreach (string el in array)
                Console.Write(el + " ");
        }

        static string[] GetFavColors(int number)
        {
            string[] favColors = new string[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter your {0} favourite color: ", i + 1);
                favColors[i] = Console.ReadLine();
            }
            return favColors;
        }

        static int Correction()
        {
            int check;

            do
            {
                check = int.Parse(Console.ReadLine());
                if (check <= 0)
                    Console.WriteLine("Repeat, please");                
            }
            while (check <= 0);
            
            return check;
        }
    }
}