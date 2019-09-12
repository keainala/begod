using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightTimer 
{
    private List<FightTimerItem> _roles = new List<FightTimerItem>();
    private List<FightTimerItem> _enemies = new List<FightTimerItem>();
    // Start is called before the first frame update


    // Update is called once per frame
    public List<Role> Update(float time)
    {
        
        List<Role> skillrole = new List<Role>();
        //更新速度
        for (int i = 0; i < _roles.Count; i++)
        {
            _roles[i].time -= time;
            if (_roles[i].time<=0)
            {
                skillrole.Add(_roles[i].role);
                _roles[i].time = _roles[i].role.OneTurnTime;
            }
        }
        for (int i = 0; i < _enemies.Count; i++)
        {
            _enemies[i].time -= time;
            if (_enemies[i].time <= 0)
            {
                skillrole.Add(_enemies[i].role);
                _enemies[i].time = _enemies[i].role.OneTurnTime;
            }
        }
        
        return skillrole;
    }
    //public void AddRoles(List<Role> roles)
    //{
    //    _roles.AddRange(roles);
    //}
    //public void Addenemies(Role roles)
    //{
    //    _enemies.Add(roles);
    //}
    public void AddRoles(Role roles)
    {
        FightTimerItem infos = new FightTimerItem();
        infos.role = roles;
        infos.time = roles.OneTurnTime;
        _roles.Add(infos);
    }
    public void Addenemies(Role roles)
    {
        FightTimerItem infos = new FightTimerItem();
        infos.role = roles;
        infos.time = roles.OneTurnTime;
        _enemies.Add(infos);
    }
}
public class FightTimerItem
{
    public Role role;
    public float time;
}