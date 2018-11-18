using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSlotsManager : MonoBehaviour {

	//public MyScriptableObjectClass m_SlotsIndexs;// елементы в заблаговременно созданом списке
	public CubeSlotController m_SlotElement;
	//public List<CubeSlotController.CubeSlots> m_SlotElements; // список елементов в нижнем списке
	public GameObject m_SlotsContent;
	public CubeSynthesisManager m_cubeSynthesisManager;
	public CubeSlotController MaincubeSlotController;
	public float m_SlotOfsset;

	//void Start() {

		//foreach (CubeSlotController.CubeSlots cubeSlot in m_SlotsIndexs.slotsList) {
		//	{
		//		m_SlotElements.Add(cubeSlot);
		//	}

		//	CubeSlotController.e_OnClickSlot += RemoveSlot;
			//CubeSlotController.e_OnClickSLotMain += AddFromMain;
	//	}
	//}
	//public void RefreshSlotsInSlotConteiner() {

	//	int i = 0;
		//foreach (Transform child in m_SlotsContent.transform) {
		//	GameObject.Destroy(child.gameObject);
		//}

//	}
}
//	Vector3 m_previousSlotPosition = m_SlotsContent.GetComponent<RectTransform>().position + new Vector3(55, 0, 0);
//		foreach (CubeSlotController.CubeSlots cubeSlot in m_SlotsIndexs.slotsIndex) {
//			m_SlotElements.Add(Instantiate(m_SlotElement, m_previousSlotPosition, m_SlotsContent.GetComponent<RectTransform>().rotation, m_SlotsContent.transform));
//			m_previousSlotPosition += new Vector3(m_SlotOfsset, 0, 0);
//	m_SlotElements[m_SlotElements.Count - 1].Init(cubeSlot, i);
//	i++;
//		}
//m_SlotsContent.GetComponent<RectTransform>().sizeDelta = new Vector2(m_previousSlotPosition.x, .0f);
//	}
//	void RemoveSlot(CubeSlotController m_cubeSlot) {
//	if (m_cubeSynthesisManager.m_cubeSynthesisElements.Count == m_cubeSynthesisManager.m_cubeSynthesisSlots.Length) return;


//	m_SlotElements.Remove(m_cubeSlot);
//	int i = 0;
//	foreach (Transform child in m_SlotsContent.transform) {
//		Destroy(child.gameObject);
//	}

//	Vector3 m_previousSlotPosition = m_SlotsContent.GetComponent<RectTransform>().position + new Vector3(55, 0, 0);
//	CubeSlotController[] m_SlotElements2 = new CubeSlotController[m_SlotElements.Count];
//	m_SlotElements.CopyTo(m_SlotElements2);
//	m_SlotElements.Clear();
//	foreach (CubeSlotController cubeSlot in m_SlotElements2) {
//		m_SlotElements.Add(Instantiate(m_SlotElement, m_previousSlotPosition, m_SlotsContent.GetComponent<RectTransform>().rotation, m_SlotsContent.transform));
//		m_previousSlotPosition += new Vector3(m_SlotOfsset, 0, 0);
//		m_SlotElements[m_SlotElements.Count - 1].Init(cubeSlot.m_CurrentSlot, i);
//		i++;
//	}
//	m_SlotsContent.GetComponent<RectTransform>().sizeDelta = new Vector2(m_previousSlotPosition.x, .0f);
//	m_cubeSynthesisManager.InitSlot(m_cubeSlot);

//}

//public void AddFromMain(CubeSlotController cubeSlotController) {
//	MaincubeSlotController.DisableAllSlotContent();

//	Vector3 m_previousSlotPosition = m_SlotsContent.GetComponent<RectTransform>().position + new Vector3((m_SlotElements.Count * m_SlotOfsset) + 55, 0, 0);

//	m_SlotElements.Add(Instantiate(m_SlotElement, m_previousSlotPosition, m_SlotsContent.GetComponent<RectTransform>().rotation, m_SlotsContent.transform));
//	m_SlotElements[m_SlotElements.Count - 1].Init(cubeSlotController.m_CurrentSlot, m_SlotElements.Count);
//	m_SlotsContent.GetComponent<RectTransform>().sizeDelta = new Vector2(m_previousSlotPosition.x, .0f);
//	m_cubeSynthesisManager.RefreshSynthesisCube();
//}
//}