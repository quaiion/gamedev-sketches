using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud_movl : MonoBehaviour {
    public float edge;
    public float speed;
    float start;
    float end;
    void Start() {
        start = transform.position.x;
        end = transform.position.x - edge;
    }
    void Update() {
        if (transform.position.x < end) {
            transform.position = new Vector2(start + edge / 2, transform.position.y);
        } else {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y);
        }
    }
}
