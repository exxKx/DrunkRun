using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleScaneManager : MonoBehaviour
{

    public Text score;
    
    void Start()
    {
       GetComponent<AudioSource>().mute = GameDataLocalStorage.LoadData().musicOn;
       ScoreManager.StartScore();
    }

    private void Update()
    {
        score.text = "Distance:" + ScoreManager.CurrentScore() + "m.";
    }
}
