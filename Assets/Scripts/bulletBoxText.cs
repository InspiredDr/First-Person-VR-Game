using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBoxText : MonoBehaviour
{
    public TextMesh text;

    // Update is called once per frame
    void Update()
    {
        text.text = this.GetComponentInParent<bulletBox>().quantity.ToString("");
    }
}
