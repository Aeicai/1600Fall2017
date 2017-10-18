using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour {
    string thing1 = "Thing1";
    string thing2;

    void Box () {
        thing1 = "Fun";
        string thing2 = "things it can't do. What it can't do, is get out of the box. It's Sad, oh so sad";
        print(thing2);

    }

    void NewBox () {
        thing1 = "New Thing.";
        thing2 = "New Thing Too.";
    }
}
