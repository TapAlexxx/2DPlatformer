using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerCoinCollector : MonoBehaviour
{
    [SerializeField] public int CoinCount { get; private set; }
    [SerializeField] private UnityEvent _coinCollected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Coin coin))
        {
            CoinCount += coin.CoinValue;
            _coinCollected?.Invoke();
            Destroy(coin.gameObject);
        }
    }
}
