using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secuencia : MonoBehaviour {


    public GameObject pastel;
    public GameObject caja;
    public float lapso_caja = 2f;
    public GameObject mensaje;
    public GameObject fireworks;
    public float lapso_mensaje = 5.2f;
    public AudioSource audioData;

    private Animator animatorCaja;
    bool nosuena = false;

    float timer0 = 0;
    float timer1 = 0;

    int salgoHash = Animator.StringToHash("salgo");
    int nuloStateHash = Animator.StringToHash("Base Layer.salirEstado");

    int llegoStateHash = Animator.StringToHash("Base Layer.pastel");
    // Use this for initialization
    void Start () {
         
        //caja = GameObject.Find("caja");
        fireworks.SetActive(false); // false to hide, true to sho
        mensaje.SetActive(false); // false to hide, true to show
       // caja.SetActive(false); // false to hide, true to show


        if ((caja != null) && (caja.GetComponent<Animator>() != null))
        {
            animatorCaja = caja.GetComponent<Animator>();
        }

        if ((pastel != null) && (pastel.GetComponent<Animator>() != null))
        {
            Debug.Log("Si encontro el pastel");
        }

    }

    // Update is called once per frame
    void Update () {

        
        AnimatorStateInfo stateInfo = pastel.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
        if ( stateInfo.nameHash == llegoStateHash)
        {
            if (timer0 < lapso_caja)
            {
                timer0 += Time.deltaTime;
            }
            else
            {
                animatorCaja.SetTrigger(salgoHash);
            }

            if (timer1 < lapso_mensaje)
            {
                timer1 += Time.deltaTime;
            }
            else
            {

                mensaje.SetActive(true);
                fireworks.SetActive(true);
                if (nosuena == false)
                {
                    audioData.Play();
                    nosuena = true;
                }

                
            }
        }

    }
}
