using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject gameOver;
    public GameObject PlayButton;
    public GameObject Pipes;

    private int _score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play()
    {
        _score = 0;
        scoreText.text = _score.ToString();

        Time.timeScale = 1f;

        PlayButton.SetActive(false);
        gameOver.SetActive(false);

        player.enabled = true;
        player.transform.position = player.startPoint;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        float rand = Random.Range(-1.43f, 3.6f);
        Pipes.transform.position = new Vector3(-3.9f, rand, 0);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;

        gameOver.SetActive(false);
    }

    public void GameOver()
    {
        Pause();
        PlayButton.SetActive(true);
        gameOver.SetActive(true);
    }

    public void IncreaseScore()
    {
        _score++;
        scoreText.text = _score.ToString();
    }
}
