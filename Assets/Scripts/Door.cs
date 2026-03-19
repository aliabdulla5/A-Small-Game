using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") &&
            GameManager.instance.keysCollected >= GameManager.instance.totalKeys)
        {
            GameManager.instance.WinGame();
        }
    }
}