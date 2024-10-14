using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCubeKinematic : MonoBehaviour {
  [SerializeField] private Transform sphere;
  [SerializeField] private float speed = 10f;
  private Rigidbody rb;
  void Start() { rb = GetComponent<Rigidbody>(); }
  void FixedUpdate() {
    if (sphere != null) {
      Vector3 spherePos = sphere.position;
      Vector3 lookAt = spherePos - transform.position;
      rb.MoveRotation(Quaternion.LookRotation(lookAt));
      rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
    } 
  }
}