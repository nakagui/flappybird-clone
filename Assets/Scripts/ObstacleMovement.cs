using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;

    private void Start()
    {
        Destroy(gameObject, 10);
    }

    void Update()
    {
        transform.position += new Vector3(-_speed * Time.deltaTime, 0);
    }
}
