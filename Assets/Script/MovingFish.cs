using UnityEngine;

public class FishMove : MonoBehaviour
{
    public float speed = 5f;

    public float minY = -5f; // ??????
    public float maxY = 3f;  // ??????

    void Update()
    {
        float moveY = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos.y += moveY * speed * Time.deltaTime;

        // ???????????????
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.position = pos;
    }
}