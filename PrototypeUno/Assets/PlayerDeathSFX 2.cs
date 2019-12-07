using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathSFX : MonoBehaviour
{
	public static AudioSource PlayerDeathSound;
	// Start is called before the first frame update
	void Start()
	{
		PlayerDeathSound = GetComponent<AudioSource>();
		//footstepSound.Play();
		//footstepSound.volume = Random.Range(0.2f, .5f);
	}

	// Update is called once per frame
	void Update()
	{
		//footstepSound.Play();
		//footstepSound.volume = Random.Range(0.2f, .5f);
	}
}
