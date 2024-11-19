using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuPanel : MonoBehaviour
{

    [SerializeField] private Button exitButton;

    void Start()
    {
    
        exitButton.onClick.AddListener(QuitGame); 
    }

    private void ShowLoadGamePanel()
    {
        
    }



    public void QuitGame()
    {
      
        Application.Quit();
    }
}