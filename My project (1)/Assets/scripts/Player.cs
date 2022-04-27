using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private string name;
    private int killCount;
    private Room currentRoom;

    public Player(string name)
    {
        this.name = name;
        this.killCount = 0;
        this.currentRoom = null;
    }

    

    public void addKill()
    {
        this.killCount++;
    }

    public int getKillCount()
    {
        return this.killCount;
    }

    public string getName()
    {
        return this.name;
    }
}
