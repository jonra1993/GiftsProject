using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secuencia : MonoBehaviour {

    
    public GameObject caja;
    public float lapso_caja = 2f;
    public GameObject mensaje;
    public GameObject fireworks;
    public float lapso_mensaje = 5.2f;

    private Animator animatorCaja;

    float timer0 = 0;
    float timer1 = 0;

    int salgoHash = Animator.StringToHash("salgo");
    int nuloStateHash = Animator.StringToHash("Base Layer.estadoNulo");
    // Use this for initialization
    void Start () {

        //caja = GameObject.Find("caja");
        fireworks.SetActive(false); // false to hide, true to sho
        mensaje.SetActive(false); // false to hide, true to show
        if ((caja != null) && (caja.GetComponent<Animator>() != null))
        {
            animatorCaja = caja.GetComponent<Animator>();
        }

    }

    // Update is called once per frame
    void Update () {
        if (timer0 < lapso_caja)
        {
            timer0 += Time.deltaTime;
        }
        else
        {
            animatorCaja.SetTrigger(salgoHash);
        }

        if(timer1 < lapso_mensaje)
        {
            timer1 += Time.deltaTime;
        }
        else
        {
            Debug.Log("PrintEvent");
            mensaje.SetActive(true); 
            fireworks.SetActive(true);
        }
    }
}
