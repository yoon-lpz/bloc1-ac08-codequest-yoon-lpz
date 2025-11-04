using System;
using System.Globalization;

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

        const string DoorMessage = "You're at door {0}. You have {1} try left to guess the code (1-5)";
        const string DoorWrongInput = "Invalid input. Please enter a number between 1 and 5.";
        const string DoorWrong = "Wrong code";
        const string DoorFail = "The dragon has detected your presence and has expelled you from the server!";
        const string DoorGuessed = "The dragon respects you. You have unlocked the next level!";
        const string DoorWin = "You have unlocked the final level. Prepare for battle!";

        const string ExcavationDay = "Day {0}";
        const string ExcavationZero = "Today's not your lucky day, you got 0 bits.";
        const string ExcavationSmth = "You got {0} bits";
        const string ExcavationWin = "You've unlocked gold GPU! Your spells now run at 120 FPS!";
        const string ExcavationFail = "Your magic card is still integrated. It's time to defeat another dragon!";

        int op = 0;
        bool validInput;

        int level = 1;
        int meditationDays = 5;
        int newPoints;
        int totalPoints = 0;
        string title;
        string name;

        int code;
        int codeTry = 0;
        int numPortes = 3;
        int intent = 3;
        bool doorValid;
        bool dungeonValid;

        int excavations = 5;
        int bits = 0;
        int currentBits;

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
                validInput = false;
            }
            catch (Exception)
            {
                validInput = false;
            }
            if (!validInput) {
                Console.WriteLine(InputErrorMessage);

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
                    dungeonValid = true;
                    for (int i = 1; i <= numPortes && dungeonValid; i++)
                    {
                        code = rnd.Next(1, 6);
                        doorValid = false;
                        validInput = true;
                        for (int o = intent; o > 0 && !doorValid; o--)
                        {
                            Console.WriteLine(DoorMessage, i, o);

                            try
                            {
                                codeTry = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine(DoorWrongInput);
                                validInput = false;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine(DoorWrongInput);
                                validInput = false;
                            }

                            Console.WriteLine(validInput && codeTry == code ? DoorGuessed : DoorWrong);
                            doorValid = validInput && codeTry == code;
                        }
                        dungeonValid = doorValid;
                    }
                    Console.WriteLine(dungeonValid ? DoorWin : DoorFail);
                    break;
                case 3:
                    for (int i = 1; i <= excavations; i++)
                    {
                        Console.WriteLine(ExcavationDay, i);

                        currentBits = rnd.Next(4, 51);
                        currentBits = currentBits == 4 ? 0 : currentBits;
                        Console.WriteLine(currentBits == 0 ? ExcavationZero : ExcavationSmth, currentBits);
                        bits += currentBits;
                    }

                    Console.WriteLine(bits >= 200 ? ExcavationWin : ExcavationFail);
                    break;
                default:
                    Console.WriteLine(InputErrorMessage);
                    break;
            }

        } while (op != 0);
    }

}