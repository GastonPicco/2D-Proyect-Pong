using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menupaletascript : MonoBehaviour
{
    public float r;
    public float velociadad;
    public campos ypos;
    bool canmove = true;
    bool disparo = false;
    float timer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ypos = FindObjectOfType<campos>();
        //Debug.Log(ypos.Ypos);
        if (Input.GetKey("up") && (gameObject.transform.position.y < 10.5)&&(ypos.Ypos == 8) && (canmove == true))
        {

            transform.position = new Vector3(transform.position.x, transform.position.y + velociadad * Time.fixedDeltaTime, transform.position.z);

            if (r > -5)
            {
                r = r - 100f * Time.deltaTime;
            }
        }
        if (Input.GetKey("down") && (gameObject.transform.position.y > 5.5) && (ypos.Ypos == 8) && (canmove == true))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + - velociadad * Time.fixedDeltaTime, transform.position.z);
            if (r < 5)
            {
                r = r + 100f * Time.deltaTime;
            }
        }
        if (Input.GetKey("up") && (ypos.Ypos == 8) && (canmove == true))
        {

            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z + r);

        }
        if (Input.GetKey("down") && (ypos.Ypos == 8) && (canmove == true))
        {

            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z + r);

        }
        if (Input.GetKeyDown("space"))
        {
            disparo = true;
            canmove = false;   
        }
        if (disparo == true)
        {
            timer += Time.deltaTime;
            if(timer >= 1.8f)
            {
                timer = 0;
                disparo = false;
                canmove = true;
            }
        }
    }
}
