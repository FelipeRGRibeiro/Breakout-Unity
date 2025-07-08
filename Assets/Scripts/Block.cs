using UnityEngine;
using System.Collections.Generic;
using System;
using System.Threading;

public class Block : MonoBehaviour
{
    public GameObject block;
    private int healthPoints = 1;
    public BlockType type;
    private int Count = BlockType.blockTypes.Count;
    private Player player;

    void Start()
    {
        player = UnityEngine.Object.FindAnyObjectByType<Player>();
        BlockType type = BlockType.GetTypeByColor(block.GetComponent<SpriteRenderer>().color);
        healthPoints = type.Hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        healthPoints--;
        //Debug.Log(Player.score);
        for (int i = 0; i < Count; i++)
        {
            if (healthPoints == BlockType.blockTypes[i].Hp)
            {
                type = BlockType.blockTypes[i];
                block.GetComponent<SpriteRenderer>().color = type.Color;
            }
        }

        if(healthPoints <= 0)
        {
            Destroy(block);
            Controller.blockCount--;
            player.incrementScore();
        }
    }
}

public class BlockType
{
    public static readonly BlockType White = new BlockType(1, Color.white);
    public static readonly BlockType Green = new BlockType(2, Color.green);
    public static readonly BlockType Blue = new BlockType(3, Color.blue);


    public int Hp { get; }
    public Color Color { get; }

    private BlockType(int hp, Color color)
    {
        Hp = hp;
        Color = color;
    }

    public static readonly List<BlockType> blockTypes = new List<BlockType> { White, Green, Blue };

    public static BlockType GetTypeByColor(Color color)
    {
        foreach(BlockType type in blockTypes)
        {
            if (type.Color == color) return type;
        }
        return null;
        
    }
    public static BlockType GetRandomType()
    {
        return blockTypes[UnityEngine.Random.Range(0, BlockType.blockTypes.Count)];
    }

}