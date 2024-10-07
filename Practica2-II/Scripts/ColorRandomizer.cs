using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomizer : MonoBehaviour {
  [SerializeField] private int frameInterval = 120;
  private int frameCount = 0;
  // Start is called before the first frame update
  void Start() { }
  

  // Update is called once per frame
  void Update() {
    Vector3 colorVector = new Vector3(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    if (frameCount == frameInterval) {
      frameCount = 0;
      GetComponent<Renderer>().material.color = new Color(colorVector.x, colorVector.y, colorVector.z);
    } 
    frameCount++;
  }
}
