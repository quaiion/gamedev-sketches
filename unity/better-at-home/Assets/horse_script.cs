using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horse_script : MonoBehaviour {
    SpriteRenderer spriteRenderer;
    public float delay;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;

    IEnumerator NextSprite() {
        while(true) {
            spriteRenderer.sprite = sprite1;
            yield return new WaitForSeconds(delay);
            spriteRenderer.sprite = sprite2;
            yield return new WaitForSeconds(delay);
            spriteRenderer.sprite = sprite3;
            yield return new WaitForSeconds(delay);
            spriteRenderer.sprite = sprite4;
            yield return new WaitForSeconds(delay);
        }
    }

    void Start() {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine(NextSprite());
    }

    void Update() {}
}

