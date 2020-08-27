using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreUpdater : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private GameObject _player;

    private void Awake()
    {
        _text.text = $"You collected {_player.GetComponent<PlayerCoinCollector>().CoinCount}";
    }

    public void UpdateScore()
    {
        _text.text = $"You collected {_player.GetComponent<PlayerCoinCollector>().CoinCount}";
    }
}
