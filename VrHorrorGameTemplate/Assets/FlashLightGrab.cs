using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightGrab : MonoBehaviour
{
    public OVRInput.Button OnButton,GrabButton;
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
        bistriggerPressed = OVRInput.Get(GrabButton,grabbable.grabbedBy.GetController());
        if (grabbable.isGrabbed && OVRInput.GetDown(OnButton,grabbable.grabbedBy.GetController()))
        {
            flashLightToggle.ToggleOn();
        }
        if(grabbable.isGrabbed&&OVRInput.GetDown(GrabButton,grabbable.grabbedBy.GetController()))
        {
            grabbable.grabbedBy.ForceRelease(grabbable);
        }
    }
}
