using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAR;

/* https://www.youtube.com/watch?v=7-2LMW26xoM&t=507s */
public class Extended : MonoBehaviour {
    public GameObject Puntero;
    public GameObject Message;
    public GameObject Target;
    public GameObject ContainerTarget;
    public float timeActiveOnTargetLose = .1f;

    bool detected = false;
    float timer = 0;

    // Use this for initialization
    void Start () {
        ContainerTarget.transform.SetParent(Target.transform);
        timer = timeActiveOnTargetLose+1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Target.activeSelf==true)
        {
            timer = 0f;
            Message.SetActive(false);
            Puntero.SetActive(false);
        }
        else
        {
            if (timer < timeActiveOnTargetLose)
            {
                ContainerTarget.transform.SetParent(this.transform);
                timer += Time.deltaTime;

            }
            else 
            {
                ContainerTarget.transform.SetParent(Target.transform);
                Message.SetActive(true);
                Puntero.SetActive(true);


            }

        }
		
	}
}
