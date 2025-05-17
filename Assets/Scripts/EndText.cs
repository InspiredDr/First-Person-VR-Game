using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndText : MonoBehaviour
{
    private TextMesh text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Health.isDead)
        {
            text.text = "YOU LOSE";
        }
        else
        {
            text.text = "YOU WIN";
        }
    }
}
