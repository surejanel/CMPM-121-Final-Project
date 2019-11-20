using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeLight : MonoBehaviour {
  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {
    var transform = this.GetComponent<Transform>();
    transform.Translate(
      1.0f * Random.Range(-0.25f, 0.25f),
      0.0f,
      1.0f * Random.Range(-0.25f, 0.25f)
    );
  }
}
