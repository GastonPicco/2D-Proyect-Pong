using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimientos : MonoBehaviour
{
    
    // Start is called before the first frame update
    public float r;
    public float velociadad;
    public campos ypos;
    bool canmove = true;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ypos = FindObjectOfType<campos>();
        //Debug.Log(ypos.Ypos);
        if (Input.GetKey("up")&&(gameObject.transform.position.y < 2.5) && (ypos.Ypos <= 1) && (ypos.Ypos >= -1) && (canmove == true))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + velociadad * Time.deltaTime, transform.position.z);

            if (r > -5)
            {
                r = r - 100f *Time.deltaTime;
            }
        }
        if (Input.GetKey("down")&&(gameObject.transform.position.y > -2.5) && (ypos.Ypos <= 1) && (ypos.Ypos >= -1) && (canmove == true))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + - velociadad * Time.deltaTime, transform.position.z);
            if (r < 5)
            {
                r = r + 100f*Time.deltaTime;
            }
        }
        if (Input.GetKey("up") && (ypos.Ypos <= 1) && (ypos.Ypos >= -1) && (canmove == true))
        {
            
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z + r);

        }
        if (Input.GetKey("down") && (ypos.Ypos <= 1) && (ypos.Ypos >= -1) && (canmove == true))
        {

            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z + r);

        }
    }
}
