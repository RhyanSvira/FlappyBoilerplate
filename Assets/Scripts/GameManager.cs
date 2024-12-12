using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public GameObject playButton;
    public GameObject gameOver;

    

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    public void Play()
    {
        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;
        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++) {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }

    
}
