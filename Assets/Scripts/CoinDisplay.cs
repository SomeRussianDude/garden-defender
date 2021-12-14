using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    private int coinBalance = 100;

    public int CoinBalance => coinBalance;

    private Text coinText;

    void Start()
    {
        coinText = GetComponent<Text>();
        UpdateCoins();
    }

    private void UpdateCoins()
    {
        coinText.text = coinBalance.ToString();
    }

    public void AddCoins(int cost)
    {
        coinBalance += cost;
        UpdateCoins();
    }

    public void SpendCoins(int cost)
    {
        if (coinBalance >= cost)
        {
            coinBalance -= cost;
            UpdateCoins();
        }
    }
}