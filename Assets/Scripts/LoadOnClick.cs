using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

    public GameObject loadingImage;

    public void LoadScenewithLoadingScreen(string selection)
    {
        loadingImage.SetActive(true);
        SceneManager.LoadScene(selection);
    }

    public void LoadScenewithoutLoadingScreen(string selection)
    {
        SceneManager.LoadScene(selection);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}
