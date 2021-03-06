﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;
using TGAME;

public class PlayerStatus : MonoBehaviour {

    public Slider m_SliderHP = null;
    public Slider m_SliderBullet = null;
    public Text m_Text = null;
    public FirstPersonController fpc = null;

    void Awake()
    {
        //fpc = Camera.main.GetComponentInChildren<FirstPersonController>();
    }
    // Use this for initialization
    void Start () {
        //m_SliderHP = gameObject.GetComponentInChildren<Slider>();
    }

    // Update is called once per frame
    void Update () {
        m_SliderHP.value = (float)fpc.m_iHP / 100.0f; //Mathf.MoveTowards(m_SliderHP.value, 1.0f, 0.008f);
        m_SliderBullet.value = (float)fpc.m_iBullet / 100.0f; //Mathf.MoveTowards(m_SliderHP.value, 1.0f, 0.008f);
        //m_Text.text = "Score: " + fpc.m_iScore.ToString();
        if (m_SliderHP.value <= 0.0f)
        {
            //게임오버 Scene으로 전환.
            //SceneManager.LoadScene("Stage1");

            TAudioMgr.Instance.PlayEffect("pl_dead");

            // Allow it to move on the screen
            Cursor.lockState = CursorLockMode.Confined;
            // Show the cursor
            UnityEngine.Cursor.visible = true;
            //게임오버 Scene으로 전환.
            TAutoFade.LoadLevel(4, 1.0f, 1.0f, Color.black);



        }
    }
}
