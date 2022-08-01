using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    //public GameObject StartGameButton;
    //public GameObject MapMakerButton;
    //public GameObject InventoryButton;
    //public GameObject QuitButton;
    public GameObject MainMenuPanel;
    public GameObject InventoryPanel;
    public bool isInventoryOpen = false;
    public TextMeshProUGUI CoinsTextbox;

    private void Start()
    {
        
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && isInventoryOpen == true)
        {
            CloseInventory();
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartMapMaker()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void OpenInventory()
    {
        InventoryPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
        isInventoryOpen = true;
    }

    public void CloseInventory()
    {
        InventoryPanel.SetActive(false);
        MainMenuPanel.SetActive(true);
        isInventoryOpen = false;
    }

    public void FreeCoin()
    {
        SaveData.current.profile.playerCoins += 1;
        CoinsTextbox.text = "Coins: " + SaveData.current.profile.playerCoins;
    }

    public void QuitGame()
    {

        Debug.Log("Quitting Game...");
        Application.Quit();
    }

    public void OnLoadGame()
    {
        SaveData.current = (SaveData)SerializationManager.Load(Application.persistentDataPath + "/saves/Save.save");
    }

    

}
