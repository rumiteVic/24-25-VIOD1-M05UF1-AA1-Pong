using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    public float speed;
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(horizontal, vertical);

        transform.position += direccion * speed * Time.deltaTime;
    }
}
