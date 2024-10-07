using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class closerSpheres : MonoBehaviour {
  // Start is called before the first frame update
  void Start() { 
    GameObject[] secondGroup = GameObject.FindGameObjectsWithTag("secondGroup");
    Vector3 redCubePosition = GameObject.FindWithTag("redCube").transform.position;
    int closerDistance = int.MaxValue;
    GameObject closestSphere = null;
    foreach (GameObject sphere in secondGroup) {
      Vector3 spherePosition = sphere.transform.position;
      if (Vector3.Distance(redCubePosition, spherePosition) < closerDistance) {
        closerDistance = (int)Vector3.Distance(redCubePosition, spherePosition);
        closestSphere = sphere;
      }
    }
    if (closestSphere != null) { 
      Vector3 newSpherePosition = closestSphere.transform.position;
      closestSphere.GetComponent<Transform>().position = new Vector3(newSpherePosition.x, newSpherePosition.y + 2, newSpherePosition.z);
    }
  }
  // Update is called once per frame
  void Update() {
    GameObject[] allSpheres = GameObject.FindGameObjectsWithTag("firstGroup").Concat(GameObject.FindGameObjectsWithTag("secondGroup")).ToArray();
    int farthestDistance = -1;
    Vector3 redCubePosition = GameObject.FindWithTag("redCube").transform.position;
    GameObject farthestSphere = null;
    foreach (GameObject sphere in allSpheres) {
      Vector3 spherePosition = sphere.transform.position;
      if (Vector3.Distance(redCubePosition, spherePosition) > farthestDistance) {
        farthestDistance = (int)Vector3.Distance(redCubePosition, spherePosition);
        farthestSphere = sphere;
      }
    }
    if (Input.GetKeyDown(KeyCode.Space) && farthestSphere != null) {
        Debug.Log("farthestSphere: " + farthestSphere + ", changing color!!");
      farthestSphere.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
  }
}
