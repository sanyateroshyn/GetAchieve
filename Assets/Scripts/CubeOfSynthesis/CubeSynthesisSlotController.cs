using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSynthesisSlotController : MonoBehaviour
{

	[SerializeField] Sprite[] m_elementsSprites;
	[SerializeField] Image m_slotImage;
	public int m_SlotIndex;
	public bool m_slotIsUsed;

	public void InitSlotElem(int slotIndex ) {
		m_slotImage.sprite = m_elementsSprites[slotIndex];
		m_SlotIndex = slotIndex;
		m_slotIsUsed = true;
	}
}