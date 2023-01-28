using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _settingPanel;
    
    private const string Game = "Game";

    private void Start()
    {
        _settingPanel.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene(Game);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OpenOptions()
    {
        _settingPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        _settingPanel.SetActive(false);
    }
}
