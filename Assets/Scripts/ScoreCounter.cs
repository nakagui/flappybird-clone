using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D collision)
    {
        GameManager.Instance.MakeScore();
    }
}
