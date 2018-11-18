using System;
using UnityEngine;

[Serializable]
public class cubeStringElements {
	public int[] m_elements;
}



public class cubeString : MonoBehaviour {

	void Start() {

		CreateCubeString();
	}

	public void CreateCubeString()
		{
		cubeStringElements materials = new cubeStringElements();
		materials.m_elements = new int[9];
		int randomElementsCount  = UnityEngine.Random.Range(3, 9);
		for (int i = 0; i < randomElementsCount; i++) 
			{
			materials.m_elements[i] = UnityEngine.Random.Range(1, 162);
		}
		for (int i = randomElementsCount; i < 9; i++) 
			{
			materials.m_elements[i] = 0;
		}

		string jsonCubeString = JsonUtility.ToJson(materials);

		Debug.Log(jsonCubeString);
	}

}
