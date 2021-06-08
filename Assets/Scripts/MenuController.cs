using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    public GameObject BGPanel, InstructionPanel, TutorialPanel;
    public GameObject MiddlePanel,TopPanel;
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void InstructionButton()
    {
        BGPanel.SetActive(true);
        MiddlePanel.SetActive(false);
        InstructionPanel.SetActive(true);
        TutorialPanel.SetActive(false);
        TopPanel.SetActive(true);
    }

    public void TutorialButton()
    {
        BGPanel.SetActive(true);
        MiddlePanel.SetActive(false);
        TutorialPanel.SetActive(true);
        InstructionPanel.SetActive(false);
        TopPanel.SetActive(true);
    }


    public void BackButton()
    {
        BGPanel.SetActive(true);
        MiddlePanel.SetActive(true);
        TutorialPanel.SetActive(false);
        InstructionPanel.SetActive(false);
        TopPanel.SetActive(true);
    }
    public void menuButton()
    {
        SceneManager.LoadScene(0);
    }

}