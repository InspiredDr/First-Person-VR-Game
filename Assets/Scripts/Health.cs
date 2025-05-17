using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    // variables for health
    public int health = 500;
    public static bool isDead = false;
    // Update is called once per frame
    void Update()
    {
        if (Die())
        {
            // the isDead variable is set to true and this can be used to end the game
            isDead = true;
        }

        if (isDead)
        {
            GetComponent<Transform>().position = Vector3.zero;
            SceneManager.LoadScene(2);
        }
    }

    // this function is used to check if the player is dead or not
    bool Die()
    {
        if (health < 1)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "endCube")
        {
            GetComponent<Transform>().position = Vector3.zero;
            SceneManager.LoadScene(2);
        }
    }
}
