using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento ajustable

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        // Capturar entradas del usuario
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Crear vector de movimiento
        Vector3 movement = new Vector3(moveX, 0, moveZ);

        // Mover el objeto
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
}
