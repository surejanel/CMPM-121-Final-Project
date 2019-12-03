using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTres : MonoBehaviour {
  public GameObject enemy;

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
      Vector3 newPosition;
      if(enemy.activeSelf) {
        newPosition = new Vector3(0.0f, 2.0f, -64.0f);
      } else {
        newPosition = new Vector3(0.0f, 1002.0f, 0.0f);
      }
      player.enabled = false;
      transform.position = newPosition;
      player.enabled = true;
    }
  }
}
