using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cajaScript : MonoBehaviour {
    Animator anim;
    int salgoHash = Animator.StringToHash("salgo");
    int nuloStateHash = Animator.StringToHash("Base Layer.estadoNulo");

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown(KeyCode.Space) && stateInfo.nameHash == nuloStateHash)
        {
            anim.SetTrigger(salgoHash);
        }
    }
}
