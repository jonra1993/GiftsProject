using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxClick : MonoBehaviour {
    bool mem = false;
    GameObject caja;

    private void OnMouseDown()
    {
        Debug.Log("click");
        if (mem==false){
            mem = true;
            Debug.Log("PrintEvent");
            caja.GetComponent<Animation>().Play();

        }

    }
}
