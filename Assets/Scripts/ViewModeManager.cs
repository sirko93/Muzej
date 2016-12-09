/*============================================================================== 
Copyright (c) 2015-2016 PTC Inc. All Rights Reserved.

Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.   
==============================================================================*/
using UnityEngine;
using System.Collections;
using Vuforia;

public class ViewModeManager : MonoBehaviour {



    #region MONOBEHAVIOUR_METHODS

    void Awake () 
    {
        VuforiaAbstractBehaviour vuforia = FindObjectOfType<VuforiaAbstractBehaviour>();
        vuforia.RegisterVuforiaInitializedCallback(SetViewMode);
    }

    #endregion // MONOBEHAVIOUR_METHODS


    #region PRIVATE_METHODS
    internal void SetViewMode()
    {
		MixedRealityController.Instance.SetMode (MixedRealityController.Mode.VIEWER_AR);
    }

    #endregion // PRIVATE_METHODS

}
