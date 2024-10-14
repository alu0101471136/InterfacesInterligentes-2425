using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCylinder : MonoBehaviour {
  [SerializeField] private Transform sphere;
  [SerializeField] private float speed = 10f;
  private Rigidbody rb;
  void Start() { rb = GetComponent<Rigidbody>(); }
  void FixedUpdate() {
    float movimientoVertical = Input.GetAxis("VerticalIK"); 
    float movimientoHorizontal = Input.GetAxis("HorizontalJL"); 
    Vector3 movimiento = new Vector3(movimientoHorizontal, movimientoVertical, 0);
    rb.velocity = movimiento * speed;
    if (sphere != null) {
      Vector3 lookAt = sphere.position - transform.position;
      rb.MoveRotation(Quaternion.LookRotation(lookAt));
      rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
    }
  }
}