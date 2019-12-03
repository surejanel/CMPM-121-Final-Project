using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trapTrigger : MonoBehaviour
{
    public GameObject pressurePlate;
    public GameObject trap;
    Transform trapTransform;

    // Start is called before the first frame update
    void Start()
    {
      trapTransform = trap.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
	  {

		  // Make the scale on the Y increase.
	   	// Then make it so if you connect with the hidden cube, the scene resets. Using these two lines:
		   PlayerDeathSFX.PlayerDeathSound.Play();

       //spike go up
       trapTransform.position = Vector3.Lerp( trapTransform.position,
                                              new Vector3(trapTransform.position.x, 1,
                                              trapTransform.position.z),
                                              1);

       //reload when the player collides with it
       if(other.gameObject.CompareTag("Player")) {
         SceneManager.LoadScene("Prototype One");
       }

       if(other.gameObject.CompareTag("Monster")) {
         Debug.Log("got em (the monster)" );
         other.gameObject.SetActive(false);
       }


	  }

}
