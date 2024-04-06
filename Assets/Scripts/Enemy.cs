using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 3f;

    private Vector3 _moveDirection;

    private void Update()
    {
        Move();
    }

    public void SetDirection(Vector3 direction)
    {
        _moveDirection = direction;
    }

    private void Move()
    {
        transform.Translate(_moveDirection * _moveSpeed * Time.deltaTime);
    }
}
