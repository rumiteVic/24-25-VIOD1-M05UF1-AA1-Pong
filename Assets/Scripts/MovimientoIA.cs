using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoIA : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pelota;
    public float speed;
    float vertical;

    // Update is called once per frame
    void Update()
    {
        if(pelota.transform.position.y > transform.position.y)
        {
            vertical = 1;
        }
        if (pelota.transform.position.y < transform.position.y)
        {
            vertical = -1;
        }

        Vector3 direccion = new Vector3(0, vertical).normalized;

        transform.position += direccion * speed * Time.deltaTime;
    }
}
