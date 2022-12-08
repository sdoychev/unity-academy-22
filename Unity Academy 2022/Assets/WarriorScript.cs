using UnityEngine;

public class WarriorScript : MonoBehaviour
{
    public string name;
    public int score;

    private GameDataManager gameDataManager;
    
    private void Start()
    {
        Debug.Log(Application.persistentDataPath);
        gameDataManager = new GameDataManager();
        gameDataManager.Load();
        RefreshPlayerData();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetBool("isInBattle", true);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            GetComponent<Animator>().SetBool("isInBattle", false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            gameDataManager.Load();
            RefreshPlayerData();
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            gameDataManager.Data.playerName = name;
            gameDataManager.Data.playerScore = score;
            gameDataManager.Save();
        }
    }

    private void RefreshPlayerData()
    {
        name = gameDataManager.Data.playerName;
        score = gameDataManager.Data.playerScore;
    }
}
