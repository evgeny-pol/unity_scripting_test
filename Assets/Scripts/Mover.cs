using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _movementSpeed;

    private void Update()
    {
        transform.Translate(_movementSpeed * Time.deltaTime, Space.Self);
    }
}
