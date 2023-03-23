using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inicial : MonoBehaviour
{
    // Start is called before the first frame update
    public campos ypos;
    public float velocidad;
    bool Ini = true;
    float x, xpo, timer;
    
    


    void Start()
    {
        x = Random.Range(1f, 5f);
        Debug.Log(x);
        xpo = x;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= 1.8f)
        {
            timer = 0;
            x = Random.Range(1f, 5f);
            Debug.Log(x);
            xpo = x;

        }
        ypos = FindObjectOfType<campos>();
        if (Input.GetKeyDown("space") && (ypos.Ypos > -1) && (ypos.Ypos < 1) && (Ini == true) && (xpo <= 2f) && (xpo >= 0f))
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(400, 100));
            
            Ini = true;
        }
        if (Input.GetKeyDown("space") && (ypos.Ypos > -1) && (ypos.Ypos < 1) && (Ini == true) && (xpo <= 3f) && (xpo > 2f))
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-400, 100));
            
            Ini = true;
        }
        if (Input.GetKeyDown("space") && (ypos.Ypos > -1) && (ypos.Ypos < 1) && (Ini == true) && (xpo <= 4f) && (xpo > 3f))
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(400, -100));
            
            Ini = true;
        }
        if (Input.GetKeyDown("space") && (ypos.Ypos > -1) && (ypos.Ypos < 1) && (Ini == true) && (xpo <= 5f) && (xpo > 4f))
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-400, -100));
            
            Ini = true;
        }
        if (Input.GetKeyDown("e") && (ypos.Ypos > -1) && (ypos.Ypos < 1) && (Ini == true))
        {

            GetComponent<Rigidbody2D>().velocity = Vector2.right * 0;
            transform.position = new Vector3(0f, 0f, 0f);

            Ini = true;
        }
    }
}
