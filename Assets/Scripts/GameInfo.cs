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
    Idle,
    SelectSkill,
    UseSkill,
    WaitSkill,
}