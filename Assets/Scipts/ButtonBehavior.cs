using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    public void LoadGameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
}
