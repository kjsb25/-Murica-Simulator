using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

    public GameObject loadingImage;

    public void LoadScenewithLoadingScreen(string selection)
    {
        Time.timeScale = 1.0f;
        loadingImage.SetActive(true);
        SceneManager.LoadScene(selection);
    }

    public void LoadScenewithoutLoadingScreen(string selection)
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(selection);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}
