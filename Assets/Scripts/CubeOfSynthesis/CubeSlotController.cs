using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSlotController : MonoBehaviour {


	public string m_SlotName;
	public int m_SlotCount;

	private Button m_button;

	[Header("Clild GO")]
	public Text m_SlotNameText;
	public Text m_SlotCountText;


	private void Awake() {
		m_button = GetComponent<Button>();
		m_SlotNameText.text = m_SlotName;
		m_SlotCountText.text = m_SlotCount.ToString();
	}
}