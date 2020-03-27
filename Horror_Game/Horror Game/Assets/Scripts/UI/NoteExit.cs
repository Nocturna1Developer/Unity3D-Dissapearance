using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteExit : MonoBehaviour
{
    public GameObject HUDnote;
    public GameObject noteOnGround;

    void Start()
    {
        HUDnote.SetActive(false);
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            HUDnote.SetActive(false);
            noteOnGround.SetActive(true);
        }
    }
}