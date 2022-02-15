using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLantern : MonoBehaviour
{
    int fireNum = 0;
    public TriggerPlayable trigger;
    public AudioSource audio;
    void Start()
    {
        //trigger = GetComponent<TriggerPlayable>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckForLantern();
            if (fireNum == 3)
            {
                audio.Play();
                trigger.lanterns();
            }
        }
    }

    public void CheckForLantern()
    {
        GameObject[] fires = GameObject.FindGameObjectsWithTag("Fire");

        foreach (GameObject Fire in fires)
        {
            float dist = Vector3.Distance(transform.position, Fire.transform.position);
            Fire firestart = Fire.GetComponent<Fire>();
            if (dist < 15f && !firestart.isOn)
            {
                firestart.ToggleVisibility();
                fireNum++;
            }
        }
    } 
}
