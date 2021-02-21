using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    private float coins = 0;

    public TextMeshProUGUI textCoins;
    public AudioClip coinsSound;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.tag == "Coins") {
            coins++;

            textCoins.text = coins.ToString();
            AudioSource.PlayClipAtPoint(coinsSound, transform.position);
            Destroy(other.gameObject);
        }
    }
}
