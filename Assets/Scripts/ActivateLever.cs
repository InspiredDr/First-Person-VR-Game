using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLever : MonoBehaviour
{
    public bool activated = false;
    // when the lever collides with the position, it gets activated
    private void OnCollisionEnter(Collision collision)
    {
        // collide is the tag of the position at which the lever operated the door
        if (collision.gameObject.tag == "collide")
        {
            // This means the lever has activated the door
            activated = true;
        }
    }
}
