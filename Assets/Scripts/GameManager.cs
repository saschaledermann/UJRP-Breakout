using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public string playerName;
    public string highscorePlayername;
    public int highscore;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);

        highscorePlayername = PlayerPrefs.GetString("Playername");
        highscore = PlayerPrefs.GetInt("Highscore");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("Playername", highscorePlayername);
        PlayerPrefs.SetInt("Highscore", highscore);
    }
}
