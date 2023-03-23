using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelotamenu : MonoBehaviour
{
    public bool CamCanMove = false;
    bool disparo = false;
    public float velocidad;
    public campos ypos;
    float i;
    bool jugar = false;
    bool salir = false;
    public AudioSource clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocidad = 5 * Time.deltaTime;
        ypos = FindObjectOfType<campos>();
        if(ypos.Ypos <= 0.03)
        {
            CamCanMove = false;
        }
        if (Input.GetKey("space"))
        {
            disparo = true;
        }
        if (disparo == true)
        {
            i = transform.position.x - velocidad;
            transform.position = new Vector3(i, transform.position.y, 0);
            
        }
        if ((gameObject.transform.position.x <= 1.9) && (gameObject.transform.position.y < 10.4f)&&(gameObject.transform.position.y > 8.6f))
        {
            disparo = false;
            transform.position = new Vector3(5.3f, transform.position.y, 0f);
            clip.Play();
            CamCanMove = true;
        }
        if ((gameObject.transform.position.x <= 1.9) && (gameObject.transform.position.y < 7.53f) && (gameObject.transform.position.y > 5.7f))
        {
            disparo = false;
            transform.position = new Vector3(5.3f, transform.position.y, 0f);
            Application.Quit();
        }
        if ((gameObject.transform.position.x <= -6.65) && (gameObject.transform.position.y < 12f) && (gameObject.transform.position.y > 4f))
        {
            disparo = false;
            transform.position = new Vector3(5.3f, transform.position.y, 0f);
        }



    }
}
    

