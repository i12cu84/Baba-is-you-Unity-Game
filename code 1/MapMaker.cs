using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//地图绘制
public class MapMaker : MonoBehaviour
{
    //规则实例化
    private static MapMaker instance;

    //实例化
    public static MapMaker Instance
    {
        get
        {
            //空则反空 非空则反自身
            //if (instance == null) return null;
            return instance;
        }
    }

    //地图元素预制体
    public List<GameObject> Prefabs;
    //具体关卡的实例化内容(每一格)
    public LevelCreator levelCreator;
    //父类地图
    public GameObject parentMap;

    //地图临时数据变量
    public GameObject createObject;

    void Awake()
    {
        //实例化自身
        instance = this;
        //地图名字测试
        //Debug.Log(LevelCreator.)
        //Debug.Log("当前场景: " + SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().name == "Level01")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Baba,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level02")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Baba,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Flag,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level03")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Baba,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Win,ElementTypes.Empty,ElementTypes.Flag,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level04")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Baba,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Push,ElementTypes.Empty,ElementTypes.Flag,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level05")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Baba,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Stop,ElementTypes.Empty,ElementTypes.Flag,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level06")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.Empty ,ElementTypes.BabaString,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Win,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Flag,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level07")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Empty,ElementTypes.BabaString,ElementTypes.Empty,ElementTypes.Flag,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Is,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level08")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.BabaString,ElementTypes.Is,ElementTypes.BabaString,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.BabaString,ElementTypes.Empty,ElementTypes.FlagString,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Is,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level09")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.BabaString,ElementTypes.Is,ElementTypes.Sink,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Flag,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level10")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.BabaString,ElementTypes.Is,ElementTypes.Weak,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Flag,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level11")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.SkullString,ElementTypes.Is,ElementTypes.Defeat,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Skull,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level12")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.Melt,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.WallString,ElementTypes.Is,ElementTypes.Hot,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Wall,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level13")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.BeltString,ElementTypes.Is,ElementTypes.Tele,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Belt,ElementTypes.Baba,ElementTypes.Belt,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level14")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Win,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Flag,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.Float,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level15")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.DoorString,ElementTypes.Is,ElementTypes.Shut,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.KeyString,ElementTypes.Is,ElementTypes.Open,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.KeyString,ElementTypes.Is,ElementTypes.Push,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Baba,ElementTypes.Key,ElementTypes.Door,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level16")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Win,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Move,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Baba,ElementTypes.Flag,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level17")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Pull,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Flag,ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level18")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.BeltString,ElementTypes.Is,ElementTypes.Shift,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Belt,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }//还未铺开
        else if (SceneManager.GetActiveScene().name == "Level19")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Move,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Up,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Empty,ElementTypes.Flag,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
               };
        }
        else if (SceneManager.GetActiveScene().name == "Level20")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Move,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Right,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Empty,ElementTypes.Flag,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
               };
        }
        else if (SceneManager.GetActiveScene().name == "Level21")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Move,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Down,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Empty,ElementTypes.Flag,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level22")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Move,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Left,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Empty,ElementTypes.Flag,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
               };
        }
        else if (SceneManager.GetActiveScene().name == "Level23")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Swap,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Flag,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Flag,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level24")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Is,ElementTypes.Baba,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.End,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level25")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Push,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.FlagString,ElementTypes.Is,ElementTypes.Empty,ElementTypes.Fall,ElementTypes.Baba,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.WallString,ElementTypes.Is,ElementTypes.Stop,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Baba,ElementTypes.Flag,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Rock,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Wall,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Wall,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level26")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.RockString,ElementTypes.Empty,ElementTypes.More,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Is,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Rock,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level27")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.RockString,ElementTypes.Is,ElementTypes.Word,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Rock,ElementTypes.Empty,ElementTypes.Push,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Is,ElementTypes.Rock,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level28")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.BoxString,ElementTypes.Empty,ElementTypes.Hide,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Is,ElementTypes.Box,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level29")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.RockString,ElementTypes.Is,ElementTypes.Bonus,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Rock,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level30")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.RockString,ElementTypes.Empty,ElementTypes.Done,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Is,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Baba,ElementTypes.Rock,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty
                };
        }
        //以下 ---未完待续篇---
        //尔后的地图还未设计
        else if (SceneManager.GetActiveScene().name == "Level31")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level32")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level33")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level34")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level35")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level36")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level37")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level38")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level39")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level40")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level41")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level42")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level43")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level44")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level45")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level46")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level47")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level48")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level49")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        else if (SceneManager.GetActiveScene().name == "Level50")
        {
            levelCreator.level = new List<ElementTypes> {
                ElementTypes.BabaString ,ElementTypes.Is,ElementTypes.You,ElementTypes.Baba,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,

                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,
                ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Empty,ElementTypes.Baba
                };
        }
        //限定地图大小
        float lowX = -5f, upX = 4f, upY = 4f;
        //定义距离
        float distance = 1;
        //左上角坐标
        float currentX = lowX, currentY = upY;
        //布置地图
        foreach (ElementTypes ElementType in levelCreator.level)
        {
            //Debug.Log(ElementType.ToString());
            //地图存有空元素
            if (ElementType.ToString() == "Empty")
            {
                //下一格
                currentX += distance;
                //这一行若非越界
                if (currentX > upX)
                {
                    //第一列
                    currentX = lowX;
                    //下一行
                    currentY -= distance;
                }
                continue;//布置下一行
            }
            //布置每一个预制体
            foreach (GameObject ob in Prefabs)
            {
                //如果与布置元素名字相同 则 布置上元素
                if (ElementType.ToString() == ob.name)
                {
                    MakeCreateobject(ob, new Vector3(currentX, currentY, 0));
                    ////布置相应元素
                    //createObject = Instantiate(ob, new Vector3(currentX, currentY, 0), Quaternion.identity);
                    //createObject.transform.parent = parentMap.transform;
                }
            }
            //移到下一格
            currentX += distance;
            //如果在这一行的最后一个 
            if (currentX > upX)
            {
                //移到下一行的第一个
                currentX = lowX;
                //平移下一行
                currentY -= distance;
            }
        }
        ////调整地图的坐标
        //parentMap.transform.position = new Vector3(0, 0.9f, 0);
        ////调整地图的缩放
        //parentMap.transform.localScale = new Vector3(1.8f, 1.8f, 1f);
    }

    //制造相应的物体 传入要创造的物体和地址
    public void MakeCreateobject(GameObject ob, Vector3 tp)
    {
        createObject = Instantiate(ob, tp, Quaternion.identity);
        createObject.transform.parent = parentMap.transform;
    }

    ////制造相应的物体 传入要创造的物体和地址
    //public void SuchCreateobject(string PerfabName, Vector3 tp)
    //{
    //    foreach (GameObject Perfab in Prefabs)
    //    {
    //        Debug.Log(Perfab.name + "23333");
    //        if (PerfabName == Perfab.name)
    //        {
    //            createObject = Instantiate(Perfab, tp, Quaternion.identity);
    //            createObject.transform.parent = parentMap.transform;
    //        }
    //    }
    //}

    ////返回需要的预制体
    //public GameObject ReturnPerfab(string PerfabName)
    //{
    //    foreach (GameObject Perfab in Prefabs)
    //    {
    //        Debug.Log(Perfab.name + "23333");
    //        if (PerfabName == Perfab.name)
    //        {
    //            Debug.Log(Perfab.name + "ohhhhhhhhhhh");
    //            return Perfab;
    //        }
    //    }
    //    return null;
    //}
}
