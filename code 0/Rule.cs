using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//指令 规则
public class Rule : MonoBehaviour
{
    public bool isStop = false;//可以穿过
    public bool isPush = true;//可以推动
    public bool isWin = false;//可以胜利
    public bool isYou = false;//是否是你

    //碰到触发器
    void OnTriggerEnter2D(Collider2D coll)
    {
        //判定触发规则
        RuleManager.Instance.isWhat();
    }

    //离开触发器
    void OnTriggerExit2D(Collider2D coll)
    {
        //判定触发规则
        RuleManager.Instance.isWhat();
    }
}
