using UnityEngine;
using System.Collections;
using UnityEditorInternal;
using UnityEditor;
using System.Collections.Generic;

[CustomPropertyDrawer(typeof(PotionSelectorAttribute))]
public class PotionSelector : PropertyDrawer {

	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label){
		int indice = 0;
		string[] pocoes = new string[PotionDB.Instance.potions.Length];
		int[] hela = new int[PotionDB.Instance.potions.Length];

		for(int i = 0; i < PotionDB.Instance.potions.Length; i++){
			pocoes[i] = PotionDB.Instance.potions[i].name;
			hela[i] = PotionDB.Instance.potions[i].heal;
			if(pocoes[i] == property.stringValue	){
			indice = i;
			}

	}
		indice = EditorGUI.Popup(position,label.text,indice,pocoes);

		property.stringValue = pocoes[indice];
}
}
