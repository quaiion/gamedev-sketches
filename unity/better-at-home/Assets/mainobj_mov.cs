using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainobj_mov : MonoBehaviour {
    public float speed;
    float actual_speed;
    float speed_portion;

    IEnumerator OpeningCorout() {
        yield return new WaitForSeconds(38);
        while (actual_speed > 0) {
            actual_speed -= speed_portion;
            yield return null;
        }
        actual_speed = 0;
    }

    void Start() {
        actual_speed = speed;
        speed_portion = speed / 600;
        StartCoroutine(OpeningCorout());
    }

    void Update() {
        transform.position = new Vector2(transform.position.x + actual_speed, transform.position.y);        
    }
}
