using UnityEngine;
using System.Collections;
using UnityEditorInternal;
using UnityEditor;
using System.Collections.Generic;

[CustomPropertyDrawer(typeof(TestBehaviour))]
public class PotionSelector : PropertyDrawer {

	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label){
		int indice = 0;
		string[] pocoes = new string[PotionDB.instance.potions.Length];

		for(int i = 0; i < PotionDB.instance.potions.Length; i++){
			pocoes[i] = PotionDB.instance.potions[i].name;
			if(pocoes[i] == property.stringValue	){
			indice = i;
			}
	}
		indice = EditorGUI.Popup(position,indice,pocoes);
		property.stringValue = pocoes[indice];
}
}
