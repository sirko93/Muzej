using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ActivateValley : MonoBehaviour {
	public GameObject panel;
	private int selector;
	private float timer=3f;
	// Use this for initialization
	void Start () {
		selector = PlayerPrefs.GetInt ("VRSelector");
		if(selector==1)
			panel.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (selector == 1) {
			if (timer > 0)
				timer -= Time.deltaTime;
			else {
				selector = 0;
				panel.SetActive (false);
			}
		}
	}

	public void ValleyActivator()
	{
		//panel.SetActive (true);
		SceneManager.LoadScene ("Dolina");
	}

}
