using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightGrab : MonoBehaviour
{
    public OVRInput.Button OnButton, GrabButton;
    public FlashlightToggle flashLightToggle;
    public bool bistriggerPressed;

    OVRGrabbable grabbable;
    AudioSource FlashLightAudio;

    // Start is called before the first frame update
    void Start()
    {
        grabbable = GetComponent<OVRGrabbable>();
        FlashLightAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (grabbable.isGrabbed && OVRInput.GetDown(OnButton, grabbable.grabbedBy.GetController()))
        {
            flashLightToggle.ToggleOn();
            //grabbable.grabbedBy.ForceRelease(grabbable);
        }
       if(grabbable.isGrabbed && OVRInput.Get(GrabButton, grabbable.grabbedBy.GetController()))
            {
                GrabObject();
            }
        

    }
    public void GrabObject()
    {
       
         grabbable.grabbedBy.ForceRelease(grabbable);
       
          
        
    }
}
