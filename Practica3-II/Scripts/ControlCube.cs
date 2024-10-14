using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCube : MonoBehaviour {
  [SerializeField] private float speed = 5f;
  // Start is called before the first frame update
  void Start() { }
  // Update is called once per frame
  void Update() {
    // Si solamente ponemos Vertical y Horizontel, estamos accediento a los ejes de movimiento de las flechas del teclado
    float movimientoVertical = Input.GetAxis("Vertical"); 
    float movimientoHorizontal = Input.GetAxis("Horizontal"); 
    Vector3 movimiento = new Vector3(movimientoHorizontal, movimientoVertical, 0);
    transform.Translate(movimiento * speed * Time.deltaTime);
  } 
}