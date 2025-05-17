using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UnlockDoorButton : MonoBehaviour
{
    [SerializeField]
    private GameObject button;
    private XRGrabInteractable grab;
    private checkDistance distanceScript;

    void Start()
    {
        // gets the grabbing script for the door and the distanceScript
        grab = GetComponent<XRGrabInteractable>();
        distanceScript = GetComponent<checkDistance>();
    }

    void Update()
    {
        // Gets the activated variable from the lever object 
        if (button.GetComponent<ActivateButton>().activated)
        {
            // enables the two scripts
            grab.enabled = true;
            distanceScript.enabled = true;
        }

    }
}
