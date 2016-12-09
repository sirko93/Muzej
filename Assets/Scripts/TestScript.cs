using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Cardboard.SDK.Triggered){
			SceneManager.LoadScene (3);
		}
	}
}
