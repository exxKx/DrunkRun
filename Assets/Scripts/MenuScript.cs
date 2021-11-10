using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Button play;

    private string sceneForPlay = "SampleScene";

    private void Start()
    {
        play.onClick.AddListener(PlayClick);
    }

    private void PlayClick()
    {
        SceneManager.LoadScene(sceneForPlay);
    }

}
