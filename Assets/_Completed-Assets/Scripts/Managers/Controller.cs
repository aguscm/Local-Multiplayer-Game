using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public static Controller controller;

    public TankInputSystem tankInputSystem;
    // Start is called before the first frame update
    void Start()
    {
        //Spawn four players with split-keyboard steup
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMove()
    {
        Debug.Log("Moving");
    }

    private void OnTurn()
    {
        Debug.Log("Turning");
    }

    void OnFire()
    {
        Debug.Log("Firing");
    }

    void OnStart()
    {
        Debug.Log("Starting");
    }
}
