using UnityEngine;
using System.Collections;

public class AudioTrigger : MonoBehaviour
{
    public AudioClip supriseSound;

    private AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<AudioSource>().PlayOneShot(supriseSound);
        Destroy(gameObject);
    }
}
