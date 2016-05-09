using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class JumpToStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene("StartScreen");
    }
	
}
