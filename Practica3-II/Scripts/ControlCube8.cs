using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCube8 : MonoBehaviour {
  [SerializeField] private Transform sphere;
  [SerializeField] private float speed = 5f;
  // Start is called before the first frame update
  void Start() { }
  // Update is called once per frame
  void Update() {
    if (sphere != null) {
      transform.LookAt(sphere);
      transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
      Debug.DrawRay(transform.position, transform.forward * 10, Color.red);
    } 
  }
}