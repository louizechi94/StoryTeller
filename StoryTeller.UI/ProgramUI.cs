    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using StoryTeller.Data;
    using StoryTeller.Repository;

    namespace StoryTeller.UI
    {
        public class ProgramUI
        {
            private readonly characterRepository _cRepo = new characterRepository();
            private readonly worldRepository _wRepo = new worldRepository();
            private readonly itemRepository _iRepo = new itemRepository();

            Character humpty;
            Character wizzard;
            Character king;
            Character princess;
            Character speckeledHen;
            bool isRunning = true;
            public ProgramUI()
            {
                humpty = _cRepo.GetCharacterByID(1);
                wizzard = _cRepo.GetCharacterByID(2);
                king = _cRepo.GetCharacterByID(3);
                princess = _cRepo.GetCharacterByID(4);
                speckeledHen = _cRepo.GetCharacterByID(5)!;
            }
            public void Run()
            {
                RunApplication();
            }

            private void RunApplication()
            {
                
                while(isRunning)
                {
                    Console.Clear();
                    System.Console.WriteLine("Welcome to the Adventure!\n"+
                    "what do you want to do ?\n"+
                    "1. Go on an Adventure!\n"+
                    "2. Quit Game");
                    var userInput = Console.ReadLine();
                    switch(userInput)
                    {
                        case "1":
                        StartAdventure(); 
                        break;
                        case "2":
                        isRunning = QuitGame();
                        break; 
                        default:
                        System.Console.WriteLine("Invalid input.");
                        break;
                    }
                }
            }
            private void StartAdventure()
            {
                Console.Clear();
                System.Console.WriteLine(@$"Adventure Started!
                                            {humpty.Name} sat on a wall,
                                            {humpty.Name}  had a great fall.
                                            All {king.Name} horses And all {king.Name} men
                                            Cannot put {humpty.Name}  together again.
                                            A {speckeledHen.Name} had made her nest in an out-of-the-way place to sit upon the eggs until they were hatched into chickens.
                                            The  {speckeledHen.Name} name each egg by the name it should be called when a chick.
                                            {humpty.Name} is kicked out of the nest and seen outside the barn door.
                                            {humpty.Name} and Coutchie-Coulou go out to see the world together.
                                            {humpty.Name} helps Coutchie-Coulou out of the nest.
                                            {humpty.Name} and Coutchie-Coulou jumped, alighting safely in the roadway. 
                                            {humpty.Name} and Coutchie-Coulou ran to a high stone wall and found a hole to crawl through.
                                            {humpty.Name} and Coutchie-Coulou visit a beautiful garden and palace, where they see birds swimming in the water.
                                            {humpty.Name} is a large egg with a name of his own.
                                            {princess.Name} promises to show him around the grounds and palace.
                                            {princess.Name} took {humpty.Name} to the palace gates, where he saw {king.Name} riding home with his horses and men.
                                            {king.Name} arrived, {humpty.Name} was crushed and mangled, and the {princess.Name} returned thoughtfully to the palace.
                                            {king.Name} chose a slender, fair-haired youth to marry {princess.Name}, but he failed to guess a riddle that {king.Name} could guess.");
                // method that calls 
                isRunning = QuitGame();
                Console.ReadKey();
            }


            private bool QuitGame()
            {
                System.Console.WriteLine("Thanks for playing, press any key to continue.");
                Console.ReadKey();
                return false;
            }

        }
    }
