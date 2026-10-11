using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    private int _scoreCount;
    public static ScoreManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void MakeScore()
    {
        _scoreCount++;
        _scoreText.text = _scoreCount.ToString();
    }

    public void ResetScore()
    {
        _scoreCount = 0;
        _scoreText.text = _scoreCount.ToString();
    }
}
