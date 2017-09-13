using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfStatement : MonoBehaviour {


    public Text input;
    public string password = "G@m3Pl@y";
    public bool canPlayGame;
	
	
	void Update () {
        if (input.text == password)
        {
            print("You know the password.");
            canPlayGame = true;
        } else {
            print("The password is incorrect.");
        }
        if (canPlayGame)
        {
            print("Playing Game");
        }   else {
            print("Can't Play Yet, Enter a Correct Password.");
        }
	}
}
