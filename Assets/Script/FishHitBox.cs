using UnityEngine;

public class FishCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Net"))
        {
            Time.timeScale = 0f;
            Debug.Log("GAME OVER!");
        }
    }
}