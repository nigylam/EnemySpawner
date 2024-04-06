using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Vector3 _enemyDirection;

    public void SpawnEnemy(Enemy enemy)
    {
        enemy = Instantiate(enemy, transform.position, Quaternion.identity);
        enemy.SetDirection(_enemyDirection);
    }
}

