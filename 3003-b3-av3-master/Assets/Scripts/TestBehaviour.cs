using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
[System.AttributeUsage(System.AttributeTargets.Field)]
public class PotionSelectorAttribute : PropertyAttribute
{
}

public class TestBehaviour : MonoBehaviour
{

	[PotionSelectorAttribute]
	public string potionName;

	public void Start()
	{

		Debug.Log(potionName);
		for(int a = 0; a < PotionDB.Instance.potions.Length; a ++){
			if (potionName == PotionDB.Instance.potions [a].name) {
				Debug.Log (PotionDB.Instance.potions [a].heal);
			} else {
				Debug.Log ("Voce nao possui esta pocao");
			}
			}

		}


	}


