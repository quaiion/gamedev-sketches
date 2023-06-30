using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarSpeech : MonoBehaviour {
    SpriteRenderer spriteRenderer;
    public float delay;
    bool spaceClicked;
    public Sprite dialEmpty;
    public Sprite dialB11;
    public Sprite dialB12;
    public Sprite dialB21;
    public Sprite dialB22;
    public Sprite dialB3;
    public Sprite dialB41;
    public Sprite dialB42;
    public Sprite dialB5;

    IEnumerator DialCorout() {
        spriteRenderer.sprite = dialEmpty;
        yield return new WaitForSeconds(42);
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialB11;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialB12;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialB21;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialB22;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialB3;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialB41;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialB42;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialB5;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
    }

    void Start() {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine(DialCorout());
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            spaceClicked = true;
        }
    }
}

