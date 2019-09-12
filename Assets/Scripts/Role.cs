using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Role : MonoBehaviour
{
    public int RoleId;
    
    public PlayerInfo info;
    // Start is called before the first frame update
    void Start()
    {
        info = new PlayerInfo();
        if (RoleId==1)
        {
            info.attack = 1;
            info.defense = 1;
            info.speed = 100;
            info.hp = 1;
            info.mp = 1;
        }
        else
        {
            info.attack = 2;
            info.defense = 2;
            info.speed = 200;
            info.hp = 2;
            info.mp = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if () { }
    }
    public int Speed {get{ return info.speed; }}
    public float OneTurnTime { get { return 1000f / info.speed; } }

}
