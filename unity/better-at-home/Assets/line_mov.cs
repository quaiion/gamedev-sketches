using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line_mov : MonoBehaviour {
    public float speed;
    float actual_speed;
    float speed_portion;
    float diff;
    float accml;

    float getChildPos(int nChild) {
        return transform.GetChild(nChild).transform.position.x;
    }

    IEnumerator OpeningCorout() {
        yield return new WaitForSeconds(38);
        while (actual_speed < speed) {
            actual_speed += speed_portion;
            yield return null;
        }
    }

    void Start() {
        accml = 0;
        diff = getChildPos(1) - getChildPos(0);
        actual_speed = 0;
        speed_portion = speed / 600;
        StartCoroutine(OpeningCorout());
    }

    void Update() {
        if (accml > diff) {
            transform.position = new Vector2(transform.position.x + diff, transform.position.y);
            accml = 0;
        } else {
            transform.position = new Vector2(transform.position.x - actual_speed, transform.position.y);
            accml += actual_speed;
        }
    }
}
