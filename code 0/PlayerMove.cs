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

    //目前可以随着WASD移动的物体
    public List<GameObject> currentPlayer = new List<GameObject>();
    //所有可以变化的物体
    public GameObject[] allObjects;
    //动画
    public Animator an;

    //移动的速度
    public int moveDistance = 1;

    void Awake()
    {
        //空则实例 非空则销毁
        if (instance == null) instance = this;
        else Destroy(this.gameObject);
        //
        allObjects = GameObject.FindGameObjectsWithTag("object");
    }

    //实例化
    public static PlayerMove Instance
    {
        get
        {
            //空则反空 非空则反自身
            if (instance == null) return null;
            return instance;
        }
    }

    void Update()
    {
        ObjMove();//物体的WASD移动
    }

    //物体移动的WASD函数
    public void ObjMove()
    {
        //右操作
        if (Input.GetKeyDown("right"))
        {
            //统计位移的物体
            List<GameObject> movingObjects = new List<GameObject>();
            //坐标位移 向右移动
            movingObjects = moveObjects(movingObjects, 1, 0);
            movingObjects = movingObjects.Distinct().ToList();
            foreach (GameObject objects in movingObjects)
            {
                objects.transform.Translate(new Vector2(moveDistance, 0));
                if (objects.name == "Baba") an.Play("babaright");
            }
            if (RuleManager.Instance.isWin()) SceneManager.LoadScene("Menu");
        }

        if (Input.GetKeyDown("left"))
        {
            List<GameObject> movingObjects = new List<GameObject>();
            movingObjects = moveObjects(movingObjects, -1, 0);
            movingObjects = movingObjects.Distinct().ToList();
            foreach (GameObject objects in movingObjects)
            {
                objects.transform.Translate(new Vector2(-moveDistance, 0));
                if (objects.name == "Baba") an.Play("babaleft");
            }
            if (RuleManager.Instance.isWin()) SceneManager.LoadScene("Menu");
        }

        if (Input.GetKeyDown("up"))
        {
            List<GameObject> movingObjects = new List<GameObject>();
            movingObjects = moveObjects(movingObjects, 0, 1);
            movingObjects = movingObjects.Distinct().ToList();
            foreach (GameObject ob in movingObjects)
            {
                ob.transform.Translate(new Vector2(0, moveDistance));
                if (ob.name == "Baba") an.Play("babaup");
            }
            if (RuleManager.Instance.isWin()) SceneManager.LoadScene("Menu");
        }

        if (Input.GetKeyDown("down"))
        {
            List<GameObject> movingObjects = new List<GameObject>();
            movingObjects = moveObjects(movingObjects, 0, -1);
            movingObjects = movingObjects.Distinct().ToList();
            foreach (GameObject ob in movingObjects)
            {
                ob.transform.Translate(new Vector2(0, -moveDistance));
                if (ob.name == "Baba") an.Play("babadown");
            }
            if (RuleManager.Instance.isWin()) SceneManager.LoadScene("Menu");
        }
    }

    //移动的物品
    public List<GameObject> moveObjects(List<GameObject> movingObjects, float dx, float dy)
    {
        //遍历现在的可移动物体(is you)
        foreach (GameObject player in currentPlayer)
        {
            //横坐标位移的下一个位置的横坐标
            float currentX = player.transform.position.x + dx;
            //纵坐标位移的下一个位置的纵坐标
            float currentY = player.transform.position.y + dy;
            //可移动位置加入
            movingObjects.Add(player);
            //反复循环(建议先不写死循环 
            for (int i = 0; i < 30; i++)
            {
                //先设定未检查到
                bool check = false;
                //所有物体遍历
                foreach (GameObject allobj in allObjects)
                {
                    //遍历的物品中与该物体下次位移的位置重合
                    if (allobj.transform.position.x == currentX && allobj.transform.position.y == currentY)
                    {
                        //如果改是静止 且 无法被推动
                        if (allobj.GetComponent<Rule>().isStop && (!allobj.GetComponent<Rule>().isPush))
                        {
                            //则返回目前能推动的当前物体
                            return new List<GameObject>();
                        }
                        //不能被推动 则跳过此次循环
                        if (!allobj.GetComponent<Rule>().isPush) continue;
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
