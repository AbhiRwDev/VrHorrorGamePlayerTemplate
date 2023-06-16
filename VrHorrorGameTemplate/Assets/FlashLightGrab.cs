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
            //
        }
        
       if(grabbable.isGrabbed)
        {
          if(OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger,grabbable.grabbedBy.GetController()))
            {
                bistriggerPressed = false;
            }
            
            if(!bistriggerPressed&& OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, grabbable.grabbedBy.GetController()) == 1)
            {
                grabbable.grabbedBy.ForceRelease(grabbable);
                bistriggerPressed = true;
            }
        }
       

    }
    public void check()
    {
        if (grabbable.isGrabbed && OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, grabbable.grabbedBy.GetController()) == 1)
        {

        }
    }
    public void GrabObject()
    {

       
       
          
        
    }
}
