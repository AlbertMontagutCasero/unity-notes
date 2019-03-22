using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public Vector3 direction;

    void Start()
    {

    }

    void Update()
    {
        transform.position = transform.position + Time.deltaTime * 2 * direction;
    }
}
