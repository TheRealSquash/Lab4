using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaAnimator : MonoBehaviour {
    private Animator anim;
    private SantaController sc;

    // Start is called before the first frame update
    void Start() {
        anim = GetComponent<Animator>();
        sc = GetComponent<SantaController>();
    }

    // Update is called once per frame
    void Update() {
        SetParameters();
    }

    private void SetParameters() {
        anim.SetBool("running", sc.IsRunning());
        anim.SetBool("crawling", sc.IsCrawling());
    }
}
