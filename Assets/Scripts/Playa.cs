using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playa : MonoBehaviour
{
    [SerializeField, Range(0.1f, 10f)] //Range(-10f, 10f)
    float moveSpeed;

    void Update()
    {
        //Axis es la direccion en que se mueve
        Vector2 axis = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.Translate(axis * moveSpeed * Time.deltaTime);
    }
}