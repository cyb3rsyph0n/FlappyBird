using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// ReSharper disable UseStringInterpolation

public class GameController : MonoBehaviour
{
    #region Static Fields

    public static GameController Instance;

    #endregion

    #region Fields

    public GameObject GameOverText;
    public float ScrollSpeed = -4;

    public float ColumnTiming = 4;
    public Text ScoreText;

    private int score = 0;

    #endregion

    #region Public Properties

    public bool IsGameOver { get; private set; }

    #endregion

    #region Public Methods and Operators

    public void GameOver()
    {
        IsGameOver = true;
        GameOverText.SetActive(true);
    }

    public void Score()
    {
        if(!IsGameOver)
            score++;
    }

    public void Update()
    {
        if (IsGameOver && Input.GetMouseButtonDown(0)) SceneManager.LoadScene("main");

        ScoreText.text = string.Format("Score: {0}", score);
    }

    #endregion

    #region Methods

    // Use this for initialization
    private void Awake()
    {
        if (Instance == null) Instance = this;
        if (Instance != this) Destroy(this);
    }

    #endregion
}