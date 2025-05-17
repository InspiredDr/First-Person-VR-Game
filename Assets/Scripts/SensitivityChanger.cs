using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class SensitivityChanger : MonoBehaviour
{
    public Slider slider;
    public static float sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ActionBasedContinuousTurnProvider>().turnSpeed = 40;
    }

    // Update is called once per frame
    void Update()
    {
        sensitivity = slider.value;
        GetComponent<ActionBasedContinuousTurnProvider>().turnSpeed = sensitivity;
    }
}
