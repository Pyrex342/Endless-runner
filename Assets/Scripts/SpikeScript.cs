using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{

    public spikegenerator spikegenerator;
   
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * spikegenerator.currentspeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("nextline"))
        {
            spikegenerator.GenerateNextSpikeWithGap();
        }

        if (other.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}
