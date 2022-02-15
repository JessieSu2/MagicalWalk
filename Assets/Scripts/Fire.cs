using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public ParticleSystem sprite;
    public AudioSource audio;
    public bool isOn = false;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<ParticleSystem>();
        sprite.Stop();
    }

    // Update is called once per frame
    public void ToggleVisibility()
    {
        isOn = true;
        sprite.Play();
        audio.Play();
    }
}
