using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicFixer : MonoBehaviour
{
    void Update()
    {
        GetComponent<AudioSource>().volume = MusicChanger.volume;
    }
}
