using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Character character;
    public Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        player.Shout();
        enemy.Shout();
        character.Shout();
        Debug.Log("Player name: " + player.CharName);
    }
}
