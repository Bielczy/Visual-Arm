using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SampleSceneScript : MonoBehaviour
{
    public Button btnBack, btnElbowFlex_Ext_R, btnRotationR, btnFistR,
        btnWristFlex_Ext_FrontR, btnWristFlex_Ext_SagitR, btnElbowFlex_Ext_L,
        btnRotationL, btnFistL, btnWristFlex_Ext_FrontL, btnWristFlex_Ext_SagitL;
    public GameObject ExpositionPanel, WelcomePanel;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBackClick()
    {
        SceneManager.LoadScene(0);
    }
}
