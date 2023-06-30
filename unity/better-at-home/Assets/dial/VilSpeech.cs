using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VilSpeech : MonoBehaviour {
    SpriteRenderer spriteRenderer;
    public float delay;
    bool spaceClicked;
    public Sprite dialEmpty;
    public Sprite dialA1;
    public Sprite dialA21;
    public Sprite dialA22;
    public Sprite dialA31;
    public Sprite dialA32;
    public Sprite dialA33;
    public Sprite dialA4;
    public Sprite dialA5;

    IEnumerator DialCorout() {
        spriteRenderer.sprite = dialEmpty;
        yield return new WaitForSeconds(42);
        spriteRenderer.sprite = dialA1;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialA21;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialA22;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialA31;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialA32;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialA33;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialA4;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spriteRenderer.sprite = dialEmpty;
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        spaceClicked = false;
        yield return new WaitUntil(() => spaceClicked);
        yield return new WaitForSeconds(delay);
        spriteRenderer.sprite = dialA5;
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

