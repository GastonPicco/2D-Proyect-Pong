using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimientos : MonoBehaviour
{
    
    // Start is called before the first frame update
    float i;
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
        velociadad = 5 * Time.deltaTime;
        if (Input.GetKey("up")&&(gameObject.transform.position.y < 2.5) && (ypos.Ypos <= 1) && (ypos.Ypos >= -1) && (canmove == true))
        {
            i = transform.position.y + velociadad;
            transform.position = new Vector3(transform.position.x, i , 0);
            
            if (r > -5)
            {
                r = r - 0.1f;
            }
        }
        if (Input.GetKey("down")&&(gameObject.transform.position.y > -2.5) && (ypos.Ypos <= 1) && (ypos.Ypos >= -1) && (canmove == true))
        {
            i = transform.position.y - velociadad;
            transform.position = new Vector3(transform.position.x, i , 0);
            if (r < 5)
            {
                r = r + 0.1f;
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
