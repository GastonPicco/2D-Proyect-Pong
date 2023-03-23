using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class campos : MonoBehaviour
{


    public float Ypos;
    public float velocidad;
    float i;
    public pelotamenu CCM;
    bool back = false;
    // Start is called before the first frame update
    void Start()
    {
        Ypos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        Ypos = transform.position.y;
        CCM = FindObjectOfType<pelotamenu>();
        if ((CCM.CamCanMove == true) && (gameObject.transform.position.y >=0))
        {
            i = transform.position.y - velocidad;
            transform.position = new Vector3(transform.position.x, i, -10);
        }

        if (Input.GetKeyDown("escape"))
        {

            back = true;
        }
        if (back == true)
        {
            i = transform.position.y + velocidad* 1.5f;
            transform.position = new Vector3(transform.position.x, i, -10);
        }
        if(gameObject.transform.position.y >= 8)
        {
            back = false;
            transform.position = new Vector3(transform.position.x, 8, -10);
        }
    }
}
