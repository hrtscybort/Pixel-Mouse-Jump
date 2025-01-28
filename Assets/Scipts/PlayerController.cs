using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;

    private float x;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal") * speed;
        if (rb.position.y < -6) {
            SceneManager.LoadScene("Game Over");
        }
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.linearVelocity;
        velocity.x = x;
        rb.linearVelocity = velocity;
    }
}
