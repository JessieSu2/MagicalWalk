using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowText : MonoBehaviour
{
    public GameObject uiObject;

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player") 
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
            Debug.Log("show ui");
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        uiObject.SetActive(false);
    }
}
