using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private int _coinCount = 10;
    [SerializeField] private float _spawnRadius = 10f;

    private void Start()
    {
        SpawnCoins();
    }

    private void SpawnCoins()
    {
        for (int i = 0; i < _coinCount; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-_spawnRadius, _spawnRadius),
                1f,
                Random.Range(-_spawnRadius, _spawnRadius)
            );

            Instantiate(_coinPrefab, randomPosition, Quaternion.Euler(90f, 0f, 0f));
        }
    }
}