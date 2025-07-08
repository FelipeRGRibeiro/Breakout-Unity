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
    public static int blockCount = 0;
    private Player player;

    void Start()
    {
        player = UnityEngine.Object.FindAnyObjectByType<Player>();
        StartStage();
    }

    // Update is called once per frame
    void Update()
    {
        if(blockCount == 0)
        {
            ChangeStage();
        }
    }

    void StartStage()
    {
        for (int i = 0; i < 1; i++)//6
        {
            for (int j = 0; j < 1; j++)//5
            {
                GameObject newPrefab = Instantiate(prefab);
                newPrefab.transform.position = new Vector3(x + (deltaX * i), y + (deltaY * j), 0);
                newPrefab.GetComponent<SpriteRenderer>().color = BlockType.GetRandomType().Color;
                blockCount++;
            }
        }
        Ball.speed += player.getStage() * 0.5f;
    }

    void ChangeStage()
    {
        player.incrementStage();
        StartStage();
        Ball.DefinePosition();
        Player.DefinePosition();
    }
}
