using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleFactor;

    private void Update()
    {
        transform.localScale += new Vector3(_scaleFactor, _scaleFactor, _scaleFactor);
    }
}
