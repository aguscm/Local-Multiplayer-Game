using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;
using UnityEngine.InputSystem.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;
using Complete;

public class UIMouseController : MonoBehaviour
{
    public GameManager gameManager;
    public Button JoinPlayer3;
    public Button JoinPlayer4;
    public InputActionAsset inputActions;
    private TankInputSystem tankInputSystem;
    private InputAction click;

    // Start is called before the first frame update
    void Start()
    {
        //inputActions.action
        tankInputSystem = new TankInputSystem();
        tankInputSystem.UI.Enable();
        click = tankInputSystem.UI.Click;
        //click.performed += context =>
        //{
        //    Debug.Log(context);

        //};
        //JoinPlayer3.OnClick(Debug.Log("click"));
        JoinPlayer3.onClick.AddListener(TaskOnClick);


    }
    void TaskOnClick()
    {
        gameManager.AddPlayer(GameManager.m_numberOfPlayers + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
