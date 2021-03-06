﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    private readonly string mainScene = "MainMenu";

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().name != mainScene)
        {
            SceneManager.LoadScene(mainScene);
        }        
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(mainScene);
    }
}
