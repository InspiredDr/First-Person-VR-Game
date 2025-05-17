using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UnlockDoorKey : MonoBehaviour
{
    [SerializeField]
    private GameObject matchingKey;
    private XRGrabInteractable grab;
    private checkDistance distanceScript;

    void Start()
    {
        // gets the grabbing script for the door
        grab = GetComponent<XRGrabInteractable>();
        distanceScript = GetComponent<checkDistance>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // if it is the right key, then the grab is enabled and door can be accessed
        if (collision.gameObject == matchingKey)
        {
            grab.enabled = true;
            distanceScript.enabled = true;
            // the key is destroyed after use, to avoid confusion
            Destroy(collision.gameObject);
        }
    }
}
