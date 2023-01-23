/* menu {
 * wybór gier
 * {tic tac toe, Master mind, rock paper scisors, zgadnij moją liczbe}
 * instruction
 * {wybór gier, jak grać w gry , wyjście}
 * exit}
 * 
 * tic tac toe gra gdzie masz tablice 3x3 wybierasz na przemien ty i pc gdzie kładziesz X pc będzie O nie wybrane pola będą zaznaczone cyframi gracz będzie wybierać cyfry
 * 
 * master mind 6 pól 8 piłek do wybrania odpowiednimi znakami od 1 do 8 pc mówi tylko te które są kolory i że zgadł połorzenie ilościowo nie które jest poprawne
 * 
 * rock paper scisors wybierasz papier kamień norzyce pc także wybiera po zapisaniu pisze co on ma i co ty masz i kto wygrał
 * 
 * zgadnij pc wybiera liczbę od 1 do 100 piszesz liczbę pc pisze czy wybrał mniejszą czy większą
 * 
 * każda gra jest punktowana z każdej gry po parti możesz wyjść oraz ilość wygranych przegranych zremisowanych zostaje zapisana z każdej gry
 * */


using System.ComponentModel;
using System.ComponentModel.Design;
using WyborGier;

namespace WyborGier
{
    public abstract class Gra
    {
        public abstract void Start();
    }


    public class program
    {

