using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller
{
    public class RPSgame : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public RPSgame(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {

           // bool newgame = true;

            try
            {

                var gameLoop = true;
                int userPoints = 0;
                int computerPoints = 0;
                while (gameLoop)
                {
                    Console.WriteLine("Hello and welcome to my Rock, Paper, Scissors game. Please enter a number below for your choice and press enter:");

                    Console.WriteLine("1.Rock");
                    Console.WriteLine("2.Paper");
                    Console.WriteLine("3.Scissors");
                    var userChoice = Convert.ToInt32( Console.ReadLine());
                    Random randomChoice = new Random();
                    int computerChoice = randomChoice.Next(1, 4);
                    //switch (computerChoice)
                    //{
                    //    case 1:
                    //        break;
                    //    case 2:
                    //        break;
                    //    case 3:
                    //        break;
                    //}
                    if (userChoice >= 4) { Console.WriteLine("invalid input going back to game menu"); }

                    if (userChoice == computerChoice)
                    {

                        Console.Clear();
                        //this is a tie
                        Console.WriteLine("User chose " + userChoice);
                        Console.WriteLine("Computer chose " + computerChoice);
                        Console.WriteLine("It is a tie.");
                        Console.WriteLine("vill fortsätta spela Y/N ?");
                        var yn = Console.ReadLine().ToLower();
                        if (yn == "y" || yn == "yes") { Console.WriteLine("keep playing:"); }
                        else if (yn == "n" || yn == "no") { Console.WriteLine("going back to main menu site"); break; }
                        else { Console.WriteLine("invalid input going back to game menu"); }

                    }


                    if (userChoice == 1 && computerChoice == 3 || userChoice == 2 && computerChoice == 1 || userChoice == 3 && computerChoice == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("User chose " + userChoice);
                        Console.WriteLine("Computer chose " + computerChoice);
                        Console.WriteLine("User wins");
                        string win = "YOU WIN";
                        var dt = DateTime.Now;
                        userPoints++;
                        dbContext.RPSGAMEs.Add(new RPSGAME 
                        {
                            Scoure = win,
                            Date= dt
                        });
                        dbContext.SaveChanges(); 
                        Console.WriteLine("vill fortsätta spela Y/N eller yes/no ?");
                        var yn = Console.ReadLine().ToLower();
                        if (yn == "y" || yn == "yes") { Console.WriteLine("keep playing:"); }
                        else if (yn == "n" || yn == "no") { Console.WriteLine("going back to main menu site"); break; }
                        else { Console.WriteLine("invalid input going back to game menu");  }
                    }


                    if (computerChoice == 1 && userChoice == 3 || computerChoice == 2 && userChoice == 1 || computerChoice == 3 && userChoice == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("User chose " + userChoice);
                        Console.WriteLine("Computer chose " + computerChoice);
                        Console.WriteLine("Computer wins");
                        Console.WriteLine("you los");
                        computerPoints++;
                        string los = "YOU LOS";
                        var dt1 = DateTime.Now;
                        userPoints++;
                        dbContext.RPSGAMEs.Add(new RPSGAME
                        {
                            Scoure = los,
                            Date = dt1
                        });
                        dbContext.SaveChanges();
                        Console.WriteLine("vill fortsätta spela Y/N ?");
                        var yn = Console.ReadLine().ToLower();
                        if (yn == "y" || yn == "yes") { Console.WriteLine("keep playing:"); }
                        else if (yn == "n" || yn == "no") { Console.WriteLine("going back to main menu site"); break; }
                        else { Console.WriteLine("invalid input going back to game menu"); }
                    }
                }


                //while (newgame)
                //{
                //    Console.Clear();
                //    Console.WriteLine("start the game ");
                //    Console.WriteLine("===================");
                //    Console.WriteLine("1- rock");
                //    Console.WriteLine("2- paper");
                //    Console.WriteLine("3- scissors");
                //    Console.WriteLine("choose betwen 1-3");
                //    var playerchoice = Convert.ToInt32(Console.ReadLine());
                //    Random random1 = new Random();
                //    var computerrandom = random1.Next(1, 4);

                //    if (playerchoice > 0 && playerchoice < 4 && computerrandom > 0 && computerrandom < 4)
                //    {
                //        Console.WriteLine("DRAW!");
                //     Console.WriteLine("press");
                //     Console.ReadLine();

                //    }
                //    else if (playerchoice == 1 && playerchoice < 4 && computerrandom == 3 && computerrandom < 4)
                //    {
                //        Console.WriteLine("YOU WIN!");
                //        String scoure = "You win:";
                //        var DT = DateTime.Now;
                //        dbContext.RPSGAMEs.Add(new RPSGAME
                //        {
                //            Scoure = scoure,
                //            Date = DT
                //        });
                //        dbContext.SaveChanges();
                //      Console.WriteLine("press");
                //       Console.ReadLine();
                //     }
                //    else if (playerchoice == 2 && playerchoice < 4 && computerrandom == 1 && computerrandom < 4)
                //    {
                //        Console.WriteLine("you win"); String scoure = "You win:";
                //        var DT = DateTime.Now;
                //        dbContext.RPSGAMEs.Add(new RPSGAME
                //        {
                //            Scoure = scoure,
                //            Date = DT
                //        });
                //        dbContext.SaveChanges();
                //        Console.WriteLine("press");
                //         Console.ReadLine();
                //    }
                //    else if (playerchoice == 3 && playerchoice < 4 && computerrandom == 1 && computerrandom < 4)
                //    {
                //        Console.WriteLine("YOU win."); String scoure = "You win:";
                //        var DT = DateTime.Now;
                //        dbContext.RPSGAMEs.Add(new RPSGAME
                //        {
                //            Scoure = scoure,
                //            Date = DT
                //        });
                //        dbContext.SaveChanges();
                //        Console.WriteLine("press");
                //          Console.ReadLine();
                //    }
                //    else { Console.WriteLine("YOU LOS!"); String scoure = "You LOs:";
                //        var DT = DateTime.Now;
                //        dbContext.RPSGAMEs.Add(new RPSGAME
                //        {
                //            Scoure = scoure,
                //            Date = DT
                //        });
                //        dbContext.SaveChanges();
                //      Console.WriteLine("press");
                //       Console.ReadLine();
                //    }
                ////while (newgame == true) 
                ////{
                ////    Console.WriteLine("vill du fortsätta Y/N");
                ////    var answer = Console.ReadLine().ToLower();
                ////    if (answer == "Y") {  }


                ////}


                //    //break;
                //}



            }
            catch (Exception) { Console.WriteLine("invalid input going back to Main Menu Site."); Console.ReadLine(); }
        }
       


    }
}
