using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {
    public string[] foxFood = { "Bananas", "Apples", "Grapes", "Chicken", "Turkey", "Cake" };

    pubblic int[] foodCount = { 10, 2, 30, 1, 2, 1};

    public virtual void Start () {
        Die();

        for (int i = 0 < foxFood.Length; i++);
        {
            Eat(foxFood[i], FoodCount[i]);
        }

        Sleep();
    
    }
	void Die(){
        print(this.name + " Dies");
    }
    void Eat(string food, int amount)
    {
        print(this.name + " likes to eat " + food);
        print(this.name + " ate " + amount);
    }
    void Sleep()
    {
        print(this.name + " Sleeps ");
    }
}
