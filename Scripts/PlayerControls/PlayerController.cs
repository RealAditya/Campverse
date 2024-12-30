using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 100f;

    void Update()
    {
        // Move the player
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float strafe = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(strafe, 0, move);

        // Rotate the player
        float rotate = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        transform.Rotate(0, rotate, 0);
    }
}

