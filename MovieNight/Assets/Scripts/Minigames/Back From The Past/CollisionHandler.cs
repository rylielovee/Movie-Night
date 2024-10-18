using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You Lose");
        Manager.Instance.PlaySound("Back to the Past/Car Crash");
        Manager.Instance.StopLoop();
        Manager.Instance.EndMiniGame(false, true);
    }
}