using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIController : MonoBehaviour
{
	public GameObject distText;
	public Transform Player;

	int MoveSpeed = 4;
	int MaxDist = 50;
	int MinDist = 5;
	int randNum = 0;
	float monDist;

	AudioSource aggroRoar;
	AudioSource animalBark;
	AudioSource alienRoar;

	void Start()
	{
		aggroRoar = GetComponent<AudioSource>();
		animalBark = GetComponent<AudioSource>();
		alienRoar = GetComponent<AudioSource>();

		monDist = Vector3.Distance(transform.position, Player.position);

	}

	void Update()
	{
		transform.LookAt(Player);

		monDist = Vector3.Distance(transform.position, Player.position);
		distText.GetComponent<Text>().text = "He's coming: " + monDist;

		Debug.Log(Vector3.Distance(transform.position, Player.position));
        
		if (Vector3.Distance(transform.position, Player.position) >= MinDist)
		{

			transform.position += transform.forward * MoveSpeed * Time.deltaTime;



			if (Vector3.Distance(transform.position, Player.position) >= MaxDist)
			{
				//randNum = Random.Range(0, 2);
				//Here Call any function U want Like Shoot at here or something
				//if (randNum == 0)
				//{
					aggroRoar.Play();
					aggroRoar.pitch = Random.Range(0.8f, 1f);
				//}
				//if (randNum == 1)
				//{
				//	aggroRoar.Play();
				//	aggroRoar.pitch = Random.Range(0.8f, 1f);
				//}
				//if (randNum == 2)
				//{
				//	aggroRoar.Play();
				//	aggroRoar.pitch = Random.Range(0.8f, 1f);
				//}
				//MonsterSteps.footstepSound.volume = MonsterSteps.footstepSound.volume++;
			}

			if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
			{
				MonsterSteps.footstepSound.volume = .2f;
			}

		}
	}
}