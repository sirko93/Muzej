using UnityEngine;
using System.Collections;

public class ModelActivator : MonoBehaviour {

	void Start () {
		if (PlayerPrefs.HasKey ("ActiveModel")) {
			string modelName = PlayerPrefs.GetString ("ActiveModel");
			GameObject model = (GameObject) Instantiate (Resources.Load ("ModelPrefabs/"+modelName),transform);
			Vector3 pos = model.transform.position;
			model.transform.localScale = model.transform.lossyScale;
			//model.transform.parent = transform;
			model.transform.localPosition = pos;
			//transform.FindChild (modelName).gameObject.SetActive (true);
		}
	}

}
