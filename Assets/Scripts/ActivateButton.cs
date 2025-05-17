using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateButton : MonoBehaviour
{
    public bool activated = false;
    private Renderer colourChange;
    void Start()
    {
        colourChange = GetComponent<Renderer>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        // collide is the tag of the position at which the lever operated the door
        if (collision.gameObject.tag == "hand")
        {
            // This means the lever has activated the door
            activated = true;
            colourChange.material.color = Color.yellow;
        }
    }
}
