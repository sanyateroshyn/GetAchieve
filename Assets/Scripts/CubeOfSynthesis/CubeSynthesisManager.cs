using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSynthesisManager : MonoBehaviour {

	public CubeSynthesisSlotController[] m_cubeSynthesisSlotControllers;
	public void AddToCube(int SlotIndex)
		{
		for (int i = 0; i < m_cubeSynthesisSlotControllers.Length; i++) 
			{
			if (!m_cubeSynthesisSlotControllers[i].m_slotIsUsed) 
				{
				m_cubeSynthesisSlotControllers[i].InitSlotElem(SlotIndex);
				break;
			}
		}
}
//private void Start() {
//	CubeSlotController.e_OnClickSLotInCube += RemoveSlot;
//	m_cubeSynthesisElements = new List<CubeSlotController>();
//	foreach (CubeSlotController tmpCube in m_cubeSynthesisSlots) 
//		{
//		tmpCube.DisableAllSlotContent();
//	}
//	m_cubeSynthesisMainSlot.DisableAllSlotContent();
//}
//public  void InitSlot(CubeSlotController m_cubeSlot) 
//	{
//	m_cubeSynthesisSlots[m_cubeSynthesisElements.Count].Init(m_cubeSlot.m_CurrentSlot, m_cubeSynthesisElements.Count);
//	m_cubeSynthesisSlots[m_cubeSynthesisElements.Count].m_IsInCube = true;
//	m_cubeSynthesisElements.Add(m_cubeSynthesisSlots[m_cubeSynthesisElements.Count]);
//}
//public void RefreshSynthesisCube() 
//	{
//	foreach (CubeSlotController tmpCube in m_cubeSynthesisSlots) {
//		tmpCube.DisableAllSlotContent();
//	}
//	int i = 0;
//	foreach (CubeSlotController tmpCube in m_cubeSynthesisElements) 
//		{
//		m_cubeSynthesisSlots[i].Init(tmpCube.m_CurrentSlot, i);
//		m_cubeSynthesisSlots[i].m_IsInCube = true;
//		i++;
//	}
//}

	//void RemoveSlot(CubeSlotController m_cubeSlot) {
	//	m_cubeSynthesisElements.Remove(m_cubeSlot);

	////	m_cubeSlotsManager.AddFromMain(m_cubeSlot);
	//	//m_cubeSynthesisSlots[m_cubeSlot.m_SlotIndex].DisableAllSlotContent();


	//	//Vector3 m_previousSlotPosition = m_cubeSlotsManager.m_SlotsContent.GetComponent<RectTransform>().position + new Vector3((m_cubeSlotsManager.m_SlotElements.Count*m_cubeSlotsManager.m_SlotOfsset)+55, 0, 0);

	//	//m_cubeSlotsManager.m_SlotElements.Add(Instantiate(m_cubeSlotsManager.m_SlotElement, m_previousSlotPosition, m_cubeSlotsManager.m_SlotsContent.GetComponent<RectTransform>().rotation, m_cubeSlotsManager.m_SlotsContent.transform));
	//	//m_cubeSlotsManager.m_SlotElements[m_cubeSlotsManager.m_SlotElements.Count - 1].Init(m_cubeSlot.m_CurrentSlot, m_cubeSlotsManager.m_SlotElements.Count);
	//	//m_cubeSlotsManager.m_SlotsContent.GetComponent<RectTransform>().sizeDelta = new Vector2(m_previousSlotPosition.x, .0f);
	//	RefreshSynthesisCube();
	//}

}