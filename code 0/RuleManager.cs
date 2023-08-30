using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//规则的管理脚本
public class RuleManager : MonoBehaviour
{
    //静态实例化
    private static RuleManager instance;

    //
    public List<GameObject> isObject = new List<GameObject>();

    void Awake()
    {
        //唤醒后 初始化
        if (instance == null) instance = this;
        else Destroy(this.gameObject);
    }

    //静态实例化
    public static RuleManager Instance
    {
        get
        {
            //初始化
            if (instance == null) return null;
            return instance;
        }
    }

    void Start()
    {
        //在所有物体中寻找is
        foreach (GameObject ob in PlayerMove.Instance.allObjects)
        {
            //加入is的对象
            if (ob.name == "Is(Clone)") isObject.Add(ob);
        }
    }

    void Update()
    {
        //如果按下R
        if (Input.GetKeyDown(KeyCode.R))
        {
            //重新加载当前场景
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        //如果按下esc键
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //回到初始界面
            SceneManager.LoadScene(0);
        }
        //待增加Z键功能 回退一次操作
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //撤销一次上次的操作
        }
    }

    //检查是否有规则成立
    public bool[] checkTrue(GameObject io, bool[] bools)
    {
        //逻辑变量
        bool leftWall = false,
                topWall = false,
                leftBaba = false,
                topBaba = false,
                leftFlag = false,
                topFlag = false,
                rightStop = false,
                bottomStop = false,
                rightYou = false,
                bottomYou = false,
                rightWin = false,
                bottomWin = false,
                rightPush = false,
                bottomPush = false;

        //便利is 查看是否成立
        foreach (GameObject ao in PlayerMove.Instance.allObjects)
        {
            //搜寻is左边有什么
            if ((io.transform.position.x - 1 == ao.transform.position.x) && (io.transform.position.y == ao.transform.position.y))
            {
                if (ao.name == "WallString(Clone)") leftWall = true;//有wall
                if (ao.name == "BabaString(Clone)") leftBaba = true;//有baba
                if (ao.name == "FlagString(Clone)") leftFlag = true;//有flag
            }
            //搜寻is上方有什么
            if ((io.transform.position.y + 1 == ao.transform.position.y) && (io.transform.position.x == ao.transform.position.x))
            {
                if (ao.name == "WallString(Clone)") topWall = true;//有wall
                if (ao.name == "BabaString(Clone)") topBaba = true;//有baba
                if (ao.name == "FlagString(Clone)") topFlag = true;
            }
            //搜寻is右方有什么
            if ((io.transform.position.x + 1 == ao.transform.position.x) && (io.transform.position.y == ao.transform.position.y))
            {
                if (ao.name == "Stop(Clone)") rightStop = true;
                if (ao.name == "You(Clone)") rightYou = true;
                if (ao.name == "Win(Clone)") rightWin = true;
                if (ao.name == "Push(Clone)") rightPush = true;
            }
            //搜寻is下方有什么
            if ((io.transform.position.y - 1 == ao.transform.position.y) && (io.transform.position.x == ao.transform.position.x))
            {
                if (ao.name == "Stop(Clone)") bottomStop = true;
                if (ao.name == "You(Clone)") bottomYou = true;
                if (ao.name == "Win(Clone)") bottomWin = true;
                if (ao.name == "Push(Clone)") bottomPush = true;
            }
        }

        //is规则的判断
        //不可穿过
        if ((leftBaba && rightStop) || (topBaba && bottomStop)) bools[0] = true; //baba is stop
        if ((leftWall && rightStop) || (topWall && bottomStop)) bools[1] = true; //wall is stop
        if ((leftFlag && rightStop) || (topFlag && bottomStop)) bools[2] = true; //flag is stop

        //移动对象
        if ((leftBaba && rightYou) || (topBaba && bottomYou)) bools[3] = true;   //baba is you
        if ((leftWall && rightYou) || (topWall && bottomYou)) bools[4] = true;   //wall is you
        if ((leftFlag && rightYou) || (topFlag && bottomYou)) bools[5] = true;   //falg is you

        //胜利物体
        if ((leftBaba && rightWin) || (topBaba && bottomWin)) bools[6] = true;   //baba is win
        if ((leftWall && rightWin) || (topWall && bottomWin)) bools[7] = true;   //wall is win
        if ((leftFlag && rightWin) || (topFlag && bottomWin)) bools[8] = true;   //falg is win

        //可推动
        if ((leftBaba && rightPush) || (topBaba && bottomPush)) bools[9] = true; //baba is push
        if ((leftWall && rightPush) || (topWall && bottomPush)) bools[10] = true;//wall is push
        if ((leftFlag && rightPush) || (topFlag && bottomPush)) bools[11] = true;//flag is push


        //返回最终成立的规则
        return bools;
    }

    //每一次触发触发器(触碰或是离开)时 调用一次该函数检查当前所属的所有规则是否有变化
    public void isWhat()
    {
        //创建当前关卡有那些规则成立了 (声明时默认false)
        bool[] bools = new bool[1000];
        //检查是否有规则成立
        foreach (GameObject obj in isObject)
        {
            //以检查函数返回成立的规则bool赋值在bools上
            bools = checkTrue(obj, bools);
        }

        //以下开始计量符合规则下的相应措施


        //不可穿过 is stop
        if (true)
        {
            if (bools[0])
            {
                //baba is stop
                foreach (GameObject obj in PlayerMove.Instance.allObjects)
                {
                    if (obj.name == "Baba") obj.GetComponent<Rule>().isStop = true;
                }
            }
            else
            {
                //没有baba is stop
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Baba") ob.GetComponent<Rule>().isStop = false;
                }
            }
            if (bools[1])
            {
                //wall is stop
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Wall(Clone)") ob.GetComponent<Rule>().isStop = true;
                }
            }
            else
            {
                //没有wall is stop
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Wall(Clone)") ob.GetComponent<Rule>().isStop = false;
                }
            }
            if (bools[2])
            {
                //falg is stop
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Flag(Clone)") ob.GetComponent<Rule>().isStop = true;
                }
            }
            else
            {
                //没有falg is stop
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Flag(Clone)") ob.GetComponent<Rule>().isStop = false;
                }
            }
        }


        //可移动对象 is you
        if (true)
        {
            if (bools[3])
            {
                //baba is you
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Baba") ob.GetComponent<Rule>().isYou = true;
                }
            }
            else
            {
                //没有baba is you
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Baba") ob.GetComponent<Rule>().isYou = false;
                }
            }
            if (bools[4])
            {
                //wall is you
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Wall(Clone)") ob.GetComponent<Rule>().isYou = true;
                }
            }
            else
            {
                //没有wall is you
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Wall(Clone)") ob.GetComponent<Rule>().isYou = false;
                }
            }
            if (bools[5])
            {
                //falg is you
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Flag(Clone)") ob.GetComponent<Rule>().isYou = true;
                }
            }
            else
            {
                //没有falg is you
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Flag(Clone)") ob.GetComponent<Rule>().isYou = false;
                }
            }
            //将可移动所有变量加入
            PlayerMove.Instance.currentPlayer = new List<GameObject>();
            foreach (GameObject ob in PlayerMove.Instance.allObjects)
            {
                //加入is you的移动数组中
                if (ob.GetComponent<Rule>().isYou) PlayerMove.Instance.currentPlayer.Add(ob);
            }
        }


        //胜利物体 is win
        if (true)
        {
            if (bools[6])
            {
                //baba is win
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Baba") ob.GetComponent<Rule>().isWin = true;
                }
            }
            else
            {
                //没有baba is win
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Baba") ob.GetComponent<Rule>().isWin = false;
                }
            }
            if (bools[7])
            {
                //wall is win
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Wall(Clone)") ob.GetComponent<Rule>().isWin = true;
                }
            }
            else
            {
                //没有wall is win
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Wall(Clone)") ob.GetComponent<Rule>().isWin = false;
                }
            }
            if (bools[8])
            {
                //flag is win
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Flag(Clone)") ob.GetComponent<Rule>().isWin = true;
                }
            }
            else
            {
                //没有flag is win
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Flag(Clone)") ob.GetComponent<Rule>().isWin = false;
                }
            }
        }


        //可被推动 is push
        if (true)
        {
            if (bools[9])
            {
                //baba is push
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Baba") ob.GetComponent<Rule>().isPush = true;
                }
            }
            else
            {
                //没有baba is push
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Baba") ob.GetComponent<Rule>().isPush = false;
                }
            }
            if (bools[10])
            {
                //wall is push
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Wall(Clone)") ob.GetComponent<Rule>().isPush = true;
                }
            }
            else
            {
                //没有wall is push
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Wall(Clone)") ob.GetComponent<Rule>().isPush = false;
                }
            }
            if (bools[11])
            {
                //flag is push
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Flag(Clone)") ob.GetComponent<Rule>().isPush = true;
                }
            }
            else
            {
                //没有flag is push
                foreach (GameObject ob in PlayerMove.Instance.allObjects)
                {
                    if (ob.name == "Flag(Clone)") ob.GetComponent<Rule>().isPush = false;
                }
            }
        }

        //
    }

    //判定是否胜利游戏结束
    public bool isWin()
    {
        //便利is you的载具
        foreach (GameObject obj1 in PlayerMove.Instance.currentPlayer)
        {
            //如果(is you)同时(is win)则胜利游戏
            if (obj1.GetComponent<Rule>().isWin) return true;
            foreach (GameObject obj2 in PlayerMove.Instance.allObjects)
            {
                //同一物体 跳过
                if (obj1 == obj2) continue;
                //同一位置时
                if (obj1.transform.position == obj2.transform.position)
                {
                    //检查当前规则是否is win 是则跳过
                    if (obj2.GetComponent<Rule>().isWin) return true;
                }
            }
        }
        //返回未胜利
        return false;
    }
}
