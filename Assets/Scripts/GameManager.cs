using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverScreen;
    [SerializeField] private Button _playAgainButton;
    [SerializeField] private TextMeshProUGUI _scoreText;
    public static GameManager Instance { get; private set; }
    private int _scoreCount;

    private void Awake()
    {
        Instance = this;
        _playAgainButton.onClick.AddListener(PlayAgain);
    }

    public void ShowGameOver()
    {
        Pause();
        _gameOverScreen.SetActive(true);
    }

    public void PlayAgain()
    {
        Continue();
        _scoreCount = 0;
        _scoreText.text = _scoreCount.ToString();
        SceneManager.LoadScene("Level01");
    }

    public void MakeScore()
    {
        _scoreCount++;
        _scoreText.text = _scoreCount.ToString();
    }

    private void Pause()
    {
        Time.timeScale = 0f;
    }

    private void Continue()
    {
        Time.timeScale = 1f;
    }
}
