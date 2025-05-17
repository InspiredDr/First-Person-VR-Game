using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicChanger : MonoBehaviour
{
    public Slider slider;
    public static float volume;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().volume = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        volume = slider.value;
        GetComponent<AudioSource>().volume = volume;
    }
}
