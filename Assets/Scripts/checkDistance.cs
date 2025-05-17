using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class checkDistance : MonoBehaviour
{
    private XRGrabInteractable grab;
    public Transform Player;
    public float enableDistance;

    // Start is called before the first frame update
    void Start()
    {
        grab = GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Player.position, transform.position) > enableDistance)
        {
            grab.enabled = false;
        }

        else
        {
            grab.enabled = true;
        }
    }
}
