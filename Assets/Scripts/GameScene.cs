using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameScene : MonoBehaviour
{
    private GameState curState = GameState.Idle;
    public GameObject player;
    public GameObject enemy;
    private List<Role> roles = new List<Role>();
    FightTimer timer;
    // Start is called before the first frame update
    void Start()
    {
        
        roles.Add(player.GetComponent<Role>());
        roles.Add(enemy.GetComponent<Role>());
        timer = new FightTimer();
        timer.AddRoles(player.GetComponent<Role>());
        timer.Addenemies(enemy.GetComponent<Role>());
        curState = GameState.WaitSkill;
    }

    // Update is called once per frame
    void Update()
    {
        switch (curState)
        {
            case GameState.WaitSkill:
                
                List<Role> skillRole = timer.Update(Time.deltaTime);
                for (int i=0;i<skillRole.Count;i++)
                {
                    Debug.Log("gongji " + skillRole[i].RoleId);
                }
                break;
            case GameState.SelectSkill:
                break;
            case GameState.UseSkill:
                break;

        }


        
    
  
    }
}
