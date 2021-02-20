using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private float coins = 0;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.tag == "Coins") {
            Destroy(other.gameObject);
        }
    }
}
