using System;

public class Program
{
    static void Main()
    {
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";

        const string AskName = "Input your wizard's name: ";
        const string WrongName = "You must name your wizard.";
        const string TrainingOutput = "Day {0} -> {1}, you already meditated {2} hours and your power now is {3} points!";
        const string TitleFail = "You fail. To second call.";
        const string TitleBasic = "You still mistake a wand with a spoon.";
        const string TitleMedium = "You're a Magic Wind Summoner.";
        const string TitleHigh = "Wow! You can summon dragons without burning the lab!";
        const string TitleAdvanced = "You assumed Arcanes Master's rank!";

        int op = 0;
        bool validInput;

        int level = 1;
        int meditationDays = 5;
        int newPoints;
        int totalPoints = 0;
        string title;
        string name;

        Random rnd = new Random();

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            validInput = true;

            try
            {
                op = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }

            if (validInput)
            {
                Console.WriteLine(op);
            }

            switch (op)
            {
                case 1:
                    do
                    {
                        Console.WriteLine(AskName);
                        name = Console.ReadLine();

                        if (string.IsNullOrEmpty(name))
                        {
                            Console.WriteLine(WrongName);
                        }
                    } while (string.IsNullOrEmpty(name));

                    for (int i = 1; i <= meditationDays; i++)
                    {
                        newPoints = rnd.Next(1, 11);
                        totalPoints += newPoints;
                        Console.WriteLine(TrainingOutput, i, name, newPoints, totalPoints);
                    }

                    switch (totalPoints)
                    {
                        case >= 40:
                            Console.WriteLine(TitleAdvanced);
                            title = "ITB - Wizard the Gray";
                            break;
                        case >= 35:
                            Console.WriteLine(TitleHigh);
                            title = "Elarion of the Embers";
                            break;
                        case >= 30:
                            Console.WriteLine(TitleMedium);
                            title = "Arka Nullpointer";
                            break;
                        case >= 20:
                            Console.WriteLine(TitleBasic);
                            title = "Zyn the Bugged";
                            break;
                        case < 20:
                            Console.WriteLine(TitleFail);
                            title = "Raoden the Elantry";
                            break;

                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine(InputErrorMessage);
                    break;
            }

        } while (op != 0);
    }

}