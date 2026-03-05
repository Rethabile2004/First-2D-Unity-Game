using UnityEngine;
public class CoinScript : MonoBehaviour
{
    // This function runs when something enters the "Trigger" collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the thing that touched us is the Player
        if (other.gameObject.name == "Player")
        {
            Destroy(gameObject); // The coin disappears!
        }
    }
}
