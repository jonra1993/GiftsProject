using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer : MonoBehaviour {

    bool mem = false;
    public GameObject Dra;
    // Update is called once per frame
    // Use this for initialization
    void Start()
    {
        Dra.SetActive(false);
    }

    public void toggle () {

        if (mem == false)
        {
            Dra.SetActive(true);
            mem = true;
        }
        else
        {
            Dra.SetActive(false);
            mem = false;

        }
    }
}
