using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float Firespeed = 100;
    public int numberOfBullets = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Gets the component and runs the method FIRE
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FireBullet(ActivateEventArgs args)
    {
        if (numberOfBullets > 0)
        {
            GameObject spawnedBullet = Instantiate(bullet);
            spawnedBullet.transform.position = spawnPoint.position;
            spawnedBullet.transform.rotation = spawnPoint.rotation;
            spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * Firespeed;
            numberOfBullets = numberOfBullets - 1;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bulletBox")
        {
            numberOfBullets = numberOfBullets + collision.gameObject.GetComponent<bulletBox>().quantity;
            Destroy(collision.gameObject);
        }
    }
}
