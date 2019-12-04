using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportDos : MonoBehaviour {
  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {

  }

  void OnTriggerEnter(Collider other) {
    if(other.tag == "Player") {
      CharacterController player = other.GetComponent<CharacterController>();
      var transform = other.GetComponent<Transform>();
      Vector3 newPosition = new Vector3(0.0f, 2.0f, 197.0f);
      player.enabled = false;
      transform.position = newPosition;
      player.enabled = true;
    }

  if(other.tag == "Monster") {
    GameObject monster = other.gameObject;
    var transform = other.GetComponent<Transform>();
    Vector3 newPosition = new Vector3(0.0f, 2.0f, 197.0f);
    monster.SetActive(false);
    transform.position = newPosition;
    monster.SetActive(true);
  }


 }
}
