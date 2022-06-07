using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound 
{
    public string name;

    public AudioClip clip;

    [HideInInspector]
    public AudioSource source;
}
