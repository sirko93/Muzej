using UnityEngine;
using System.Collections;
using Vuforia;

public class ARActivator : MonoBehaviour {

	void Awake () 
	{
		VuforiaAbstractBehaviour vuforia = FindObjectOfType<VuforiaAbstractBehaviour>();
		vuforia.RegisterVuforiaInitializedCallback(SetViewMode);
	}


	internal void SetViewMode()
	{
		MixedRealityController.Instance.SetMode (MixedRealityController.Mode.HANDHELD_AR);
	}
}
