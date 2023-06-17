using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightGrab : MonoBehaviour
{
    public OVRInput.Button OnButton, GrabButton;
    public FlashlightToggle flashLightToggle;
    public bool bistriggerPressed;

    OVRGrabbable grabbable;
    public Transform TorchSlotPosition;
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
            FlashLightAudio.Play();
            //
        }

        if (!grabbable.isGrabbed)
        {
            transform.position = TorchSlotPosition.position;
            transform.rotation = TorchSlotPosition.rotation;
        }
        else
        {
          
        }
       

    }
    
  
}
