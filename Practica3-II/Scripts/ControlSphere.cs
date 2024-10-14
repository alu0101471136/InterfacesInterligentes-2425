using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSphere : MonoBehaviour {
  [SerializeField] private float speed = 5f;
  // Start is called before the first frame update
  void Start() { }
  // Update is called once per frame
  void Update() {
    // Si le añadimos WS y AD, estamos accediento a los ejes de movimiento de las teclas W y S, y A y D
    float movimientoVertical = Input.GetAxis("VerticalWS"); 
    float movimientoHorizontal = Input.GetAxis("HorizontalAD"); 
    Vector3 movimiento = new Vector3(movimientoHorizontal, movimientoVertical, 0).normalized;
    transform.Translate(movimiento * speed * Time.deltaTime);
  }
}