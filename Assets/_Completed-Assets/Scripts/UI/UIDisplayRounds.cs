using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Complete;

public class UIDisplayRounds : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject UIRootContent;
    public GameObject PrefabTankIndicator;
    List<Image> UIImageTank = new List<Image>();
    List<Text> UITextRoundsWonTank = new List<Text>();

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayUI()
    {
        //Firstly, delete all the UI Tanks
        foreach (Transform child in UIRootContent.transform)
        {
            Destroy(child.gameObject);
            UIImageTank.Clear();
            UITextRoundsWonTank.Clear();
        }

        UIImageTank = new List<Image>();
        UITextRoundsWonTank = new List<Text>();

        //Create the UI elements
        for (int i = 0; i < GameManager.m_numberOfPlayers; i++)
        {
            GameObject UITank = Instantiate(PrefabTankIndicator, UIRootContent.transform);
            UIImageTank.Add(UITank.GetComponentInChildren<Image>());
            UITextRoundsWonTank.Add(UITank.GetComponentInChildren<Text>());

            UIImageTank[i].color = gameManager.m_Tanks[i].m_PlayerColor;
            UITextRoundsWonTank[i].text = gameManager.m_Tanks[i].m_Wins.ToString();

        }

    }
}
