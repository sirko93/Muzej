using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class LevelLoader : MonoBehaviour {

	public Toggle selector;
	public GameObject panel;

	public void LoadLevel()
	{
		panel.SetActive (true);
		if (selector.isOn)
			PlayerPrefs.SetInt ("VRSelector", 1);
		else
			PlayerPrefs.SetInt ("VRSelector", 0);
		StartCoroutine ("LevelLoad");
		/*if (selector.isOn)
			SceneManager.LoadScene ("Vuforia-VR");
		else
			SceneManager.LoadScene ("Vuforia-AR");*/
			//SceneManager.LoadScene ("Dolina");
	}

	IEnumerator LevelLoad()
	{
		yield return new WaitForSeconds (0.66f);
		SceneManager.LoadScene ("Vuforia-AR");
		/*if (selectorValue)
			SceneManager.LoadScene ("Vuforia-VR");
		else
			SceneManager.LoadScene ("Vuforia-AR");*/
	}
}
