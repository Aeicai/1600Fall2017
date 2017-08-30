using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avian : Animal {

    public override void Start() {
        base.Start();
        Fly();
}

    void Fly () {
        print(this.name + " Flies");
    }

}