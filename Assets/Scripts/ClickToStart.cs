using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickToStart : MonoBehaviour
{
    private bool _fired;
    
    private FaderManager _fader;

    public Button button;

    private void Start()
    {
        _fader = FindObjectOfType<FaderManager>();
    }

    private void Update()
    {
        if (gameObject.name == "StartButton")
        {
            button.onClick.AddListener(StartGame);
        }
        if(gameObject.name == "ExitButton")
        {
            button.onClick.AddListener(ExitGame);
        }
    }
    void ExitGame()
    {
        Application.Quit();
    }
    void StartGame()
    {
        if (_fired) return;
        else 
        {
            _fired = true;
            var first = SceneManager.GetActiveScene().buildIndex + 1;
            _fader.GotoScene(first);
        }
    }
}