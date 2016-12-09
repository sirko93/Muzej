using UnityEngine;
using System.Collections;

public class VRModelActivator : MonoBehaviour {

	public void ActivateModel()
	{
		if (PlayerPrefs.HasKey ("ActiveModel")) {
			string modelName = PlayerPrefs.GetString ("ActiveModel");
			transform.FindChild (modelName).gameObject.SetActive (true);
		}
	}
}
