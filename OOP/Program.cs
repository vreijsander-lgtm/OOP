using OOP.Models;
using OOP.Models.Soort_mens;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

class Program
{
    public static List<mens> MensLijst = new List<mens>();
    public static List<mens> BannedList = new List<mens>();
    static void Main(string[] args)
    {
        Start();
    }
    static void Start()
    {
        Console.WriteLine("Welcome to Staem!");
        klant Erwin = new klant("ErwinGamet", 1, "1234", "erwinemail@gmail.com", 1);
        medewerker Sander = new medewerker(1, 13445, "4321", "sanderBoss@gmail.com");
        Erwin.usertype = OOP.enums.UserType.Klant;
        Sander.usertype = OOP.enums.UserType.Medewerker;
        MensLijst.Add(Sander);
        MensLijst.Add(Erwin);
        
        while (true)
        {
            Console.WriteLine("Log in? or create account? (C/L)");
            string option_login = Console.ReadLine();
            if (option_login == "Login" || option_login == "L" || option_login == "l" || option_login == "Log in")
            {
                Console.WriteLine("Email:");
                string TypedEmail = Console.ReadLine();
                Console.WriteLine("Password:");
                string TypedPassword = Console.ReadLine();
                bool found = false;
                foreach (mens human in MensLijst)
                {
                        if (human.email == TypedEmail && human.wachtwoord == TypedPassword)
                        {
                            Console.WriteLine("Login successfully!");
                            //ADMIN
                            if (human.usertype == OOP.enums.UserType.Medewerker)
                            {
                            medewerker loggedInAsAdmin = (medewerker)human;
                                Console.WriteLine("You are a Admin");
                                Console.WriteLine("What do you wanna do");
                                Console.WriteLine("1) Ban user");
                                Console.WriteLine("2) Unban user");
                                Console.WriteLine("3) Delete game");
                                Console.WriteLine("4) Add game to user");
                                Console.WriteLine("5) Remove game from user");
                                string Awnser = Console.ReadLine();
                                if (Awnser == "1")
                            {
                                loggedInAsAdmin.ban_user(MensLijst, BannedList);
                            }
                                

                            }
                            //CUSTOMMER
                            else if (human.usertype == OOP.enums.UserType.Klant)
                            {
                                Console.WriteLine("You are a Custommer");
                            }
                            //PROGRAMMER
                            else if (human.usertype == OOP.enums.UserType.GameDev)
                            {
                                Console.WriteLine("You are a Game dev");
                            }
                            //WRONG INPUT
                            else
                            {
                                Console.WriteLine("Bro tf you doin");
                            }
                                found = true;
                            break;
                        }
                    
                }
                if (!found)
                {
                    Console.WriteLine("Wrong email/Password");
                    Console.WriteLine(MensLijst);
                }

            }
            else if (option_login == "Create" || option_login == "C" || option_login == "c" || option_login == "Create account" || option_login == "create account" || option_login == "Create Account")
            {
                Create_account();
            }
            else
            {
                Console.WriteLine("Wrong input try again!");
            }
        }
        
    }
    static void Create_account()
    {

        bool Are_You_dev = false;
        Console.WriteLine("Name:");
        string TypedName = Console.ReadLine();
        Console.WriteLine("Username:");
        string TypedUsername = Console.ReadLine();
        Console.WriteLine("Email:");
        string TypedEmail = Console.ReadLine();
        Console.WriteLine("Password:");
        string TypedPassword = Console.ReadLine();
        klant CreateAccount = new klant(TypedUsername, 1, TypedPassword, TypedEmail);
        MensLijst.Add(CreateAccount);
        Console.WriteLine("Succesfully created a account!");
    }
}

    

    