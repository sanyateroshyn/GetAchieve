using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellPoolController : MonoBehaviour {
	 

	int i = 0;
	[SerializeField] GameObject[] m_cells;
	private void Start() {
		//DefaultTrackableEventHandler.LostFocus += NextCell;
		NextCell();
	}
	public void NextCell(/*DefaultTrackableEventHandler a*/) {
		Debug.Log("NEXT");

		for (int j = 0; j<m_cells.Length; j++) {
			m_cells[j].SetActive(i == j);
		}
		if (i+1 == m_cells.Length) { i = 0; } else { i++; }
	}
}
