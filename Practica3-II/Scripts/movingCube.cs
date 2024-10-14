using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class movingCube : MonoBehaviour {
  [SerializeField] private float speed;
  [SerializeField] private Vector3 moveDirection = Vector3.forward;
  // Start is called before the first frame update
  void Start() {
    Vector3 startPosition = transform.position;
    startPosition.y = 0;
    transform.position = startPosition;
    if (speed <= 1.0f) {
      Debug.LogWarning("Speed mustn't be less than 1.0f");
      speed = 2f;
    }
  }
  // Update is called once per frame
  void Update() {
    transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
  }
}
