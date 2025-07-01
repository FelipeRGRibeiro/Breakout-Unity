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
    int stage = Player.stage;
    public static int blockCount = 0;

    void Start()
    {
        StartStage(stage);
    }

    // Update is called once per frame
    void Update()
    {
        if(blockCount == 0)
        {
            ChangeStage();
        }
    }

    void StartStage(int stage)
    {
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < 1; j++)
            {
                GameObject newPrefab = Instantiate(prefab);
                newPrefab.transform.position = new Vector3(x + (deltaX * i), y + (deltaY * j), 0);
                newPrefab.GetComponent<SpriteRenderer>().color = BlockType.GetRandomType().Color;
                blockCount++;
            }
        }
        Ball.speed += stage * 0.5f;
    }

    void ChangeStage()
    {
        Player.stage++;
        StartStage(stage);
        Ball.DefinePosition();
        Player.DefinePosition();
    }
}
