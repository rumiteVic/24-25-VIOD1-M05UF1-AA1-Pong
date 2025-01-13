using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    float horizontal;
    float vertical;
    public float speed;
    public bool jugadorA;
    // Update is called once per frame
    void Update()
    {
        if (jugadorA)
        {
            horizontal = Input.GetAxis("HorizontalA");
            vertical = Input.GetAxis("VerticalA");
        }
        else {
            horizontal = Input.GetAxis("HorizontalB");
            vertical = Input.GetAxis("VerticalB");
        }
        

        Vector3 direccion = new Vector3(horizontal, vertical);

        transform.position += direccion * speed * Time.deltaTime;
    }
}
