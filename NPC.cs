using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 5;
    public int level = 2;
    // Declaramos las vidas y el nivel del NPC y la velocidad
    public float speed = 1.5f;
    void Start()
    {
        health += level;
        print("Nº de vidas" + health);
        // Actualizamos la vida y la mostramos por pantalla
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}