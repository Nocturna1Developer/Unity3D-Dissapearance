using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePickup : MonoBehaviour
{
    public GameObject HUDnote;
    public GameObject noteOnGround;

    void Start()
    {
        HUDnote.SetActive(false);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            HUDnote.SetActive(true);
            noteOnGround.SetActive(false);
        }
    }
}
