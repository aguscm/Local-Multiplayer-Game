using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Complete;

public class JoinPlayerLater : MonoBehaviour
{
    public int EventSystemIndex;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStart()
    {
        gameManager.AddPlayer(EventSystemIndex);
    } 
}
