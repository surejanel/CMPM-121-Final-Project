using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distDisplay : MonoBehaviour
{
	public GameObject distText;
	public static float monDist;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//Debug.Log(monDist);
		distText.GetComponent<Text>().text = "It's coming: " + monDist;
	}
}
