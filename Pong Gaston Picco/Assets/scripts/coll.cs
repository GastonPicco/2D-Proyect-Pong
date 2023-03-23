using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class coll
    : MonoBehaviour
{
    public Text puntaje1;
    public Text puntaje2;
    int puntos = 0;
    int puntos2 = 0;
    public float velocidad;
    public AudioSource clip;
    public AudioSource clip1;

    // Start is called before the first frame update
    void Start()
    {
        puntaje1.text = puntos.ToString();

        puntaje2.text = puntos2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        puntaje1.text = puntos.ToString();

        puntaje2.text = puntos2.ToString();
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "paredI")
        {

            puntos = puntos + 1;
            transform.position = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody2D>().velocity = Vector2.right * velocidad;
            clip.Play();

        }
        if (coll.gameObject.tag == "paredD")
        {

            puntos2 = puntos2 + 1;
            transform.position = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody2D>().velocity = Vector2.right * velocidad;
            clip.Play();


        }
        if (coll.gameObject.tag == "paleta")
        {
            clip1.Play();
        }


    }
}
