using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AutoFocus : MonoBehaviour
{
    private bool mVuforiaStarted = false;
    private bool mFlashEnabled = false;

    private void Start()
    {
        VuforiaARController vuforia = VuforiaARController.Instance;

        if(vuforia != null)
        {
            vuforia.RegisterVuforiaStartedCallback(StartAfterVuforia);
        }
    }

    private void StartAfterVuforia()
    {
        mVuforiaStarted = true;
        SetAutofocus();
    }

    private void OnApplicationPause(bool pause)
    {
        if(!pause)
        {
            if(mVuforiaStarted)
            {
                SetAutofocus();
            }
        }
    }

    private void SetAutofocus()
    {
        if(CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO))
        {
            Debug.Log("AutoFocus set");
        }
        else
        {
            Debug.Log("no autofocus supported");
        }
    }

}
