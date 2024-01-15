using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendProjectile : MonoBehaviour
{

    public float velx, scalex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= -10)
        {

            transform.position += new Vector3(velx, 0f, 0f) * Time.deltaTime;
        }

        if(transform.localScale.x <= 2f)
        {
            transform.localScale += new Vector3(scalex, scalex, scalex) * Time.deltaTime;
        }

        if(transform.localScale.x >= 2f)
        {
            Destroy(gameObject);
        }
    }
}
