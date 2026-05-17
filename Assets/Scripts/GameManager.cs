using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [HideInInspector] public GameObject selectedPrefab;

    public int currentCoins = 100;
    public TMP_Text coinsText;
    public TMP_Text waveText;

    public GameObject startPanel;
    public GameObject gameOverPanel;
    public GameObject victoryPanel;

    private bool isGameOver = false;
    private bool isVictory = false;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        UpdateCoinsUI();

        if (startPanel != null) startPanel.SetActive(true);
        if (gameOverPanel != null) gameOverPanel.SetActive(false);
        if (victoryPanel != null) victoryPanel.SetActive(false);
        Time.timeScale = 0f;
    }

    
    public void StartGame()
    {
        if (startPanel != null) startPanel.SetActive(false);
        Time.timeScale = 1f; 
    }

    public void GameOver()
    {
        if (isGameOver || isVictory) return; // ✅ agar already victory hai to game over na ho
        isGameOver = true;

        if (gameOverPanel != null) gameOverPanel.SetActive(true);
        Time.timeScale = 0f; 
    }
    public void Victory()
    {
        if (isVictory || isGameOver) return;
        isVictory = true;

        if (victoryPanel != null) victoryPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ShowWave(int waveNumber)
    {
        if (waveText == null) return;
        waveText.text = "Wave: " + waveNumber;
    }

    
    public void SelectPlayer(GameObject prefab)
    {
        selectedPrefab = prefab;
    }

    public void DeselectPlayer()
    {
        selectedPrefab = null;
    }

    public void OnPlayerDeployed()
    {
        selectedPrefab = null;
    }

    public void AddCoins(int amount)
    {
        currentCoins += amount;
        UpdateCoinsUI();
    }

    public bool SpendCoins(int amount)
    {
        if (currentCoins >= amount)
        {
            currentCoins -= amount;
            UpdateCoinsUI();
            return true;
        }
        return false;
    }

    void UpdateCoinsUI()
    {
        if (coinsText != null)
            coinsText.text = currentCoins.ToString();
    }
}
