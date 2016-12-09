using UnityEngine;
using System.Collections;

public class ModeChanger : MonoBehaviour {

	public GameObject canvas;
	private float timer=3f;
	private bool played=false;

	void Start () {
		int selector = PlayerPrefs.GetInt ("VRSelector");
		if (selector == 1) {
			gameObject.GetComponent<VRMovement> ().enabled = true;
			gameObject.GetComponent<CharacterMovement> ().enabled = false;
			transform.FindChild ("CardboardMain").gameObject.SetActive (true);
			transform.FindChild ("Camera").gameObject.SetActive (false);
			for(int i=0;i<canvas.transform.childCount;i++)
				if(canvas.transform.GetChild(i).gameObject.name=="moveButton")
					canvas.transform.GetChild(i).gameObject.SetActive (true);
				else
					canvas.transform.GetChild(i).gameObject.SetActive (false);
		} else {
			gameObject.GetComponent<VRMovement> ().enabled = false;
			gameObject.GetComponent<CharacterMovement> ().enabled = true;
			transform.FindChild ("Camera").gameObject.SetActive (true);
			transform.FindChild ("CardboardMain").gameObject.SetActive (false);
			for(int i=0;i<canvas.transform.childCount;i++)
				if(canvas.transform.GetChild(i).gameObject.name=="moveButton")
					canvas.transform.GetChild(i).gameObject.SetActive (false);
				else
					canvas.transform.GetChild(i).gameObject.SetActive (true);
		}
	}

	void Update()
	{
		if (!played) 
		{
			if (timer > 0)
				timer -= Time.deltaTime;
			else {
				played = true;
				GameObject.Find ("AudioPlayer").GetComponent<AudioSource> ().Play ();
			}
		}
	}

}
