using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCube6y7 : MonoBehaviour {
  [SerializeField] private Transform sphere;
  [SerializeField] private float speed = 5f;
  // Start is called before the first frame update
  void Start() { }
  // Update is called once per frame
  void Update() {
    if (sphere != null) {
      Vector3 direction = (sphere.position - transform.position).normalized;
      transform.LookAt(sphere);
      transform.Translate(direction * speed * Time.deltaTime, Space.World);
    } 
  }
}