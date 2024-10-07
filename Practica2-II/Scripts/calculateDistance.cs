using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculateDistance : MonoBehaviour {
  // Start is called before the first frame update
  void Start() {  
    Transform sphere = GetComponent<Transform>();
    Transform cube = GameObject.FindWithTag("redCube").GetComponent<Transform>();
    Transform cylinder = GameObject.FindWithTag("blackCylinder").GetComponent<Transform>();

    float distance1 = Vector3.Distance(sphere.position, cube.position);
    float distance2 = Vector3.Distance(sphere.position, cylinder.position);

    Debug.Log("Distance between sphere and red cube: " + distance1);
    Debug.Log("Distance between sphere and black cylinder: " + distance2);
  }
  // Update is called once per frame
  void Update() {
      
  }
}
