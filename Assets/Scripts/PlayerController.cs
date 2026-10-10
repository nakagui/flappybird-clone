using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInputHandler))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _velocityUp = 5f;
    private Rigidbody2D _rigidbody;
    private PlayerInputHandler _input;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _input = GetComponent<PlayerInputHandler>();
    }

    private void FixedUpdate()
    {
        Jump();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            GameOver();
        }
    }

    private void Jump()
    {
        if (_input.JumpIsPressed)
        {
            _rigidbody.linearVelocity = Vector2.up * _velocityUp;
            _input.EndJump();
        }
    }

    private void GameOver()
    {
        GameManager.Instance.ShowGameOver();
    }
}
