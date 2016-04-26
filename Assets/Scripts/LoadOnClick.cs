using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

    public void LoadScene(int selection)
    {
        if (selection == 10)
        {
            Application.Quit();
        }
        Application.LoadLevel(selection);
    }
}
