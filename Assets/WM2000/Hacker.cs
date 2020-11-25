using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu() 
    {
        Terminal.ClearScreen();

        string greeting = "Hello Nate";
        Terminal.WriteLine(greeting);

        Terminal.WriteLine("What would you like to hack into?");
        
        Terminal.WriteLine("");
        
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for the NASA");

        Terminal.WriteLine("Enter your selection:");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
