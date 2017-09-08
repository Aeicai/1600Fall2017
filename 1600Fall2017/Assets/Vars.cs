using UnityEngine;

public class Vars : MonoBehaviour {

    public float health = 100;

	// Use this for initialization
	void Start () {
        health = 200;
		
	}

    private void OnTriggerEnter(Collider other)
    {
        health += 20;
 
	}
}
