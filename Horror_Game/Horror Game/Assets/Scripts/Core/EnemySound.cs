using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySound : MonoBehaviour
{

public GameObject Player;
public AudioClip scareSound;

void OnTriggerEnter(Collider other)//Check if something has entered the trigger ( and declares this object in "other" )
{
	if(other.GetComponent<Collider>().tag == Player.tag) //Checks if player is in trigger
	{
		GetComponent<AudioSource>().PlayOneShot(scareSound);
		
	}
}
}