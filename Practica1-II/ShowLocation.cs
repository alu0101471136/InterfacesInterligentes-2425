using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLocation : MonoBehaviour {
  void Start() {
    Debug.Log("Posición del objeto con tag " + gameObject.tag + ": " + transform.position);
  }
}
