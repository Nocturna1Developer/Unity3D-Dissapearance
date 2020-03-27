using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveEnter : MonoBehaviour
{
    public GameObject objectiveUI;
    //public GameObject subtitleTrigger;

    void Start()
    {
        objectiveUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            objectiveUI.SetActive(true);
            //subtitleTrigger.SetActive(false);
        }
    }
}