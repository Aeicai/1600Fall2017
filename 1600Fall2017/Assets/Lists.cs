using System.Collections.Generic;
using UnityEngine;
using System;

public class Lists : MonoBehaviour {

	public List<GameObject> myWeapon;
	
	
	void OnTriggerEnter(Collider _weapon)
    {
        myWeapon.Add(_weapon.gameObject);	
	}
}
