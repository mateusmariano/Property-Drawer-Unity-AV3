using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.AttributeUsage(System.AttributeTargets.Field)]
public class PotionSelectorAttribute : PropertyAttribute
{
}

public class TestBehaviour : MonoBehaviour
{

	[PotionSelector]
	public string potionName;
	public int numerodapocao;
	 Potion[] here;

	public void Start()
	{
		here = PotionDB.potionaux;
		if(numerodapocao < here.Length){
		potionName = here[numerodapocao].name;
		Debug.Log("A poçao "+ potionName+ " recupoera: " + here[numerodapocao].heal);
		}else{
			Debug.Log("voce nao tem tantas poccoes");
		}

			


		// PotionDB.Instance pra acessar o "banco de dados" de pocoes
		// Imprimir o quanto aquela potion recupera
	}

}
