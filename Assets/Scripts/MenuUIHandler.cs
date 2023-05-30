#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
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
