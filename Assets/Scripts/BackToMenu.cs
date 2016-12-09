using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BackToMenu : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape))
		if (SceneManager.GetActiveScene ().name == "Dolina") {
			SceneManager.LoadScene ("Vuforia-AR");
			GameObject.Find ("AudioPlayer").GetComponent<AudioSource> ().Pause();
		}
		else
			SceneManager.LoadScene ("MainMenu");
	}
}
