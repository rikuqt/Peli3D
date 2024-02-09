using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameralle : MonoBehaviour
{
   public float speed = 1f;
 
  void Update() {
    if (Input.GetKey(KeyCode.A)) {
      transform.position += Vector3.left * Time.deltaTime * speed;
    }
  }
}

