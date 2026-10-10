using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] private float _initialCoolDown = 3f;
    [SerializeField] private GameObject _obstaclePrefab;
    private float _coolDown;

    private void Awake()
    {
        _coolDown = _initialCoolDown;
    }

    private void Update()
    {
        Cooldown();
    }

    private void Cooldown()
    {
        if (_coolDown >= 0)
        {
            _coolDown -= Time.deltaTime;
            return;
        }
        SpawnObstacle();
        _coolDown = _initialCoolDown;
    }

    private void SpawnObstacle()
    {
        Instantiate(
            _obstaclePrefab,
            new Vector3(5, Random.Range(-3, 3), 0),
            Quaternion.identity);
    }
}
