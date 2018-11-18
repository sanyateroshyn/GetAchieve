using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPlacesController : MonoBehaviour {

    [SerializeField] GameObject ShopPlace1;
    [SerializeField] GameObject ShopPlace2;
    [SerializeField] GameObject ShopPlace3;
    [SerializeField] ShopButtonMode[] shopButtonModes;

    void Start () {
        ShopPlace1.SetActive(true);
        ShopPlace2.SetActive(false);
        ShopPlace3.SetActive(false);
        shopButtonModes[0].setActiveMode();
        shopButtonModes[1].setDeactiveMode();
        shopButtonModes[2].setDeactiveMode();


    }


    public void ShopCatButton1Click()
    {
        shopButtonModes[0].setActiveMode();
        shopButtonModes[1].setDeactiveMode();
        shopButtonModes[2].setDeactiveMode();
        ShopPlace1.SetActive(true);
        ShopPlace2.SetActive(false);
        ShopPlace3.SetActive(false);
        
    }
    public void ShopCatButton2Click()
    {
        shopButtonModes[1].setActiveMode();
        shopButtonModes[0].setDeactiveMode();
        shopButtonModes[2].setDeactiveMode();
        ShopPlace1.SetActive(false);
        ShopPlace2.SetActive(true);
        ShopPlace3.SetActive(false);
    }
    public void ShopCatButton3Click()
    {
        shopButtonModes[2].setActiveMode();
        shopButtonModes[1].setDeactiveMode();
        shopButtonModes[0].setDeactiveMode();
        ShopPlace1.SetActive(false);
        ShopPlace2.SetActive(false);
        ShopPlace3.SetActive(true);
    }


}
