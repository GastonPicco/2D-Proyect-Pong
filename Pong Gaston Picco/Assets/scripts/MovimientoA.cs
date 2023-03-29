using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoA : MonoBehaviour
{
    
    // Start is called before the first frame update
    public float velociadad;
    public float r;
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
        if (Input.GetKey("w") && (gameObject.transform.position.y < 2.5) && (ypos.Ypos <= 1) && (ypos.Ypos >= -1) && (canmove == true))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + velociadad * Time.deltaTime, transform.position.z);

            if (r > -5)
            {
                r = r - 100f * Time.deltaTime;
            }
        }
        if (Input.GetKey("s") && (gameObject.transform.position.y > -2.5) && (ypos.Ypos <= 1) && (ypos.Ypos >= -1) && (canmove == true))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + -velociadad * Time.deltaTime, transform.position.z);
            if (r < 5)
            {
                r = r + 100f * Time.deltaTime;
            }
        }
        if (Input.GetKey("w") && (ypos.Ypos <= 1) && (ypos.Ypos >= -1) && (canmove == true))
        {

            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z - r);

        }
        if (Input.GetKey("s") && (ypos.Ypos <= 1) && (ypos.Ypos >= -1) && (canmove == true))
        {

            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z - r);

        }
    }
}
