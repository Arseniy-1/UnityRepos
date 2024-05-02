using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
        transform.Rotate(0, 0.1f, 0);
        transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
    }
}
