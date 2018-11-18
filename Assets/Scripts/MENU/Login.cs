using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour {

    [SerializeField] Text LoginText;
    [SerializeField] Text PasswordText;
    [SerializeField] Canvas LoginRegCanvas;
    [SerializeField] Canvas SelectFractionCanvas;

    [SerializeField] int MainMenuSceneIndex;

    private void Start()
    {
        SelectFractionCanvas.enabled = false;
        LoginRegCanvas.enabled = true;
    }

   public void login()
    {
        PlayerPrefs.SetString("login", LoginText.text);
        SelectFractionCanvas.enabled = true;
        LoginRegCanvas.enabled = false;

    }

    public void SelectFraction(string fractions)
    {
        PlayerPrefs.SetString("fractions", fractions);
        SceneManager.LoadScene(MainMenuSceneIndex);
    }
}
