using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour {
  // Use this for initialization
  CharacterController cc;
  AudioSource footstepSound;

  void Start() {
    cc = GetComponent<CharacterController>();
    footstepSound = GetComponent<AudioSource>();
  }

  // Update is called once per frame
  void Update() {
    if (cc.isGrounded == true && cc.velocity.magnitude > 2f && GetComponent<AudioSource>().isPlaying == false) {
      footstepSound.Play();
      footstepSound.pitch = Random.Range(0.8f, 1f);
      //footstepSound.volume = Random.Range(0.8f, 1.1f);
    }
    if (cc.isGrounded == true && cc.velocity.magnitude == 0f && GetComponent<AudioSource>().isPlaying == true) {
      GetComponent<AudioSource>().Stop();
    }
  }
}
