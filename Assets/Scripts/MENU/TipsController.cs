using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsController : MonoBehaviour {

    [SerializeField] GameObject Tip;

    public void TipController()
        {
        Tip.SetActive(!Tip.activeSelf);
    }
}
