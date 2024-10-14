using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculateVelocity : MonoBehaviour {
  [SerializeField] private float velocity;
  // Start is called before the first frame update
  void Start() { }
  // Update is called once per frame
  void Update() {
    float result = 0;
    float horizontalAxis = Input.GetAxis("Horizontal");
    float verticalAxis = Input.GetAxis("Vertical");
    if (Input.GetKeyDown(KeyCode.UpArrow)) {
      result = velocity * verticalAxis;
      Debug.Log("Up Arrow, Velocity: " + result);
    } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
      result = velocity * verticalAxis;
      Debug.Log("Down Arrow, Velocity: " + result);
    } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
      result = velocity * horizontalAxis;
      Debug.Log("Left Arrow, Velocity: " + result);
    } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
      result = velocity * horizontalAxis;
      Debug.Log("Right Arrow, Velocity: " + result);
    }
  }
}
