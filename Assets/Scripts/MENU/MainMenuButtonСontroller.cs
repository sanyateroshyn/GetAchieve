using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtonСontroller : MonoBehaviour {

    [SerializeField] GameObject MainScreenCanvas;
    [SerializeField] GameObject MainMenuCanvas;
    [SerializeField] GameObject ShopCanvas;
    [SerializeField] GameObject CubeCanvas;
    [SerializeField] GameObject WishWheelCanvas;


    private void Start()
    {
        MainScreenCanvas.SetActive(true);
        MainMenuCanvas.SetActive(false);
        ShopCanvas.SetActive(false);
        CubeCanvas.SetActive(false);
        WishWheelCanvas.SetActive(false);
    }

    public void MainMenuController()
    {
        MainMenuCanvas.SetActive(!MainMenuCanvas.activeSelf);
    }

    public void CubeCanvasController()
    {
        CubeCanvas.SetActive(!CubeCanvas.activeSelf);
    }

    public void WishWheelCanvasController()
    {
        WishWheelCanvas.SetActive(!WishWheelCanvas.activeSelf);
    }


    public void ShopCanvasController()
    {
        ShopCanvas.SetActive(!ShopCanvas.activeSelf);
    }


}
