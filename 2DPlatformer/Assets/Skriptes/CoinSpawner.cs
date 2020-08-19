using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Transform _spawners;
    [SerializeField] private GameObject[] _coins;

    private Transform[] _spawnPositions;

    private void Start()
    {
        _spawnPositions = new Transform[_spawners.childCount];
        for (int i = 0; i < _spawners.childCount; i++)
        {
            _spawnPositions[i] = _spawners.GetChild(i);
        }

        StartCoroutine(SpawnCoins());
    }

    private IEnumerator SpawnCoins()
    {
        var waitForSecond = new WaitForSeconds(5f);
        while (true)
        {
            int randomPosition = Random.Range(0, _spawnPositions.Length);
            int randomCoin = Random.Range(0, _coins.Length);

            Instantiate(_coins[randomCoin], _spawnPositions[randomPosition].position, Quaternion.identity);

            yield return waitForSecond;
        }
    }
}
