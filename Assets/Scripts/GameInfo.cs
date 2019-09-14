using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
/// <summary>
/// 游戏状态
/// </summary>
public enum GameState
{
    Idle,           //空闲
    SelectSkill,    //选择技能
    UseSkill,       //释放技能
    WaitSkill,      //队列进行
    FightStart,     //战斗开始
    FightEnd,       //战斗结束
    ShowTime,       //技能展示时间
}