using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCoinCollector : MonoBehaviour
{
    [SerializeField] private int _coinCount;
    [SerializeField] private Text _coinCountText;

    private void Awake()
    {
        _coinCountText.text = $"You collected {_coinCount} coin(s)";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Coin coin))
        {
            _coinCount += coin.CoinValue;
            _coinCountText.text = $"You collected {_coinCount} coin(s)";
            Destroy(coin.gameObject);
        }
    }
}
