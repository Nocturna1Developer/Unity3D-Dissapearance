using UnityEngine;
using System.Collections;

namespace SunTemple
{
    public class DoorKey : MonoBehaviour
    {
        public AudioClip pickupSound;

        private AudioSource audioSource;

        public bool inTrigger;

        public Component doorScript;

        void Start() 
        {
            doorScript.GetComponent<DoorScript>().enabled = false;
        }

        void Update()
        {
            if (inTrigger)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    GetComponent<AudioSource>().PlayOneShot(pickupSound);
                    doorScript.GetComponent<DoorScript>().enabled = true;
                    Destroy(gameObject);
                }
            }
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                inTrigger = true;
            }
        }

        void OnGUI()
        {
            if (inTrigger)
            {
                GUI.Box(new Rect(0, 0, 100, 100), "Press E to Pickup");
           }
        }
    }
}