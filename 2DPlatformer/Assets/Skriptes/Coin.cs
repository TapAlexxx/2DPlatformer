using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coinValue;

    public int CoinValue
    {
        get
        {
            return _coinValue;
        }
    }
}
