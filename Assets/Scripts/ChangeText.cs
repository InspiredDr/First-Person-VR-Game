using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    public TextMesh text;
    public Gun gun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = this.GetComponentInParent<Gun>().numberOfBullets.ToString("");
    }
}
