using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButtonMode : MonoBehaviour {

    [SerializeField] GameObject HeaderLine;
    [SerializeField] Text buttonText;
    [SerializeField] Color normalColor;
    [SerializeField] Color activeColor;

    public void setActiveMode()
    {
        HeaderLine.SetActive(true);
        buttonText.color = activeColor;
    }

    public void setDeactiveMode()
    {
        HeaderLine.SetActive(false);
        buttonText.color = normalColor;
    }

}
