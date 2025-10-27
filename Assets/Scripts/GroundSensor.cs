using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool IsGrounded;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            IsGrounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            IsGrounded = false;
        }
    }
}
