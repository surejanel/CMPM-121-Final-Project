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
      // Vector3 direction = player.position - transform.position;
      // float angle = Mathf.Atan2(direction.z, direction.x) * Mathf.Rad2Deg;
      // this.GetComponent<RigidBody>().rotation = angle;
      // direction.Normalize();
      // movement = direction;

      // var transform = enemy.GetComponent<Transform>();
      // var playerPos = player.GetComponent<Transform>().localPosition;
      // var x = playerPos.x;
      // var z = playerPos.z;
      // transform.Translate(x, 0.0f, z);
    }
  }

  void OnTriggerEnter() {
    aggroOn = false;
  }

  void OnTriggerExit() {
    aggroOn = true;
  }
}
