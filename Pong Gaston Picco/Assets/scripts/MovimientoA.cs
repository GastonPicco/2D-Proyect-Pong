using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoA : MonoBehaviour
{
    
    // Start is called before the first frame update
    float i;
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
        velociadad = 5 * Time.deltaTime;
        ypos = FindObjectOfType<campos>();
        //Debug.Log(ypos.Ypos);
        if (Input.GetKey("w") && (gameObject.transform.position.y < 2.5) && (ypos.Ypos <= 1) && (ypos.Ypos >= -1) && (canmove == true))
        {
            i = transform.position.y + velociadad;
            transform.position = new Vector3(transform.position.x, i, 0);

            if (r > -5)
            {
                r = r - 0.1f;
            }
        }
        if (Input.GetKey("s") && (gameObject.transform.position.y > -2.5) && (ypos.Ypos <= 1) && (ypos.Ypos >= -1) && (canmove == true))
        {
            i = transform.position.y - velociadad;
            transform.position = new Vector3(transform.position.x, i, 0);
            if (r < 5)
            {
                r = r + 0.1f;
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
