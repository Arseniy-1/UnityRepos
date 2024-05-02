using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForvard : MonoBehaviour
{
    private void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime;
    }

}
