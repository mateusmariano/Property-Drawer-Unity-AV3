using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PotionDB : MonoBehaviour
{
	public static PotionDB Instance
	{
		get
		{
			if( instance == null )
			{
				instance = Resources.Load<PotionDB>("PotionDB");
			}

			return instance;
		}
	}

	private static PotionDB instance;

	public Potion[] potions;
	public static Potion[] potionaux;

	void Start(){
		potionaux = potions;
	}
}
