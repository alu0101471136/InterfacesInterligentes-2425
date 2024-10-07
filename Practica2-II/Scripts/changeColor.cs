using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class changeColor : MonoBehaviour {
  // Start is called before the first frame update
  void Start() { }
  // Update is called once per frame
  void Update() {
    if (Input.GetKeyDown(KeyCode.UpArrow)) {
      GameObject.FindWithTag("redCube").GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    } else if (Input.GetKeyDown(KeyCode.C)) {
      GameObject.FindWithTag("blackCylinder").GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
  }
}
