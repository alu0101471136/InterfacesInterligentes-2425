using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowVector : MonoBehaviour {
  [SerializeField] private Vector3 firstVector = new Vector3(0, 0, 0);
  [SerializeField] private Vector3 seconVector = new Vector3(0, 0, 0);
  // Start is called before the first frame update
  void Start() { 
    Debug.Log("The first vector magnitude is " + firstVector.magnitude);
    Debug.Log("The second vector magnitude is " + seconVector.magnitude);
    if (firstVector.y > seconVector.y) {
      Debug.Log("The first vector is at a higher altitude.");
    } else if (seconVector.y > firstVector.y) {
      Debug.Log("The second vector is at a higher altitude.");
    } else {
      Debug.Log("Both vectors are at the same altitude.");
    }
    Debug.Log("The angle between the vectors is " + Vector3.Angle(firstVector, seconVector) + " degrees.");
    Debug.Log("The distance between the vectors is " + Vector3.Distance(firstVector, seconVector));
  }
  
  // Update is called once per frame
  void Update() { }
}
