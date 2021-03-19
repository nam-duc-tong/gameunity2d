using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSceneController : MonoBehaviour
{
    public static SampleSceneController instance;
    void Awake()
    {
        MakeInstance();
    }
    void MakeInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    [SerializeField]
    private GameObject pausePanel, gameOverPanel;
    public void PauseGameButton()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeButton()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void ReStartButton()
    {
        gameOverPanel.SetActive(false);
        Application.LoadLevel("SampleScene");
    }
    public void OptionButton()
    {
        Application.LoadLevel("MainMenu");
    }
    public void PlaneDiedShowPanel()
    {
        gameOverPanel.SetActive(true);
    }
}
