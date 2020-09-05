using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour
{
    float speed = 200.0f;

    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}