using UnityEngine;
using System.Collections.Generic;

public class Controller : MonoBehaviour
{
    public GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float x = -2.5f;
    float y = 2f;
    float deltaX = 1f;
    float deltaY = 0.5f;
    int randCor;
    void Start()
    {
        for(int i=0; i<6; i++)
        {
            for(int j=0; j<5; j++)
            {
                GameObject newPrefab = Instantiate(prefab);
                newPrefab.transform.position = new Vector3(x+(deltaX*i), y+(deltaY*j), 0);
                randCor = Random.Range(0, Block.cores.Count);
                newPrefab.GetComponent<SpriteRenderer>().color = Block.cores[randCor];
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
