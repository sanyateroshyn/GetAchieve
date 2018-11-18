using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatController : MonoBehaviour {

    [SerializeField] GameObject ChatPlace1;
    [SerializeField] GameObject ChatPlace2;
    [SerializeField] GameObject ChatPlace3;
    [SerializeField] GameObject ChatPlace4;
    [SerializeField] GameObject ChatPlace5;
    [SerializeField] ShopButtonMode[] ChatButtonModes;

    void Start()
    {
        ChatPlace1.SetActive(true);
        ChatPlace2.SetActive(false);
        ChatPlace3.SetActive(false);
        ChatPlace4.SetActive(false);
        ChatPlace5.SetActive(false);
        ChatButtonModes[0].setActiveMode();
        ChatButtonModes[1].setDeactiveMode();
        ChatButtonModes[2].setDeactiveMode();
        ChatButtonModes[3].setDeactiveMode();
        ChatButtonModes[4].setDeactiveMode();
    }


    public void ShopCatButton1Click()
    {
        ChatPlace1.SetActive(true);
        ChatPlace2.SetActive(false);
        ChatPlace3.SetActive(false);
        ChatPlace4.SetActive(false);
        ChatPlace5.SetActive(false);
        ChatButtonModes[0].setActiveMode();
        ChatButtonModes[1].setDeactiveMode();
        ChatButtonModes[2].setDeactiveMode();
        ChatButtonModes[3].setDeactiveMode();
        ChatButtonModes[4].setDeactiveMode();
    }
    public void ShopCatButton2Click()
    {
        ChatPlace1.SetActive(false);
        ChatPlace2.SetActive(true);
        ChatPlace3.SetActive(false);
        ChatPlace4.SetActive(false);
        ChatPlace5.SetActive(false);
        ChatButtonModes[0].setDeactiveMode();
        ChatButtonModes[1].setActiveMode();
        ChatButtonModes[2].setDeactiveMode();
        ChatButtonModes[3].setDeactiveMode();
        ChatButtonModes[4].setDeactiveMode();
    }
    public void ShopCatButton3Click()
    {
        ChatPlace1.SetActive(false);
        ChatPlace2.SetActive(false);
        ChatPlace3.SetActive(true);
        ChatPlace4.SetActive(false);
        ChatPlace5.SetActive(false);
        ChatButtonModes[0].setDeactiveMode();
        ChatButtonModes[1].setDeactiveMode();
        ChatButtonModes[2].setActiveMode();
        ChatButtonModes[3].setDeactiveMode();
        ChatButtonModes[4].setDeactiveMode();
    }
    public void ShopCatButton4Click()
    {
        ChatPlace1.SetActive(false);
        ChatPlace2.SetActive(false);
        ChatPlace3.SetActive(false);
        ChatPlace4.SetActive(true);
        ChatPlace5.SetActive(false);
        ChatButtonModes[0].setDeactiveMode();
        ChatButtonModes[1].setDeactiveMode();
        ChatButtonModes[2].setDeactiveMode();
        ChatButtonModes[3].setActiveMode();
        ChatButtonModes[4].setDeactiveMode();
    }
    public void ShopCatButton5Click()
    {
        ChatPlace1.SetActive(false);
        ChatPlace2.SetActive(false);
        ChatPlace3.SetActive(false);
        ChatPlace4.SetActive(false);
        ChatPlace5.SetActive(true);
        ChatButtonModes[0].setDeactiveMode();
        ChatButtonModes[1].setDeactiveMode();
        ChatButtonModes[2].setDeactiveMode();
        ChatButtonModes[3].setDeactiveMode();
        ChatButtonModes[4].setActiveMode();
    }

}
