using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secuencia : MonoBehaviour {
    GameObject cubo;
    public float lapso = .5f;
    private Animator animator;
    float timer = 0;

    // Use this for initialization
    void Start () {
        cubo = GameObject.Find("Cube");

        if ((cubo != null) && (cubo.GetComponent<Animator>() != null))
        {
            animator = cubo.GetComponent<Animator>();
        }

    }

    // Update is called once per frame
    void Update () {
        if (timer < lapso)
        {
            timer += Time.deltaTime;
        }
        else
        {
            if (animator != null) animator.SetTrigger("regalo");
            timer = 0;
        }
    }
}
