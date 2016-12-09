using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Vuforia;

public class ActivateNaration : MonoBehaviour,ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;
	private AudioSource source;
	public AudioClip naration;
	public string modelName;
	private Button b;
	// Use this for initialization
	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		source = GameObject.Find ("AudioPlayer").GetComponent<AudioSource>();
		b = GameObject.Find ("Canvas").GetComponentInChildren<Button> ();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}
	
	// Update is called once per frame
	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus,TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			PlayerPrefs.SetString ("ActiveModel", modelName);
			b.interactable = true;

			if (source.clip != naration)
				source.clip = naration;
			//source.Play();
		}
		else
		{
			// Stop audio when target is lost
			if(b!=null)
				b.interactable=false;
			//source.Pause();
		}
	}
}
