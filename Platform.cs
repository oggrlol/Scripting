using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public bool isActive;

    // Prevent rapid bouncing
    private float lastDirectionChangeTime = 0f;
    public float directionChangeCooldown = 0.2f;

    void Update()
    {
        if (isActive)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "PlatformStop")
        {
            if (Time.time - lastDirectionChangeTime > directionChangeCooldown)
            {
                direction *= -1;
                lastDirectionChangeTime = Time.time;
            }
        }

        if (other.tag == "Player")
        {
            isActive = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isActive = false;

        }
    }
}
