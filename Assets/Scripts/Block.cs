using UnityEngine;
using System.Collections.Generic;

public class Block : MonoBehaviour
{
    public GameObject block;
    private int healthPoints = 1;
    public static List<Color> cores = new List<Color> { Color.blue, Color.green, Color.white };
    private int[] healthByColor = { 3, 2, 1 };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i=0; i<cores.Count; i++)
        {
            if (block.GetComponent<SpriteRenderer>().color == cores[i])
            {
                healthPoints = healthByColor[i];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        healthPoints--;
        Debug.Log(Player.score);
        for (int i = 0; i < cores.Count; i++)
        {
            if (healthPoints == healthByColor[i])
            {
                block.GetComponent<SpriteRenderer>().color = cores[i];
            }
        }
        /*if (healthPoints == 2)
        {
            block.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        else if (healthPoints == 1)
        {
            block.GetComponent<SpriteRenderer>().color = Color.white;
        }
        else*/
        if(healthPoints <= 0)
        {
            Destroy(block);
            Player.score += 1;
        }
    }
}
