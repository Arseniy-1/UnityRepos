using UnityEngine;

public class MoveForvard : MonoBehaviour
{
    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    }

}
