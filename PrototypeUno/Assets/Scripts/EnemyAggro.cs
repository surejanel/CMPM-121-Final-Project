using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAggro : MonoBehaviour {
  public GameObject player;
  public GameObject enemy;
  bool aggroOn;

  // Start is called before the first frame update
  void Start() {
    aggroOn = false;
  }

  // Update is called once per frame
  void Update() {
    if(aggroOn) {
      // update enemy position
      var transform = enemy.GetComponent<Transform>();
      var playerPos = player.GetComponent<Transform>().localPosition;
      transform.Translate(playerPos.x, 4.0f, playerPos.z);
    }
  }

  void OnTriggerEnter() {
    aggroOn = false;
  }

  void OnTriggerExit() {
    aggroOn = true;
  }
}
