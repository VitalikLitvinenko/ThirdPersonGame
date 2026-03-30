using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinText;
    private int _coinCount = 0;

    private void Start()
    {
        _coinText.text = "Монет: 0";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Coin coin))
        {
            _coinCount++;
            _coinText.text = $"Монет: {_coinCount}";
            coin.Collect();
        }
    }
}