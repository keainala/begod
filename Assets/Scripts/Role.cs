using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Role : MonoBehaviour
{
    public int RoleId;
    
    public PlayerInfo info;
    float attackWaitTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        info = new PlayerInfo();
        if (RoleId==1)
        {
            info.attack = 1;
            info.defense = 1;
            info.speed = 10;
            info.hp = 1;
            info.mp = 1;
        }
        else
        {
            info.attack = 2;
            info.defense = 2;
            info.speed = 20;
            info.hp = 2;
            info.mp = 3;
        }
        attackWaitTime = 100f / info.speed;
    }

    // Update is called once per frame
    public void GameUpdate(float time)
    {
        attackWaitTime -= time;
        if (attackWaitTime<=0)
        {
            attackWaitTime = 100f / info.speed;
            UseSkill();
        }
        //if () { }
    }
    public int Speed {get{ return info.speed; }}
    public float OneTurnTime { get { return 100f / info.speed; } }
    public void FightStart()
    {
        transform.Rotate(new Vector3(0,45,0));
        Debug.Log(RoleId+ "  Fight start");
    }
    public void UseSkill()
    {
        Debug.Log(RoleId+"  UseSkill");
    }
    public void FightEnd()
    {
        Debug.Log(RoleId + "  Fight End");
    }

}
