using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotScript : MonoBehaviour
{
    bool bisFilled;//flag for checking if the slot if already filled
   [SerializeField] GameObject SlottedObject;//the object
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<SlottableObject>()&& !bisFilled)//checks for slottableobject script and if the slot is empty
        {
            
            SlottedObject = other.gameObject;
            if(!SlottedObject.GetComponent<OVRGrabbable>().isGrabbed)
            {
                SlottedObject.transform.parent = transform;
                SlottedObject.GetComponent<Rigidbody>().isKinematic = true;
                bisFilled = true;
            }
            SlottedObject = null;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<SlottableObject>() && bisFilled)//checks for slottableobject script and if the slot is empty
        {

            SlottedObject = other.gameObject;
            if (SlottedObject.GetComponent<OVRGrabbable>().isGrabbed)
            {
                SlottedObject.transform.parent = null;
                SlottedObject.GetComponent<Rigidbody>().isKinematic = true;
                bisFilled = false;
            }
            SlottedObject = null;
        }
    }
}
