using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour {

	public Lists<GameObject> myWeapon;
	
	
	void OnTriggerEnter(Collider _weapon)
    {
        myWeapons.Add(_weapon.gameObject);	
	}
}
