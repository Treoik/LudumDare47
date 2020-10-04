using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip errorClip;
    [SerializeField]
    private AudioClip selectClip;

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    public void PlayErrorClip()
    {
        source.clip = errorClip;
        source.Play();
    }

    public void PlaySelectClip()
    {
        source.clip = selectClip;
        source.Play();
    }
}
