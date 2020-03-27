using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    public AudioClip pickupSound;

    private AudioSource audioSource;

    [SerializeField] float restoreAngle = 90f;
    [SerializeField] float addIntensity = 0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            other.GetComponent<AudioSource>().PlayOneShot(pickupSound);
            other.GetComponent<Collider>().GetComponentInChildren<FlashlightDecay>().RestoreLightAngle(restoreAngle);
            other.GetComponent<Collider>().GetComponentInChildren<FlashlightDecay>().AddLightIntensity(addIntensity);
            
        }
    }

}