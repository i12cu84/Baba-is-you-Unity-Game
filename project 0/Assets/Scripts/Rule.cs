using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rule : MonoBehaviour
{
    public bool isStop = false;
    public bool isPush = true;
    public bool isWin = false;
    public bool isYou = false;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // 문자(baba, is, you, wall, stop 등등)들이 충돌했을때 그리고 빠져나왔을때마다 호출함.
    void OnTriggerEnter2D(Collider2D coll)
    {
        RuleManager.Instance.isWhat();
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        RuleManager.Instance.isWhat();
    }
}
