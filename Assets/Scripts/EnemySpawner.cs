using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _spawnDelayTime = 2.0f;
    [SerializeField] private float _spawnStartDelay = 0;

    private WaitForSeconds _spawnDelay;
    private System.Random _random;

    private void Start()
    {
        _spawnDelay = new WaitForSeconds(_spawnDelayTime);
        _random = new System.Random();
        InvokeRepeating(nameof(Spawn), _spawnStartDelay, _spawnDelayTime);
    }

    private void Spawn()
    {
        SpawnPoint spawnPoint = _spawnPoints[_random.Next(0, _spawnPoints.Length)];
        spawnPoint.SpawnEnemy(_enemy);
    }
}
