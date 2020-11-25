using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game State
    public int level;
    public enum Screen { MainMenu, WaitingForPassword, Win }


    public Screen currentScreen = Screen.MainMenu;

    private string[] validPasswords = { "apple", "nate" };

    void Start()
    {
        ShowMainMenu("Hello Nate");
    }

    void ShowMainMenu(string greeting)
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for the NASA");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu("Hello Nate");
        }
        else if (currentScreen == Screen.MainMenu)
        {
            EmitMenuSelection(input);
        }
        else if (currentScreen == Screen.WaitingForPassword)
        {

            CheckPassword(input);
        }
    }

    void CheckPassword(string input)
    {
        if (input == validPasswords[level - 1])
        {
            Terminal.WriteLine("Congratulations, that is correct.");
            ShowMainMenu("Hello Nate, Nice, you passed level " + level);
        }
        else
        {
            Terminal.WriteLine("Incorrect Password.");
        }
    }

    private void EmitMenuSelection(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Please select a level Mr. Bond!");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.WaitingForPassword;
        Terminal.WriteLine("You have chose level " + level);
        Terminal.WriteLine("Please Enter Your Password:");
    }
}
