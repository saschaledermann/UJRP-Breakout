#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TMP_Text highscoreText;

    private void Start()
    {
        var playername = GameManager.Instance.highscorePlayername;
        var score = GameManager.Instance.highscore;
        if (!playername.Equals(""))
            highscoreText.text = $"Best Score: {playername} : {score}";
    }

    public void StartNew() => SceneManager.LoadScene(1);
    
    public void Exit()
    {
        // MainManager.Instance.SaveColor(); 
        
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    public void SavePlayerName() => GameManager.Instance.playerName = inputField.text;
}
