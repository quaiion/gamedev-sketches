using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_script : MonoBehaviour {
    public float delay;
    public float period;
    public float subperiod;
    public float jump;
    public float jumptime;

    IEnumerator jumpCorout() {
        yield return new WaitForSeconds(delay);
        while(true) {
            transform.position = new Vector2(transform.position.x, transform.position.y + jump);
            yield return new WaitForSeconds(jumptime);
            transform.position = new Vector2(transform.position.x, transform.position.y - jump);
            yield return new WaitForSeconds(subperiod);
            transform.position = new Vector2(transform.position.x, transform.position.y + jump);
            yield return new WaitForSeconds(jumptime);
            transform.position = new Vector2(transform.position.x, transform.position.y - jump);
            yield return new WaitForSeconds(period);
        }
    }

    void Start() {
        StartCoroutine(jumpCorout());
    }

    void Update() {}
}
