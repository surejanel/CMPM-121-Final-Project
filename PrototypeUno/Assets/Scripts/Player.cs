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
    if (Input.GetButton("Horizontal")) {
      var horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;
      transform.Rotate(0, horizontalMove, 0);
    }


    if(controller.isGrounded) {
      moveDirection = new Vector3(
        0.0f,
        0.0f,
        Input.GetAxis("Vertical")
      );
      moveDirection *= speed;
    }

    moveDirection.y -= gravity * Time.deltaTime;

    Vector3 move = new Vector3(
      moveDirection.x * Vector3.forward.x,
      moveDirection.y * Vector3.forward.y,
      moveDirection.z
    );

    controller.Move(transform.rotation * moveDirection * Time.deltaTime);
  }
}
