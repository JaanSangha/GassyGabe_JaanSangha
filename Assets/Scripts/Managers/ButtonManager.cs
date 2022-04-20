using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour
{

    public GameObject MainMenu;
    public GameObject InstructionsMenu;
    public GameObject CreditsMenu;

    public void StartPressed()
    {
        SceneManager.LoadScene("Main");
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void MainMenuPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void InstructionsMenuPressed()
    {
        MainMenu.SetActive(false);
        InstructionsMenu.SetActive(true);
        CreditsMenu.SetActive(false);
    }

    public void CreditsMenuPressed()
    {
        MainMenu.SetActive(false);
        InstructionsMenu.SetActive(false);
        CreditsMenu.SetActive(true);
    }

    public void BackButtonPressed()
    {
        MainMenu.SetActive(true);
        InstructionsMenu.SetActive(false);
        CreditsMenu.SetActive(false);
    }
}
