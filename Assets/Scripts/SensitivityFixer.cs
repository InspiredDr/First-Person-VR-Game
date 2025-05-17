using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SensitivityFixer : MonoBehaviour
{
    void Update()
    {
        GetComponent<ActionBasedContinuousTurnProvider>().turnSpeed = SensitivityChanger.sensitivity;
    }
}
