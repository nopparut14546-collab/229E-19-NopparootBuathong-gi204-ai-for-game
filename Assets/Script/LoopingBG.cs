using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float speed = 2f;
    public float resetPosition = 20f;
    public float startPosition = 0f;

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (transform.position.x >= resetPosition)
        {
            transform.position = new Vector3(startPosition, transform.position.y, transform.position.z);
        }
    }
}