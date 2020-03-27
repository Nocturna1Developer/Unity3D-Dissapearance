using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOn : MonoBehaviour
{
    public GameObject enemy;
    //public GameObject subtitleTrigger;

    void Start()
    {
        //objectiveUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            enemy.SetActive(false);
            //subtitleTrigger.SetActive(false);
        }
    }
}