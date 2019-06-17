using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuSceneScript : MonoBehaviour

{
    public Button btnRightHand, btnLeftHand, btnExit;
    public GameObject WelcomePanel; 

    // Start is called before the first frame update
    void Start()
    {        
        WelcomePanel.SetActive(true);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRightClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnLeftClick()
    {
        SceneManager.LoadScene(2);
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
}
