﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton1 : MonoBehaviour
{

    //    void OnCli
    //	// Use this for initialization
    //	void Start () {
    //        SceneManager.LoadScene("game2d");

    //    }

    //	// Update is called once per frame
    //	void Update () {

    //	}
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    
    public void Clicked()
    {
        SceneManager.LoadScene("Stage1S");
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("Stage1S");
        //Debug.Log("You have clicked the button!");
    }
}
//}
