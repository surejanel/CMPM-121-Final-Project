using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSteps : MonoBehaviour
{
	public static AudioSource footstepSound;
	// Start is called before the first frame update
	void Start()
    {
		footstepSound = GetComponent<AudioSource>();
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
