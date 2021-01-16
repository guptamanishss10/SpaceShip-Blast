using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiHandler : MonoBehaviour
{
    [SerializeField] Text currentScoreTxt;
    [SerializeField] Text highScoreTxt;
    public GameObject PauseMenu1;
    public static bool GameIspaused = false;

    // Start is called before the first frame update

    // Update is called once per frame
    public void Start()
    {
        currentScoreTxt.text = "Current Score:" + PlayerPrefs.GetInt("CurrentScore").ToString();
        if (PlayerPrefs.GetInt("CurrentScore") > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("CurrentScore"));
        }
        highScoreTxt.text = "High Score:" + PlayerPrefs.GetInt("HighScore").ToString();
        Invoke("ShowAds", 1f);

    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
        AudioListener.pause = false;

    }

    public void QuitBtn()
    {
        Application.Quit();

    }
    public void ExitBtn()
    {
        SceneManager.LoadScene(0);
        AudioListener.pause = false;


    }
    public void Information()
    {
        SceneManager.LoadScene(3);

    }
    public void PauseMenuFun()
    {

        Time.timeScale = 0f;
        AudioListener.pause = true;

        PauseMenu1.SetActive(true);
    }

    public void ResumeMenuFun()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;


        PauseMenu1.SetActive(false);

    }
    public void ShowAds()
    {
        AdManagers.ShowStandardAd();
    }
    public void OpenUrl()
    {
        Application.OpenURL("https://sites.google.com/view/spaceship-blast/home");
    }

}
