using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Button play;
    public GameObject seal;
    public Button music;
    public GameObject musicText;
    public Text sealText;
    public Button about;

    private string sceneForPlay = "SampleScene";
    private bool musicOn = false;

    private void Start()
    {
        musicOn = GameDataLocalStorage.LoadData().musicOn;
        musicText.SetActive(musicOn);

        sealText.text = ScoreManager.bestScore + "m";
        seal.SetActive(ScoreManager.bestScore != 0);

        play.onClick.AddListener(PlayClick);
        music.onClick.AddListener(MusicClick);
        about.onClick.AddListener(AboutClick);
    }

    private void AboutClick()
    {
        SceneManager.LoadScene("AboutScene");
    }
    
    private void MusicClick()
    {
        musicOn = !musicOn;
        GameDataLocalStorage.SaveMusic(musicOn);
        musicText.SetActive(musicOn); 
        
    }

    private void PlayClick()
    {
        SceneManager.LoadScene(sceneForPlay);
    }
}