using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private const string PlayerTag = "Player";

    private GameManager _gameManager;

    private bool _triggeredNextScene;
    
    [SerializeField] private AudioSource winfinish;
    
    // Why are we checking if the player reaches the finish line here? So, we do not
    // have to check for every time the player collides with something for a finish line.

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag(PlayerTag)) return;

        if (_triggeredNextScene) return;

        _triggeredNextScene = true;   // This is to prevent double scene loads.
        winfinish.Play();
        _gameManager = FindObjectOfType<GameManager>();
        _gameManager.LoadNextLevel();
    }
}
