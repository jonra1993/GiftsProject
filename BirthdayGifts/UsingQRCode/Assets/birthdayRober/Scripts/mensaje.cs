using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mensaje : MonoBehaviour {
    public GameObject Target;
    public GameObject cat;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
         if (Target.activeSelf == true)
         {
            print("yyyy");
            //cat.SetActive(false); // false to hide, true to show
         }
         else
         {
            print("xxxx");
            //cat.SetActive(true);
         }
    }

}
