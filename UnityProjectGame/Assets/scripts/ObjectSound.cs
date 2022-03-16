using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSound : MonoBehaviour
{

    [SerializeField] private AudioSource sawAudioSource;
    void Update()
    {
        sawAudioSource.Play();
    }
}
