using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.AttributeUsage(System.AttributeTargets.Field)]
public class PotionSelectorAttribute : PropertyAttribute
{
}

public class TestBehaviour : MonoBehaviour
{

	[PotionSelectorAttribute]
	public string potionName;
	Potion[] here;

	public void Start()
	{
		//here = PotionDB.instance.potions;
		Debug.Log(potionName);
		for(int a = 0; a < PotionDB.instance.potions.Length; a ++){
			if(potionName == PotionDB.instance.potions[a].name){
			Debug.Log(PotionDB.instance.potions[a].heal);
			}

		}


	}

}
