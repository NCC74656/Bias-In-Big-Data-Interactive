﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame_Slider : MonoBehaviour
{
    public void gotoendscene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
