using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class TriggerPlayable : MonoBehaviour
{
    public PlayableDirector director;
    // Start is called before the first frame update
    void Start()
    {
        director = GetComponent<PlayableDirector>();

    }
    public void lanterns() {
        director.Play();    
    }
}
