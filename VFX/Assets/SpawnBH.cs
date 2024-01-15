using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBH : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}
