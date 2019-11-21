using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
  CharacterController controller;
  private Vector3 moveDirection = Vector3.zero;
  float speed;
  float jumpSpeed;
  float gravity;

  // Start is called before the first frame update
  void Start() {
    controller = this.GetComponent<CharacterController>();

    speed = 10.0f;
    gravity = 20.0f;
  }

  // Update is called once per frame
  void Update() {
    MovePlayer();
  }

  void MovePlayer() {
    if(controller.isGrounded) {
      moveDirection = new Vector3(
        Input.GetAxis("Horizontal"),
        0.0f,
        Input.GetAxis("Vertical")
      );
      moveDirection *= speed;
    }

    moveDirection.y -= gravity * Time.deltaTime;

    controller.Move(moveDirection * Time.deltaTime);
  }
}
