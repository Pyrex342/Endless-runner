using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour
{
    public float maxhealth = 100f;
    float currenthealth;

    public Slider healthbar;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxhealth;
        healthbar.maxValue = maxhealth;
        healthbar.value = currenthealth;
    }

    public void Takedamage(float damage)
    {
        currenthealth -= damage;

        if (currenthealth < 0) currenthealth = 0;
        if (currenthealth > maxhealth) currenthealth = maxhealth;

        healthbar.value = currenthealth;
    }

    public void Update()
    {
        
    }

}
