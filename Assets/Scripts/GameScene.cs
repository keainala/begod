using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameScene : MonoBehaviour
{
    private GameState curState = GameState.Idle;
    public GameObject player;
    public GameObject enemy;
    private List<Role> roles = new List<Role>();
    private List<Role> skillroles = new List<Role>();
    private List<Role> players = new List<Role>();
    private List<Role> enemys = new List<Role>();
    FightTimer timer;
    // Start is called before the first frame update
    void Start()
    {
        
        roles.Add(player.GetComponent<Role>());
        roles.Add(enemy.GetComponent<Role>());
        timer = new FightTimer();
        timer.AddRoles(player.GetComponent<Role>());
        timer.Addenemies(enemy.GetComponent<Role>());
        
       // curState = GameState.WaitSkill;
    }

    // Update is called once per frame
    void Update()
    {
        switch (curState)
        {
            case GameState.Idle:
                curState = GameState.FightStart;
                //释放技能
                break;
            case GameState.FightStart:
                curState = GameState.WaitSkill;
                for (int i = 0; i < roles.Count; i++)
                {
                    roles[i].FightStart();
                    //Debug.Log("gongji " + roles[i].RoleId);
                }

                break;
                //可能需要修改  改成不统一管理
            case GameState.WaitSkill:
                for (int i = 0; i < roles.Count; i++)
                {
                    roles[i].GameUpdate(Time.deltaTime);
                    //Debug.Log("gongji " + roles[i].RoleId);
                }
                //if (skillroles.Count==0)
                //{
                //    skillroles = timer.Update(Time.deltaTime);
                //}
                //if (skillroles.Count>0)
                //{
                //Role r0 = skillroles[0];
                //r0.UseSkill();
                //    curState = GameState.ShowTime;
                //}
                //for (int i=0;i< skillroles.Count;i++)
                //{
                //    skillRole[i].UseSkill();
                //Debug.Log("gongji " + skillRole[i].RoleId);
                //}
                break;
            case GameState.SelectSkill:
                break;
            case GameState.UseSkill:
                break;
            case GameState.FightEnd:
                for (int i = 0; i < roles.Count; i++)
                {
                    roles[i].FightEnd();
                    //Debug.Log("gongji " + skillRole[i].RoleId);
                }
                break;
            case GameState.ShowTime:
                break;
        }


        
    
  
    }
}
