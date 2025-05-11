using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikegenerator : MonoBehaviour
{
    public GameObject spike;

    public float minspeed;
    public float maxspeed;
    public float currentspeed;

    public float speedmultiplier;

    // Start is called before the first frame update
    void Awake()
    {
        currentspeed = minspeed;
        generatespike();
    }

    public void GenerateNextSpikeWithGap()
    {
        float randomwait = Random.Range(0.1f, 1.2f);
        Invoke("generatespike", randomwait);
    }

    void generatespike()
    {
        GameObject SpikeIns = Instantiate(spike, transform.position, transform.rotation);
        SpikeIns.GetComponent<SpikeScript>().spikegenerator = this;
    }
    // Update is called once per frame
    void Update()
    {
        if (currentspeed < maxspeed)
        {
            currentspeed += speedmultiplier;
        }
    }
}
