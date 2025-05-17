using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatingHands : MonoBehaviour
{
    //The variables from the controller class
    [SerializeField]
    private InputActionProperty pinchAnimationAction;

    [SerializeField]
    private InputActionProperty gripAnimationAction;

    //The animator object for the Grip and Pinch functions
    public Animator HandAnimator;

    // Update is called once per frame
    void Update()
    {
        HandControlsAnimating();
    }

    void HandControlsAnimating()
    {
        //Sets the value of the action to their respective animation
        float pinchValue = pinchAnimationAction.action.ReadValue<float>();
        float gripValue = gripAnimationAction.action.ReadValue<float>();
        HandAnimator.SetFloat("Trigger", pinchValue);
        HandAnimator.SetFloat("Grip", gripValue);
    }
}

