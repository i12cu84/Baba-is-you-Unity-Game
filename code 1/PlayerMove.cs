using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
//角色的移动等
public class PlayerMove : MonoBehaviour
{
    //实例化
    private static PlayerMove instance;

    //实例化
    public static PlayerMove Instance
    {
        get
        {
            //空则反空 非空则反自身
            //if (instance == null) return null;
            return instance;
        }
    }

    //目前可以随着WASD移动的物体
    public List<GameObject> currentPlayer = new List<GameObject>();
    //所有可以变化的物体
    public GameObject[] allObjects;
    ////动画
    //public Animator an;
    //移动的速度
    private int moveDistance = 1;

    void Awake()
    {
        //空则实例 非空则销毁
        //if (instance == null) instance = this;
        //else Destroy(this.gameObject);
        instance = this;
        //存储世界所有标签object的物体
        allObjects = GameObject.FindGameObjectsWithTag("object");
        //检测地图的规则
    }

    private void Start()
    {
        ////在所有物体中寻找You
        //foreach (GameObject obj in PlayerMove.Instance.allObjects)
        //{
        //    //加入is的对象
        //    if (obj.name == "Is(Clone)" || obj.name == "Is")
        //    {
        //        //is的obj压入数组
        //        isObject.Add(obj);
        //    }
        //}
    }

    void Update()
    {
        You1Move();//物体的WASD移动
    }

    //You1移动的WASD函数
    public void You1Move()
    {

        if (Input.GetKeyDown("up"))
        {
            //调整规则检测为正常
            RuleManager.Instance.CheckToTrue();
            //统计位移的物体
            List<GameObject> movingObjects = new List<GameObject>();
            movingObjects = MoveObjects(movingObjects, 0, 1);
            movingObjects = movingObjects.Distinct().ToList();
            foreach (GameObject moveobj in movingObjects)
            {
                //移动一个单位
                moveobj.transform.Translate(new Vector2(0, moveDistance));
                //播放baba动画
                if (moveobj.name.Replace("(Clone)", "") == "Baba")
                {
                    moveobj.GetComponent<Animator>().Play("babaup");
                }
            }
            //调整规则
            RuleManager.Instance.Iswhat(1);
        }

        if (Input.GetKeyDown("down"))
        {
            //调整规则检测为正常
            RuleManager.Instance.CheckToTrue();
            //统计位移的物体
            List<GameObject> movingObjects = new List<GameObject>();
            movingObjects = MoveObjects(movingObjects, 0, -1);
            movingObjects = movingObjects.Distinct().ToList();
            foreach (GameObject moveobj in movingObjects)
            {
                //移动一个单位
                moveobj.transform.Translate(new Vector2(0, -moveDistance));
                //播放baba动画
                if (moveobj.name.Replace("(Clone)", "") == "Baba")
                {
                    moveobj.GetComponent<Animator>().Play("babadown");
                }
            }
            //调整规则
            RuleManager.Instance.Iswhat(2);
        }

        if (Input.GetKeyDown("left"))
        {
            //调整规则检测为正常
            RuleManager.Instance.CheckToTrue();
            //统计位移的物体
            List<GameObject> movingObjects = new List<GameObject>();
            movingObjects = MoveObjects(movingObjects, -1, 0);
            movingObjects = movingObjects.Distinct().ToList();
            foreach (GameObject moveobj in movingObjects)
            {
                //移动一个单位
                moveobj.transform.Translate(new Vector2(-moveDistance, 0));
                //播放baba动画
                if (moveobj.name.Replace("(Clone)", "") == "Baba")
                {
                    moveobj.GetComponent<Animator>().Play("babaleft");
                }
            }
            //调整规则
            RuleManager.Instance.Iswhat(3);
        }

        //右操作
        if (Input.GetKeyDown("right"))
        {
            //调整规则检测为正常
            RuleManager.Instance.CheckToTrue();
            //统计位移的物体
            List<GameObject> movingObjects = new List<GameObject>();
            //坐标位移 向右移动
            movingObjects = MoveObjects(movingObjects, 1, 0);
            movingObjects = movingObjects.Distinct().ToList();
            foreach (GameObject moveobj in movingObjects)
            {
                //移动一个单位
                moveobj.transform.Translate(new Vector2(moveDistance, 0));
                //播放baba动画
                if (moveobj.name.Replace("(Clone)", "") == "Baba")
                {
                    moveobj.GetComponent<Animator>().Play("babaright");
                }
            }
            //调整规则
            RuleManager.Instance.Iswhat(4);
        }
    }

    //移动的物品
    public List<GameObject> MoveObjects(List<GameObject> movingObjects, float dx, float dy)
    {
        //不存在的情况下 游戏失败 这个没写
        //遍历现在的可移动物体(is you)
        foreach (GameObject player in currentPlayer)
        {
            //横坐标位移的下一个位置的横坐标
            float currentX = player.transform.position.x + dx;
            //纵坐标位移的下一个位置的纵坐标
            float currentY = player.transform.position.y + dy;
            //可移动位置加入
            movingObjects.Add(player);
            //反复循环(因为操作灰有连锁反应所以暂定30次
            for (int i = 0; i < 30; i++)
            {
                //先设定未检查到
                bool check = false;
                //所有物体遍历
                foreach (GameObject allobj in allObjects)
                {
                    //Rule的PerfabsDictionary为预制体字典 OrdersDictionary为属性字典 Rules[Perfabs,Orders] 
                    //遍历的物品中与该物体下次位移的位置重合
                    if (allobj.transform.position.x == currentX && allobj.transform.position.y == currentY)
                    {
                        //在字典中查验是否存在
                        if (Rule.Instance.PerfabsDictionary.ContainsKey(allobj.name.Replace("(Clone)", "")))
                        {
                            //在字典中查验是否存在
                            if (Rule.Instance.PerfabsDictionary.ContainsKey(allobj.name.Replace("(Clone)", "")))
                            {
                                //如果改是静止 且 无法被推动
                                if (Rule.Instance.Rules[Rule.Instance.PerfabsDictionary[allobj.name.Replace("(Clone)", "")], Rule.Instance.OrdersDictionary["Stop"]]
                                && !(Rule.Instance.Rules[Rule.Instance.PerfabsDictionary[allobj.name.Replace("(Clone)", "")], Rule.Instance.OrdersDictionary["Push"]]))
                                {
                                    //此时加入了float模块 漂浮模块
                                    //则返回目前能推动的当前物体
                                    return new List<GameObject>();
                                }
                            }
                        }
                        //在字典中查验是否存在
                        if (Rule.Instance.PerfabsDictionary.ContainsKey(allobj.name.Replace("(Clone)", "")))
                        {
                            //不能被推动 则跳过此次循环
                            if (!(Rule.Instance.Rules[Rule.Instance.PerfabsDictionary[allobj.name.Replace("(Clone)", "")], Rule.Instance.OrdersDictionary["Push"]]))
                            {
                                continue;
                            }
                        }
                        //加入移动物体
                        movingObjects.Add(allobj);
                        //检查到
                        check = true;
                    }
                }
                //横坐标位移
                currentX += dx;
                //纵坐标位移
                currentY += dy;
                //未查找到则跳出循环
                if (!check) break;
            }
        }
        //若以上推动没有变化的变量 则只改变自身的位移
        return movingObjects;
    }

}
