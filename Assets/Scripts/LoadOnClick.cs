using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

    public GameObject loadingImage;

    public void LoadScene(int selection)
    {
        if (selection == 10)
        {
            Application.Quit();
        }
        loadingImage.SetActive(true);
        Application.LoadLevel(selection);
    }
}
