using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverScreen;
    [SerializeField] private Button _playAgainButton;
    public static GameManager Instance { get; private set; }

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
        ScoreManager.Instance.ResetScore();
        SceneManager.LoadScene("Level01");
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
