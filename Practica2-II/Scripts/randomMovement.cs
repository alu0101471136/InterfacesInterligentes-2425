using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMovement : MonoBehaviour {
  [Header("Movement Settings")]
  [SerializeField] private Vector3 firstVector = new Vector3(0, 0, 0);
  [SerializeField] private Vector3 secondVector = new Vector3(0, 0, 0);
  [SerializeField] private Vector3 thirdVector = new Vector3(0, 0, 0);
  // Start is called before the first frame update
  void Start() { }
  // Update is called once per frame
  void Update() {
    if (Input.GetKeyDown(KeyCode.Space)) {
      GameObject.FindWithTag("greenSphere").transform.position = firstVector;
      GameObject.FindWithTag("redCube").transform.position = secondVector;
      GameObject.FindWithTag("blackCylinder").transform.position = thirdVector;
    }
  }
}
