using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//指令 规则
public class Rule : MonoBehaviour
{
    //规则实例化
    private static Rule instance;

    //实例化
    public static Rule Instance
    {
        get
        {
            //空则反空 非空则反自身
            //if (instance == null) return null;
            return instance;
        }
    }

    //预制体
    public string[] Perfabs = new string[] { "Empty", "Baba", "Wall", "Flag", "Box", "Key", "Rock", "Water", "Skull", "Door", "Belt" };
    //预制体字典
    public Dictionary<string, int> PerfabsDictionary = new Dictionary<string, int>();
    //预制体长度
    public static int Perfabssize = 11;

    //规则属性
    public string[] Orders = new string[] { "You", "Win", "Stop", "Push", "Sink", "Weak", "Defeat", "Hot", "Melt", "Tele", "Float",
        "Open", "Shut","Move", "Pull", "Shift", "Up", "Right", "Swap", "End", "Fall", "Down", "More", "Word", "Hide", "Bonus",
        "Done", "Best", "Left", "Sad","Safe", "Sleep", "Wonder", "Auto", "Blue", "Broken", "Chill", "Falldown", "Fallleft",
        "Fallright", "Fallup", "Nudgedown", "Nudgeleft","Nudgeright", "Nudgeup", "Party", "Pet", "Phamtom", "Pink", "Power",
        "Red", "Reverse", "Rosy", "Still", "Turnleft", "Turnright", "You2",
        "EmptyString", "BabaString", "WallString", "FlagString", "BoxString", "KeyString",
        "RockString", "WaterString", "SkullString", "DoorString", "BeltString" };
    //规则属性字典
    public Dictionary<string, int> OrdersDictionary = new Dictionary<string, int>();
    //规则属性+预制体的长度
    public static int Orderssize = 68;

    //成立的规则定义
    public bool[,] Rules = new bool[11, 68];

    private void Awake()
    {
        //自定义
        instance = this;
        //初始化
        InitDic();
        //初始化
        Init();
    }

    //初始化
    public void InitDic()
    {
        for (int i = 0; i < 11; i++)
        {
            PerfabsDictionary.Add(Perfabs[i], i);
        }
        for (int i = 0; i < 68; i++)
        {
            OrdersDictionary.Add(Orders[i], i);
        }
    }

    //初始化
    public void Init()
    {
        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < 68; j++)
            {
                Rules[i, j] = false;
            }
        }
    }
}
    //TextString,
    //EmptyString,
    //GroupString,
    //LevelString,
    //AllString

    //BabaString,
    //WallString,
    //FlagString,
    //BoxString,
    //KeyString,
    //RockString,
    //WaterString,
    //SkullString,
    //DoorString,
    //BeltString,
    //FeelingString,
    //Group2String,
    //Group3String,
    //IdleString,
    //MimicString,
    //OftenString,
    //PoweredString,
    //SeldomString,
    //WithoutString,


    //Is,
    //Not, 
    //Has, 
    //And,
    //On,
    //Make, 
    //Facing, 
    //Lonely,
    //Near, 
    //Fear, 
    //Follow, 
    //Eat,



    //碰到触发器
    //private void OnTriggerEnter2D(Collider2D coll)
    //{
    //    //判定触发规则
    //    RuleManager.Instance.Iswhat();
    //}

    ////离开触发器
    //private void OnTriggerExit2D(Collider2D coll)
    //{
    //    //判定触发规则
    //    RuleManager.Instance.Iswhat();
    //}
