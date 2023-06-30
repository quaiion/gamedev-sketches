using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel_mov : MonoBehaviour {
    public float speed;
    void Start() {}
    void Update() {
        Vector3 rotVect = transform.rotation.eulerAngles;
        rotVect.z = rotVect.z - speed;
        transform.rotation = Quaternion.Euler(rotVect);
    }
}
