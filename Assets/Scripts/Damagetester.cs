using System.Collections;
using System.Collections.Generic;
using SupanthaPaul;
using UnityEngine;

public class Damagetester : MonoBehaviour
{
    public Player_Health player;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            player.Takedamage(10f);
        }
    }
}
