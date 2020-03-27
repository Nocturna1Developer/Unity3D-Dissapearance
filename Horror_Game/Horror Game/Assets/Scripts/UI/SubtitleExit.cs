using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtitleExit : MonoBehaviour
{
    public GameObject subtitleUI;
    //public GameObject subtitleTrigger;

    void Start()
    {
        subtitleUI.SetActive(false);
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            subtitleUI.SetActive(false);
            //subtitleTrigger.SetActive(true);
        }
    }
}