        static void Main(string[] args)
        {
            int wybor = 0;
            Gra gra = null;
            do
            {
                Console.Clear();
                Console.WriteLine("=======================================================");
                Console.WriteLine("Menu");
                Console.WriteLine("");
                Console.WriteLine("1:selection of Games");
                Console.WriteLine("");
                Console.WriteLine("2:Instruction");
                Console.WriteLine("");
                Console.WriteLine("3:Exit");
                Console.WriteLine("");
                Console.WriteLine("Please choose a number from the selection");
                do
                {
                    bool Men = int.TryParse(Console.ReadLine(), out wybor);
                    switch (wybor)
                    {
                        case 1:
                            gra = new Wyborgry();
                            break;
                        case 2:
                            gra = new Instruction();
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("You didn't choose the correct option!");
                            break;
                    }
                    if (wybor >= 1 && wybor <= 3)
                    {
                        break;
                    }
                } while (true);
                gra?.Start();
            } while (wybor != 3);
        }
    }
    public class Instruction : Gra
    {
        public override void Start()
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("Instruction");
            Console.WriteLine("");
            Console.WriteLine("MasterMind you are to guess the order from 1 to 6 from a pool of 1 to 8 selected by EI");
            Console.WriteLine("");
            Console.WriteLine("RockPaperScissors your task is to beat EI in the choice of paper stone scissors");
            Console.WriteLine("");
            Console.WriteLine("Find my number your task is to guess the number");
            Console.WriteLine("");
            Console.WriteLine("Press the button to return to the Menu");
            Console.ReadLine();
        }
    }
    public class Wyborgry : Gra
    {
        public override void Start()
        {
            Console.Clear();
            int wybor = 0;
            Gra gra = null;
            Console.WriteLine("=======================================================");
            Console.WriteLine("Game selector");
            Console.WriteLine("");
            Console.WriteLine("1:MasterMind");
            Console.WriteLine("");
            Console.WriteLine("2:RockPaperScissors");
            Console.WriteLine("");
            Console.WriteLine("3:FindMyNumber");
            Console.WriteLine("");
            Console.WriteLine("4:Menu");
            Console.WriteLine("");
            Console.WriteLine("Please choose a number from the selection");
            do
            {
                bool Men = int.TryParse(Console.ReadLine(), out wybor);
                switch (wybor)
                {
                    
                    case 1:
                        gra = new Mastermind();
                        break;
                    case 2:
                        gra = new RockPaperScis();
                        break;
                    case 3:
                        gra = new Liczba();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("You didn't choose the correct option!");
                        break;
                }
                if (wybor >= 1 && wybor <= 5)
                {
                    break;
                }
            } while (true);

            gra?.Start();
        }
    }

    public class Mastermind : Gra
    {
        public override void Start()
        {
           
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome in Mastermind");
                Console.WriteLine("Select number from 1 to 4");
                Console.WriteLine("");
                int licznik = 0;
                int[] tab = new int[4];
                Random gen = new Random();
                int i = 0;
                while (i < 4)
                {
                    int random_num = gen.Next(1, 5);
                    if (!tab.Contains(random_num))
                    {
                        tab[i] = random_num;
                        i++;
                    }
                }
                int win = 0;
                int tre = 0;
                int first = 0;
                int[] chosen = new int[4];
                int koniec = 0;
                do
                {
                    tre++;
                    do
                    {
                        Console.WriteLine("choose your first number");
                        bool rozw = int.TryParse(Console.ReadLine(), out first);
                        if (rozw == false)
                        {
                            Console.WriteLine("you dont choose number");
                        }
                        else if (first <= 4 && first >= 1)
                        {
                            chosen[0] = first;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("not a correct number");
                        }
                    } while (true);

                    do
                    {
                        Console.WriteLine("choose your second number");
                        bool rozw = int.TryParse(Console.ReadLine(), out first);
                        if (rozw == false)
                        {
                            Console.WriteLine("you dont choose number");
                        }
                        else if (first <= 4 && first >= 1)
                        {
                            chosen[1] = first;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("not a correct number");
                        }
                    } while (true);

                    do
                    {
                        Console.WriteLine("choose your third number");
                        bool rozw = int.TryParse(Console.ReadLine(), out first);
                        if (rozw == false)
                        {
                            Console.WriteLine("you dont choose number");
                        }
                        else if (first <= 4 && first >= 1)
                        {
                            chosen[2] = first;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("not a correct number");
                        }
                    } while (true);

                    do
                    {
                        Console.WriteLine("choose your fourth number");
                        bool rozw = int.TryParse(Console.ReadLine(), out first);
                        if (rozw == false)
                        {
                            Console.WriteLine("you dont choose number");
                        }
                        else if (first <= 4 && first >= 1)
                        {
                            chosen[3] = first;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("not a correct number");
                        }
                    } while (true);

                    if (tab[0] == chosen[0])
                    {
                        Console.WriteLine("First number is correct");
                    }

                    if (tab[1] == chosen[1])
                    {
                        Console.WriteLine("Second number is correct");
                    }

                    if (tab[2] == chosen[2])
                    {
                        Console.WriteLine("Third number is correct");
                    }

                    if (tab[3] == chosen[3])
                    {
                        Console.WriteLine("Fourth number is correct");
                    }

                    if (tab[0] == chosen[0] && tab[1] == chosen[1] && tab[2] == chosen[2] && tab[3] == chosen[3])
                    {
                        win = 1;
                        break;
                    }

                } while (tre != 8);

                Console.Clear();

                if (win == 1)
                {
                    
                    Console.WriteLine("Bravo you win it took you " + tre + " attempts");
                }

                else if (win == 0)
                {
                    Console.WriteLine("Game Over Try next time");
                }

                Console.WriteLine("");
                Console.WriteLine("do you want to play again?");
                Console.WriteLine("");
                Console.WriteLine("1:Yes");
                Console.WriteLine("");
                Console.WriteLine("2:Back to Menu");

                do
                {
                    bool wyj = int.TryParse(Console.ReadLine(), out koniec);
                    if (koniec == 1 || koniec == 2)
                    {
                        break;
                    }
                } while (true);
                if (koniec == 2)
                {
                    Console.WriteLine("Thank you for playing");
                    break;
                }
            } while (true);
        }
    }

    public class RockPaperScis : Gra
    {
        public override void Start()
        {
            int player = 0;
            int pc = 0;
            int remis = 0;
            int bplay = 0;
            int koniec = 0;

            do
            {
                do
                {
                    int first = 0;
                    Random generator = new Random();
                    int apc = generator.Next(1, 4);
                    Console.Clear();
                    Console.WriteLine("1 is scisores");
                    Console.WriteLine("2 is paper");
                    Console.WriteLine("3 is rock");
                    do
                    {
                        Console.WriteLine("choose your first number");
                        bool rozw = int.TryParse(Console.ReadLine(), out first);
                        if (rozw == false)
                        {
                            Console.WriteLine("you dont choose number");
                        }
                        else if (first <= 3 && first >= 1)
                        {
                            bplay = first;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("not a correct number");
                        }
                    } while (true);
                    if (apc == 1 && bplay == 1 || apc == 2 && bplay == 2 || apc == 3 && bplay == 3)
                    {
                        remis++;
                        Console.WriteLine("draw");
                        break;
                    }
                    else if (apc == 1 && bplay == 3 || apc == 2 && bplay == 1 || apc == 3 && bplay == 2)
                    {
                        player++;
                        Console.WriteLine("YOU WIN");
                        break;
                    }
                    else if (apc == 3 && bplay == 1 || apc == 1 && bplay == 2 || apc == 2 && bplay == 3)
                    {
                        pc++;
                        Console.WriteLine("YOU LOSSE");
                        break;
                    }
                } while (true);
                Console.WriteLine("====================================");
                Console.WriteLine("");
                Console.WriteLine("WIN = " + player);
                Console.WriteLine("DRAW = " + remis);
                Console.WriteLine("LOSSE = " + pc);
                Console.WriteLine("");
                Console.WriteLine("====================================");
                Console.WriteLine("");
                Console.WriteLine("do you want to play again?");
                Console.WriteLine("");
                Console.WriteLine("1:Yes");
                Console.WriteLine("");
                Console.WriteLine("2:Back to Menu");

                do
                {
                    bool wyj = int.TryParse(Console.ReadLine(), out koniec);
                    if (koniec == 1 || koniec == 2)
                    {
                        break;
                    }
                } while (true);
                if (koniec == 2)
                {
                    Console.WriteLine("Thank you for playing");
                    break;
                }
            } while (true);
        }
    }

    public class Liczba : Gra
    {
        public override void Start()
        {
            Console.WriteLine("Welcome in Find my number");
            do
            {
                Console.Clear();
                int koniec = 0;
                int liczba = 0;
                int licznik = 0;
                Console.WriteLine("A random number will be selected from 0 to 100");
                Random generator = new Random();
                int random = generator.Next(100);
                do
                {
                    do
                    {
                        bool czyliczba = int.TryParse(Console.ReadLine(), out liczba);
                    } while (liczba <= 1 && liczba >= 100);
                    Console.WriteLine("your number is " + liczba);
                    if (liczba < random)
                    {
                        Console.WriteLine("My number is higher");
                    }
                    else if (liczba > random)
                    {
                        Console.WriteLine("My number is less");
                    }
                    licznik++;
                    Console.WriteLine("==================================");
                } while (liczba != random);
                Console.WriteLine("Bravo you guessed my count it took you " + licznik + " attempts");
                Console.WriteLine("");
                Console.WriteLine("do you want to play again?");
                Console.WriteLine("");
                Console.WriteLine("1:Yes");
                Console.WriteLine("");
                Console.WriteLine("2:Back to Menu");
                do
                {
                    bool wyj = int.TryParse(Console.ReadLine(), out koniec);
                    if (koniec == 1 || koniec == 2)
                    {
                        break;
                    }
                } while (true);
                if (koniec == 2)
                {
                    Console.WriteLine("Thank you for playing");
                    break;
                }
            } while (true);
        }
    }
}