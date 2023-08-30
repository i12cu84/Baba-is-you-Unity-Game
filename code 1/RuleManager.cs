using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
//规则的管理脚本
public class RuleManager : MonoBehaviour
{
    //静态实例化
    private static RuleManager instance;

    //静态实例化
    public static RuleManager Instance
    {
        get
        {
            //初始化
            return instance;
        }
    }

    //各项指标检测
    //初始化检测正常
    private bool InitCheck = true;
    //水平检测正常
    private bool HorizontalCheck = true;
    //垂直检测正常
    private bool VerticalCheck = true;
    //同异判断正常
    private bool BothCheck = true;
    //youCheck主体正常
    private bool PlayerCheck = true;
    //判定胜利正常
    private bool WinnowCheck = true;
    //sink检测正常
    private bool SinkCheck = true;
    //weak检测正常
    private bool WeakCheck = true;
    //defeat检测正常
    private bool DefeatCheck = true;
    //hotAndmeltCheck检测正常
    private bool HotMeltCheck = true;
    //tele检测正常
    private bool TeleCheck = true;
    //float检测正常
    private bool FloatCheck = true;
    //shutAndopenCheck检测正常
    private bool ShutOpenCheck = true;
    //moveCheck检测正常
    private bool MoveCheck = true;
    //pullCheck检测正常
    private bool PullCheck = true;
    //shiftCheck检测------------------------------------------------------- 略过
    private bool ShiftCheck = false;
    //upCheck检测正常
    private bool UpCheck = true;
    //rightCheck检测正常
    private bool RightCheck = true;
    //downCheck检测正常
    private bool DownCheck = true;
    //leftCheck检测正常
    private bool LeftCheck = true;
    //swapCheck检测正常
    private bool SwapCheck = true;
    //endCheck检测正常
    private bool EndCheck = true;
    //fallCheck检测正常
    private bool FallCheck = true;
    //moreCheck检测正常
    private bool MoreCheck = true;
    //wordCheck检测正常
    private bool WordCheck = true;
    //hideCheck检测正常
    private bool HideCheck = true;
    //bonusCheck检测正常
    private bool BonusCheck = true;
    //doneCheck检测正常
    private bool DoneCheck = true;


    //is预制体列表
    public List<GameObject> isObject_List = new List<GameObject>();

    //地图元素预制体
    public List<GameObject> Perfabs_List;

    //move的默认移动位置 (使用到的有 -> MoveCheck / ShiftCheck(未写) / UpCheck 
    //注:目前预制体还未配备朝向 因此在此暂用作测试
    private Vector3 MoveV3 = new Vector3(1, 0, 0);

    ////能够被推动 (使用到的有 -> PullCheck
    //private bool CanPull = false;

    //hide 隐藏的物体建立的list (使用到的有 -> HideCheck
    public List<GameObject> HidePerfabs_List;

    //唤醒初始化
    private void Awake()
    {
        instance = this;
        //唤醒后 初始化
        //if (instance == null) instance = this;
        //else Destroy(this.gameObject);
    }

    //寻找Is增加判定
    private void Start()
    {
        //在所有物体中寻找is
        foreach (GameObject obj in PlayerMove.Instance.allObjects)
        {
            //加入is的对象
            if (obj.name == "Is(Clone)" || obj.name == "Is")
            {
                //is的obj压入数组
                isObject_List.Add(obj);
            }
        }
        Iswhat();
    }

    private void Update()
    {
        //R Esc Z按键操作
        KeyCodeCheck();
    }

    //R Esc Z按键操作
    private void KeyCodeCheck()
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
            //撤销一次上次的操作 未完待续
        }
    }

    //将所有检测变成可用状态
    public void CheckToTrue()
    {
        //各项指标检测
        //初始化检测正常
        InitCheck = true;
        //水平检测正常
        HorizontalCheck = true;
        //垂直检测正常
        VerticalCheck = true;
        //同异判断正常
        BothCheck = true;
        //youCheck主体正常
        PlayerCheck = true;
        //判定胜利正常
        WinnowCheck = true;
        //sink检测正常
        SinkCheck = true;
        //weak检测正常
        WeakCheck = true;
        //defeat检测正常
        DefeatCheck = true;
        //hotAndmeltCheck检测正常
        HotMeltCheck = true;
        //tele检测正常
        TeleCheck = true;
        //float检测正常
        FloatCheck = true;
        //shutAndopenCheck检测正常
        ShutOpenCheck = true;
        //moveCheck检测正常
        MoveCheck = true;
        //pullCheck检测正常
        PullCheck = true;
        //shiftCheck检测正常
        ShiftCheck = true;
        //upCheck检测正常
        UpCheck = true;
        //rightCheck检测正常
        RightCheck = true;
        //downCheck检测正常
        DownCheck = true;
        //leftCheck检测正常
        LeftCheck = true;
        //swapCheck检测正常
        SwapCheck = true;
        //endCheck检测正常
        EndCheck = true;
        //fallCheck检测正常
        FallCheck = true;
        //moreCheck检测正常
        MoreCheck = true;
        //wordCheck检测正常
        WordCheck = true;
        //hideCheck检测正常
        HideCheck = true;
        //bonusCheck检测正常
        BonusCheck = true;
        //doneCheck检测正常
        DoneCheck = true;
    }

    //每一次触发触发器(触碰或是离开)时 调用一次该函数检查当前所属的所有规则是否有变化
    public void Iswhat(int MoveState = 0)
    {
        //初始化检测正常
        if (InitCheck)
        {
            //初始化规则
            Rule.Instance.Init();//测试阶段因此注释跳过
        }
        //定义Rlue长度的bool what is / is what
        bool[] Perfab_boolis = new bool[Rule.Perfabssize], Order_isbool = new bool[Rule.Orderssize];
        //水平检测正常
        if (HorizontalCheck)
        {
            //检查is的左右是否有规则成立
            foreach (GameObject isobj in isObject_List)
            {
                //初始化默认数组变量
                for (int i = 0; i < Rule.Perfabssize; i++)
                {
                    //what is ->false
                    Perfab_boolis[i] = false;
                }
                //初始化默认数组变量
                for (int i = 0; i < Rule.Orderssize; i++)
                {
                    //is waht ->false
                    Order_isbool[i] = false;
                }
                //以检查函数返回成立的规则bool赋值在bools上
                foreach (GameObject allobj in PlayerMove.Instance.allObjects)
                {
                    //Debug.Log(ao.name);
                    //搜寻is左边有什么 -> what(ao) is
                    //注:这里float以"=="计算不太严谨 应当使用System.Math.Abs(float-float)<0.5f取绝对值来计算 不过工程量巨大而没有修改 以后会注意
                    if ((isobj.transform.position.x + 1 == allobj.transform.position.x) &&
                        (isobj.transform.position.y == allobj.transform.position.y) &&
                        (isobj.transform.position.z == allobj.transform.position.z))
                    {
                        //Debug.Log("right1" + ao.name);
                        //验证是否存在
                        if (Rule.Instance.OrdersDictionary.ContainsKey(allobj.name.Replace("(Clone)", "")))
                        {
                            //Debug.Log("right2" + ao.name);
                            //划为真
                            Order_isbool[Rule.Instance.OrdersDictionary[allobj.name.Replace("(Clone)", "")]] = true;
                        }
                    }
                    //搜寻is右边有什么 -> is what(ao)
                    if ((isobj.transform.position.x - 1 == allobj.transform.position.x) &&
                        (isobj.transform.position.y == allobj.transform.position.y) &&
                        (isobj.transform.position.z == allobj.transform.position.z))
                    {
                        //Debug.Log("left1" + ao.name);
                        //验证是否存在
                        if (Rule.Instance.PerfabsDictionary.ContainsKey(allobj.name.Replace("String(Clone)", "")))
                        {
                            //Debug.Log("left2" + ao.name);
                            //划为真
                            Perfab_boolis[Rule.Instance.PerfabsDictionary[allobj.name.Replace("String(Clone)", "")]] = true;
                        }
                    }
                    //然后成立规则 左值循环
                    for (int i = 0; i < Rule.Perfabssize; i++)
                    {
                        //左值为真
                        if (Perfab_boolis[i])
                        {
                            //Debug.Log(Rule.Instance.Perfabs[i]);
                            //右值循环
                            for (int j = 0; j < Rule.Orderssize; j++)
                            {
                                //右值为真
                                if (Order_isbool[j])
                                {
                                    //且此时规则不成立时修改 成立则跳过(此时将InitChcek模块注释
                                    if (Rule.Instance.Rules[i, j] == false)
                                    {
                                        //控制端显示成立的规则
                                        Debug.Log(Rule.Instance.Perfabs[i] + " is " + Rule.Instance.Orders[j] + " : true------1");
                                        //规则成立
                                        Rule.Instance.Rules[i, j] = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //垂直检测正常
        if (VerticalCheck)
        {
            //检查is的左右是否有规则成立
            foreach (GameObject io in isObject_List)
            {
                //初始化默认数组变量
                for (int i = 0; i < Rule.Perfabssize; i++)
                {
                    //what is ->false
                    Perfab_boolis[i] = false;
                }
                //初始化默认数组变量
                for (int i = 0; i < Rule.Orderssize; i++)
                {
                    //is waht ->false
                    Order_isbool[i] = false;
                }
                //以检查函数返回成立的规则bool赋值在bools上
                foreach (GameObject ao in PlayerMove.Instance.allObjects)
                {
                    //Debug.Log(ao.name);
                    //搜寻is左边有什么 -> what(ao) is
                    if ((io.transform.position.x == ao.transform.position.x) &&
                        (io.transform.position.y - 1 == ao.transform.position.y) &&
                        (io.transform.position.z == ao.transform.position.z))
                    {
                        //Debug.Log("right1" + ao.name);
                        //验证是否存在
                        if (Rule.Instance.OrdersDictionary.ContainsKey(ao.name.Replace("(Clone)", "")))
                        {
                            //Debug.Log("right2" + ao.name);
                            //划为真
                            Order_isbool[Rule.Instance.OrdersDictionary[ao.name.Replace("(Clone)", "")]] = true;
                        }
                    }
                    //搜寻is右边有什么 -> is what(ao)
                    if ((io.transform.position.x == ao.transform.position.x) &&
                        (io.transform.position.y + 1 == ao.transform.position.y) &&
                        (io.transform.position.z == ao.transform.position.z))
                    {
                        //Debug.Log("left1" + ao.name);
                        //验证是否存在
                        if (Rule.Instance.PerfabsDictionary.ContainsKey(ao.name.Replace("String(Clone)", "")))
                        {
                            //Debug.Log("left2" + ao.name);
                            //划为真
                            Perfab_boolis[Rule.Instance.PerfabsDictionary[ao.name.Replace("String(Clone)", "")]] = true;
                        }
                    }
                    //然后成立规则 左值循环
                    for (int i = 0; i < Rule.Perfabssize; i++)
                    {
                        //左值为真
                        if (Perfab_boolis[i])
                        {
                            //Debug.Log(Rule.Instance.Perfabs[i]);
                            //右值循环
                            for (int j = 0; j < Rule.Orderssize; j++)
                            {
                                //右值为真
                                if (Order_isbool[j])
                                {
                                    //控制端显示成立的规则
                                    Debug.Log(Rule.Instance.Perfabs[i] + " is " + Rule.Instance.Orders[j] + " : true------1");
                                    //规则成立
                                    Rule.Instance.Rules[i, j] = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        //同异规则检测正常
        if (BothCheck)
        {

            //在已知flag is flag的情况下将falg is baba条件作废
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //Rule的属性开始循环
                for (int j = Rule.Orderssize - Rule.Perfabssize - 1; j < Rule.Orderssize; j++)
                {
                    //此时 Rule.Instance.Perfabs[i] is Rule.Instance.Orders[j]
                    if (Rule.Instance.Rules[i, j])
                    {
                        //此时输出 Flag is FlagString : true------3
                        Debug.Log(Rule.Instance.Perfabs[i] + " is " + Rule.Instance.Orders[j] + " : true------3");
                        //当Flag == FalgString(Replace"String") 
                        if (Rule.Instance.Perfabs[i] == Rule.Instance.Orders[j].Replace("String", ""))
                        {
                            //将 Flag is what 的Rule ->false
                            for (int k = Rule.Orderssize - Rule.Perfabssize - 1; k < Rule.Orderssize; k++)
                            {
                                //找到Flag is BabaString (j=k时 是Flag is FlagString
                                if (Rule.Instance.Rules[i, k] && j != k)
                                {
                                    //显示变false的指令
                                    Debug.Log(Rule.Instance.Perfabs[i] + " is " + Rule.Instance.Orders[k] + " : be false------4");
                                    //修改为false
                                    Rule.Instance.Rules[i, k] = false;
                                }
                            }
                            //Rule.Instance.Rules[i, j] = false;
                        }
                    }
                }
            }
            //flag is baba(Flag is BabaString) flag->baba
            //Rule的预制体开始循环
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //Rule的属性开始循环
                for (int j = Rule.Orderssize - Rule.Perfabssize - 2; j < Rule.Orderssize; j++)
                {
                    //此时 Rule.Instance.Perfabs[i] is Rule.Instance.Orders[j]
                    if (Rule.Instance.Rules[i, j])
                    {
                        //测试输出 Flag is BabaString 需要寻找所有flag将falg变成baba
                        Debug.Log(Rule.Instance.Perfabs[i] + " is " + Rule.Instance.Orders[j] + " : true------5");
                        foreach (GameObject obj in PlayerMove.Instance.allObjects)
                        {
                            //Falg(Clone)->Falg ->Baba
                            if (obj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                            {
                                //找到Flag
                                foreach (GameObject Perfab in Perfabs_List)
                                {
                                    //在Orders中寻找到BabaString 如果与Baba相同则
                                    if (Rule.Instance.Orders[j].Replace("String", "") == Perfab.name)
                                    {
                                        //在该位置布置Baba
                                        MapMaker.Instance.MakeCreateobject(Perfab,
                                            new Vector3(obj.transform.position.x, obj.transform.position.y, obj.transform.position.z));
                                    }
                                    //Debug.Log(obj.name + "55" + Perfab.name);
                                    //将obj放进渲染池
                                    if (true)
                                    {
                                        //将Flag(Clone)放进待渲染池
                                        obj.SetActive(false);
                                        //代替下一句
                                        //销毁obj
                                        //Destroy(obj);//bug:出现missing
                                        //PlayerMove.Instance.allObjects = new GameObject[100];
                                        //其实个人感觉应该写List比较好 但是PM中已经写了ob[]遂不做改变了
                                        //重新计算Tag为object到allObjects
                                        PlayerMove.Instance.allObjects = GameObject.FindGameObjectsWithTag("object");
                                        //Debug.Log(Rule.Instance.Perfabs[i] + "1");//Falg
                                        //Debug.Log(obj.name + "2");//Falg(Clone)
                                        //Debug.Log(Rule.Instance.Orders[j].Replace("String", "")+"777");//Baba
                                        //Debug.Log(obj.name.Replace("String(Clone)", "") + "6666");

                                        //寻找需要制造的Baba的Perfab
                                        //Debug.Log(Rule.Instance.Orders[j].Replace("String", ""));//返回Baba

                                        //MapMaker.Instance.SuchCreateobject( (Rule.Instance.Orders[j].Replace("String", "").ToString),
                                        //    new Vector3(obj.transform.position.x, obj.transform.position.y, 0));
                                        //Destroy(obj);

                                        //GameObject ob =  MapMaker.Instance.ReturnPerfab("Baba");
                                        //if (ob != null)
                                        //{
                                        //    //在Flag的位置生成Baba
                                        //    //MapMaker.Instance.MakeCreateobject(ob, new Vector3(obj.transform.position.x, obj.transform.position.y, 0));
                                        //    //销毁Flag
                                        //    Destroy(obj);
                                        //}


                                        //foreach(GameObject Perfab in MapMaker.Instance.Prefabs)
                                        //{
                                        //    Debug.Log(Perfab.name);
                                        //    //if(Perfab.name)
                                        //}
                                        //Baba?
                                        //Debug.Log(Rule.Instance.Orders[j].Replace("String", "")+"111111111");
                                        //制造相应的物体 Rule.Instance.Orders[j]是BabaString 因此需要的是Baba
                                        //MapMaker.Instance.MakeCreateobject()
                                        //MapMaker.Instantiate.createObject =
                                        //    Instantiate(obj, new Vector3(obj.transform.position.x, obj.transform.position.y, 0), Quaternion.identity);
                                    }//可能存有bug
                                }
                            }
                        }
                    }
                }
            }
            //Debug.Log("baba is you" + Rule.Instance.Rules[1, 0]);//baba is you
        }
        //youCheck检测正常
        if (PlayerCheck)
        {
            ////清空可移动变量
            //PlayerMove.Instance.currentPlayer.Clear();
            //将可移动所有变量加入
            PlayerMove.Instance.currentPlayer = new List<GameObject>();
            //将is you的obj存入currentPlayer的list中
            foreach (GameObject obj in PlayerMove.Instance.allObjects)
            {
                //确认字典中是否存在该物 如BabaString(Clone)中搜寻找Baba是否存在
                if (Rule.Instance.PerfabsDictionary.ContainsKey(obj.name.Replace("String(Clone)", "")))
                {
                    //验证baba is you是否成立
                    if (Rule.Instance.Rules[Rule.Instance.PerfabsDictionary[obj.name.Replace("String(Clone)", "")], Rule.Instance.OrdersDictionary["You"]])
                    {
                        //Debug.Log(obj.name.Replace("String(Clone)", "")+ "-----4");
                        //成立的情况下在obj中寻找所有的Baba
                        foreach (GameObject obj2 in PlayerMove.Instance.allObjects)
                        {
                            // 并将其存入currentPlayer的list中
                            if (obj2.name.Replace("(Clone)", "") == obj.name.Replace("String(Clone)", ""))
                            {
                                //Debug.Log("save object :" + obj2.name.Replace("String(Clone)", "")+"-------3");
                                //存入
                                PlayerMove.Instance.currentPlayer.Add(obj2);
                            }
                        }
                    }
                }
            }
        }
        //winCheck检测正常
        if (WinnowCheck)
        {
            //默认没有胜利
            bool win = false;
            //便利is you的载具
            foreach (GameObject obj1 in PlayerMove.Instance.currentPlayer)
            {
                //如果(is you)同时(is win)则胜利游戏
                //Debug.Log(obj1.name.Replace("(Clone)", "")+" you can control now --------1");
                //确认字典中是否存在该物 如BabaString(Clone)中搜寻找Baba是否存在
                if (Rule.Instance.PerfabsDictionary.ContainsKey(obj1.name.Replace("(Clone)", "")))
                {
                    //判断 what is win (Rule=True
                    if (Rule.Instance.Rules[Rule.Instance.PerfabsDictionary[obj1.name.Replace("(Clone)", "")], Rule.Instance.OrdersDictionary["Win"]])
                    {
                        //胜利
                        win = true;
                    }
                }
                //循环全部object标签物体
                foreach (GameObject obj2 in PlayerMove.Instance.allObjects)
                {
                    //同一物体
                    if (obj1 == obj2)
                    {
                        //跳过
                        continue;
                    }
                    //同一位置时
                    if (obj1.transform.position == obj2.transform.position)
                    {
                        //确认字典中是否存在该物 如BabaString(Clone)中搜寻找Baba是否存在
                        if (Rule.Instance.PerfabsDictionary.ContainsKey(obj2.name.Replace("(Clone)", "")))
                        {
                            //检查当前规则是否is win 是则跳过
                            if (Rule.Instance.Rules[Rule.Instance.PerfabsDictionary[obj2.name.Replace("(Clone)", "")], Rule.Instance.OrdersDictionary["Win"]])
                            {
                                //胜利
                                win = true;
                            }
                        }
                    }
                }
            }
            //如果胜利则
            if (win)
            {
                Debug.Log("you win!");
                //返回菜单
                SceneManager.LoadScene("Menu");
            }
        }
        //sinkCheck检测正常
        if (SinkCheck)
        {
            //找到sink的字典位置
            //int j = Rule.Instance.OrdersDictionary["Sink"];
            //Debug.Log(j);//debug 4
            //寻找成立sink的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is sink
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Sink"]])
                {
                    //Debug.Log(Rule.Instance.Perfabs[i]);//debug baba
                    //找到what
                    foreach (GameObject sinkobj in PlayerMove.Instance.allObjects)
                    {
                        //Debug.Log(sinkobj.name);//Baba(Clone)
                        if (sinkobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //Baba
                            //Debug.Log(1);
                            //sinkobj.transform.position.x
                            foreach (GameObject sinkobj2 in PlayerMove.Instance.allObjects)
                            {
                                //Debug.Log(2);
                                //Debug.Log(sinkobj.name.Replace("(Clone)", ""));
                                //Debug.Log(Rule.Instance.Perfabs[i]);
                                //找到非Baba
                                if (sinkobj2.name.Replace("(Clone)", "") != Rule.Instance.Perfabs[i])
                                {
                                    //Debug.Log(3);
                                    //找到与Baba重叠的物体
                                    if (sinkobj.transform.position.x == sinkobj2.transform.position.x &&
                                        sinkobj.transform.position.y == sinkobj2.transform.position.y &&
                                        sinkobj.transform.position.z == sinkobj2.transform.position.z)
                                    {
                                        //Debug.Log(4);
                                        //将obj放进渲染池
                                        if (true)
                                        {
                                            //Baba 
                                            sinkobj.SetActive(false);
                                            //Flag
                                            sinkobj2.SetActive(false);
                                            //重新计算Tag为object到allObjects
                                            PlayerMove.Instance.allObjects = GameObject.FindGameObjectsWithTag("object");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //weakCheck检测正常
        if (WeakCheck)
        {
            //找到weak的字典位置
            //int j = Rule.Instance.OrdersDictionary["Weak"];
            //Debug.Log(j);//debug 5
            //寻找成立weak的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is weak
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Weak"]])
                {
                    //Debug.Log(Rule.Instance.Perfabs[i]);//debug baba
                    //找到what
                    foreach (GameObject weakobj in PlayerMove.Instance.allObjects)
                    {
                        //Debug.Log(weakobj.name);//Baba(Clone)
                        if (weakobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //Baba
                            //Debug.Log(1);
                            //sinkobj.transform.position.x
                            foreach (GameObject weakobj2 in PlayerMove.Instance.allObjects)
                            {
                                //Debug.Log(2);
                                //Debug.Log(weakobj.name.Replace("(Clone)", ""));
                                //Debug.Log(Rule.Instance.Perfabs[i]);
                                //找到非Baba
                                if (weakobj2.name.Replace("(Clone)", "") != Rule.Instance.Perfabs[i])
                                {
                                    //Debug.Log(3);
                                    //找到与Baba重叠的物体
                                    if (weakobj.transform.position.x == weakobj2.transform.position.x &&
                                        weakobj.transform.position.y == weakobj2.transform.position.y &&
                                        weakobj.transform.position.z == weakobj2.transform.position.z)
                                    {
                                        //Debug.Log(4);
                                        //将obj放进渲染池
                                        if (true)
                                        {
                                            //Baba 
                                            weakobj.SetActive(false);
                                            //Flag
                                            //weakobj2.SetActive(false);
                                            //重新计算Tag为object到allObjects
                                            PlayerMove.Instance.allObjects = GameObject.FindGameObjectsWithTag("object");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //defeatCheck检测正常
        if (DefeatCheck)
        {
            //找到defeat的字典位置
            //int j = Rule.Instance.OrdersDictionary["Defeat"];
            //Debug.Log(j);//debug 6
            //寻找成立defeat的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is defeat
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Defeat"]])
                {
                    //Debug.Log(Rule.Instance.Perfabs[i]);//debug baba
                    //找到what
                    foreach (GameObject defeatobj in PlayerMove.Instance.allObjects)
                    {
                        //Debug.Log(defeatobj.name);//Baba(Clone)
                        if (defeatobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //Baba
                            //Debug.Log(1);
                            //defeatobj.transform.position.x
                            foreach (GameObject defeatobj2 in PlayerMove.Instance.allObjects)
                            {
                                //Debug.Log(2);
                                //Debug.Log(defeatobj.name.Replace("(Clone)", ""));
                                //Debug.Log(Rule.Instance.Perfabs[i]);
                                //找到非Baba
                                if (defeatobj2.name.Replace("(Clone)", "") != Rule.Instance.Perfabs[i])
                                {
                                    //Debug.Log(3);
                                    //找到与Baba重叠的物体
                                    if (defeatobj.transform.position.x == defeatobj2.transform.position.x &&
                                        defeatobj.transform.position.y == defeatobj2.transform.position.y &&
                                        defeatobj.transform.position.z == defeatobj2.transform.position.z)
                                    {
                                        //Debug.Log(4);
                                        //将obj放进渲染池
                                        if (true)
                                        {
                                            //如果失败则
                                            Debug.Log("you defeat!");
                                            //返回菜单
                                            SceneManager.LoadScene("Menu");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //hotAndmeltCheck检测正常
        if (HotMeltCheck)
        {
            //寻找成立melt的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is melt
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Melt"]])
                {
                    //找到what
                    foreach (GameObject meltobj in PlayerMove.Instance.allObjects)
                    {
                        //what is hot
                        if (meltobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //寻找成立hot的obj
                            foreach (GameObject hotobj in PlayerMove.Instance.allObjects)
                            {
                                //Debug.Log(hotobj.name);//debug Wall(Clone)
                                if (Rule.Instance.PerfabsDictionary.ContainsKey(hotobj.name.Replace("(Clone)", "")))
                                {
                                    //判断当前obj是否为hot (即 obj is hot
                                    if (Rule.Instance.Rules[Rule.Instance.PerfabsDictionary[(hotobj.name.Replace("(Clone)", ""))], Rule.Instance.OrdersDictionary["Hot"]])
                                    {
                                        //找到非Baba
                                        if (hotobj.name.Replace("(Clone)", "") != Rule.Instance.Perfabs[i])
                                        {
                                            //找到与Baba重叠的物体
                                            if (meltobj.transform.position.x == hotobj.transform.position.x &&
                                                meltobj.transform.position.y == hotobj.transform.position.y &&
                                                meltobj.transform.position.z == hotobj.transform.position.z)
                                            {
                                                //将meltobj放进渲染池
                                                if (true)
                                                {
                                                    //Baba 
                                                    meltobj.SetActive(false);
                                                    //重新计算Tag为object到allObjects
                                                    PlayerMove.Instance.allObjects = GameObject.FindGameObjectsWithTag("object");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //teleCheck检测正常
        if (TeleCheck)
        {
            //寻找成立tele的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is tele
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Tele"]])
                {
                    //找到what
                    foreach (GameObject teleobjfrom in PlayerMove.Instance.allObjects)
                    {
                        //以belt is tele为例
                        if (teleobjfrom.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //找到和blet重叠的Baba
                            foreach (GameObject teleobj in PlayerMove.Instance.allObjects)
                            {
                                //找到与Belt重叠的物体
                                if (teleobjfrom.transform.position.x == teleobj.transform.position.x &&
                                    teleobjfrom.transform.position.y == teleobj.transform.position.y &&
                                    teleobjfrom.transform.position.z == teleobj.transform.position.z &&
                                    teleobj.name != teleobjfrom.name)
                                {
                                    //Debug.Log(teleobjfrom + "1");//Belt
                                    //Debug.Log(teleobj + "2");//Baba
                                    //将Baba移动到另一个物体上
                                    foreach (GameObject teleobjto in PlayerMove.Instance.allObjects)
                                    {
                                        //找到同名物体且在不同位置
                                        if (teleobjfrom.name == teleobjto.name &&
                                            (!(teleobjfrom.transform.position.x == teleobjto.transform.position.x &&
                                            teleobjfrom.transform.position.y == teleobjto.transform.position.y &&
                                            teleobjfrom.transform.position.z == teleobjto.transform.position.z)) &&
                                            TeleCheck)
                                        {
                                            //将Baba位置修改到第二个teleobj的位置上
                                            //teleobj.transform.Translate(new Vector3(teleobjfrom.transform.position.x, teleobjfrom.transform.position.y, 0));
                                            //Debug.Log("from " + teleobjfrom.transform.position.x + teleobjfrom.transform.position.y + teleobjfrom.transform.position.z);
                                            //Debug.Log("obj " + teleobj.transform.position.x + teleobj.transform.position.y +  teleobj.transform.position.z);
                                            //Debug.Log("to " + teleobjto.transform.position.x + teleobjto.transform.position.y +  teleobjto.transform.position.z);
                                            teleobj.transform.localPosition = new Vector3(teleobjto.transform.position.x,
                                                teleobjto.transform.position.y, teleobjto.transform.position.z);
                                            Debug.Log("change to x:" + teleobj.transform.position.x + ",y:" + teleobj.transform.position.y +
                                                ",z:" + teleobj.transform.position.z);
                                            //已经传送一次 暂停传送
                                            TeleCheck = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //floatCheck检测正常
        if (FloatCheck)
        {
            //初始化非float情况
            foreach (GameObject nofloatobj in PlayerMove.Instance.allObjects)
            {
                //浮动因此让z轴变为1
                nofloatobj.transform.localPosition = new Vector3(nofloatobj.transform.position.x,
                    nofloatobj.transform.position.y, 0);
            }
            //寻找成立float的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is tele
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Float"]])
                {
                    //找到what
                    foreach (GameObject floatobj in PlayerMove.Instance.allObjects)
                    {
                        //以Baba is float为例
                        if (floatobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            Debug.Log("be float");
                            //浮动因此让z轴变为1
                            floatobj.transform.localPosition = new Vector3(floatobj.transform.position.x,
                                floatobj.transform.position.y, 1);
                        }
                    }
                }
            }

        }
        //shutAndopenCheck检测正常
        if (ShutOpenCheck)
        {
            //寻找成立shut的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //规则what is shut成立
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Shut"]])
                {
                    //找到what is shut
                    foreach (GameObject shutobj in PlayerMove.Instance.allObjects)
                    {
                        //what is open
                        if (shutobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //找到 what is open
                            foreach (GameObject openobj in PlayerMove.Instance.allObjects)
                            {
                                //确认是否在预制体字典中
                                if (Rule.Instance.PerfabsDictionary.ContainsKey(openobj.name.Replace("(Clone)", "")))
                                {
                                    //判断当前obj是否为open (即 obj is open
                                    if (Rule.Instance.Rules[Rule.Instance.PerfabsDictionary[(openobj.name.Replace("(Clone)", ""))], Rule.Instance.OrdersDictionary["Open"]])
                                    {
                                        //找到非Baba
                                        if (openobj.name.Replace("(Clone)", "") != Rule.Instance.Perfabs[i])
                                        {
                                            //找到与Baba重叠的物体
                                            if (shutobj.transform.position.x == openobj.transform.position.x &&
                                                shutobj.transform.position.y == openobj.transform.position.y &&
                                                shutobj.transform.position.z == openobj.transform.position.z)
                                            {
                                                //将meltobj放进渲染池
                                                if (true)
                                                {
                                                    //Baba 
                                                    shutobj.SetActive(false);
                                                    //重新计算Tag为object到allObjects
                                                    PlayerMove.Instance.allObjects = GameObject.FindGameObjectsWithTag("object");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //思考:若是Door is Stop该如何...
        }
        //moveCheck检测正常
        if (MoveCheck)
        {
            //寻找成立move的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is move
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Move"]])
                {
                    //找到what
                    foreach (GameObject moveobj in PlayerMove.Instance.allObjects)
                    {
                        //以flag is move为例
                        if (moveobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //Debug.Log(moveobj.name);
                            //注:未修改朝向时 默认向右
                            moveobj.transform.Translate(MoveV3);
                        }
                    }
                }
            }
        }
        //pullCheck检测正常 
        if (PullCheck)
        {
            //MoveState 1上 2下 3左 4右
            if (MoveState == 3 || MoveState == 4)
            {
                //寻找成立pull的Prefab
                for (int i = 0; i < Rule.Perfabssize; i++)
                {
                    //what is pull
                    if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Pull"]])
                    {
                        //找到what
                        foreach (GameObject pullobj in PlayerMove.Instance.allObjects)
                        {
                            //以flag is pull为例
                            if (pullobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                            {
                                //寻找成立pull的Prefab
                                for (int j = 0; j < Rule.Perfabssize; j++)
                                {
                                    //what is you
                                    if (Rule.Instance.Rules[j, Rule.Instance.OrdersDictionary["You"]])
                                    {
                                        //找到what
                                        foreach (GameObject obj in PlayerMove.Instance.allObjects)
                                        {
                                            //以flag is pull为例
                                            if (obj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[j])
                                            {
                                                //player向左走 物体跟进
                                                if (MoveState == 3 &&
                                                    pullobj.transform.position.x - obj.transform.position.x <= 2.1f &&
                                                    1.9f <= pullobj.transform.position.x - obj.transform.position.x &&
                                                   pullobj.transform.position.y == obj.transform.position.y &&
                                                   pullobj.transform.position.z == obj.transform.position.z)
                                                {
                                                    //变更朝向 向左
                                                    MoveV3 = new Vector3(-1, 0, 0);
                                                    //向左移动一位
                                                    pullobj.transform.Translate(MoveV3);
                                                }
                                                else if //player向右走 物体跟进
                                                   (MoveState == 4 &&
                                                   pullobj.transform.position.x - obj.transform.position.x <= -1.9f &&
                                                   -2.1f <= pullobj.transform.position.x - obj.transform.position.x &&
                                                  pullobj.transform.position.y == obj.transform.position.y &&
                                                  pullobj.transform.position.z == obj.transform.position.z)
                                                {
                                                    //变更朝向 向右
                                                    MoveV3 = new Vector3(1, 0, 0);
                                                    //向右移动一位
                                                    pullobj.transform.Translate(MoveV3);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //shiftCheck检测(未写略过
        if (ShiftCheck)
        {

        }
        //upCheck检测正常
        if (UpCheck)
        {
            //寻找成立move的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is up
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Up"]])
                {
                    //找到what
                    foreach (GameObject moveobj in PlayerMove.Instance.allObjects)
                    {
                        //以flag is up为例
                        if (moveobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //Debug.Log(moveobj.name);
                            MoveV3 = new Vector3(0, 1, 0);
                            //moveobj.transform.Translate(MoveV3);
                        }
                    }
                }
            }
        }
        //rightCheck检测正常
        if (RightCheck)
        {
            //寻找成立move的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is right
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Right"]])
                {
                    //找到what
                    foreach (GameObject moveobj in PlayerMove.Instance.allObjects)
                    {
                        //以flag is up为例
                        if (moveobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //Debug.Log(moveobj.name);
                            MoveV3 = new Vector3(1, 0, 0);
                            //moveobj.transform.Translate(MoveV3);
                        }
                    }
                }
            }
        }
        //downCheck检测正常
        if (DownCheck)
        {
            //寻找成立move的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is right
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Down"]])
                {
                    //找到what
                    foreach (GameObject moveobj in PlayerMove.Instance.allObjects)
                    {
                        //以flag is up为例
                        if (moveobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //Debug.Log(moveobj.name);
                            MoveV3 = new Vector3(0, -1, 0);
                            //moveobj.transform.Translate(MoveV3);
                        }
                    }
                }
            }
        }
        //leftCheck检测正常
        if (LeftCheck)
        {
            //寻找成立move的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is right
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Left"]])
                {
                    //找到what
                    foreach (GameObject moveobj in PlayerMove.Instance.allObjects)
                    {
                        //以flag is up为例
                        if (moveobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //Debug.Log(moveobj.name);
                            MoveV3 = new Vector3(-1, 0, 0);
                            //moveobj.transform.Translate(MoveV3);
                        }
                    }
                }
            }
        }
        //swapCheck检测正常
        if (SwapCheck)
        {
            //注:目前仅写了与Player的swap功能(忘记原游戏的功能了
            //MoveState 1上 2下 3左 4右
            //寻找成立swap的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is swap
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Swap"]])
                {
                    //找到what
                    foreach (GameObject moveobj in PlayerMove.Instance.allObjects)
                    {
                        //以flag is swap为例
                        if (moveobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //寻找player
                            foreach (GameObject playerobj in PlayerMove.Instance.currentPlayer)
                            {
                                //当flag 和 player 重合时 互换位置
                                if (moveobj.transform.position.x == playerobj.transform.position.x &&
                                    moveobj.transform.position.y == playerobj.transform.position.y &&
                                    moveobj.transform.position.z == playerobj.transform.position.z)
                                {
                                    //player已经在PlayerMove脚本里移动了因此只需要移动该flag的位置即可
                                    //注:忘记swap是否影响朝向了 默认不影响
                                    if (MoveState == 1)//player向上 
                                    {
                                        //flag向下
                                        moveobj.transform.Translate(new Vector3(0, -1, 0));
                                    }
                                    else if (MoveState == 2)//player向下
                                    {
                                        // flag向上
                                        moveobj.transform.Translate(new Vector3(0, 1, 0));
                                    }
                                    else if (MoveState == 3)//player向左
                                    {
                                        //flag向右
                                        moveobj.transform.Translate(new Vector3(1, 0, 0));
                                    }
                                    else if (MoveState == 4)//player向右
                                    {
                                        // flag向左
                                        moveobj.transform.Translate(new Vector3(-1, 0, 0));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //endCheck检测正常
        if (EndCheck)
        {
            //默认没有结束
            bool end = false;
            //便利is you的载具
            foreach (GameObject obj1 in PlayerMove.Instance.currentPlayer)
            {
                //如果(is you)同时(is win)则胜利游戏
                //Debug.Log(obj1.name.Replace("(Clone)", "")+" you can control now --------1");
                //确认字典中是否存在该物 如BabaString(Clone)中搜寻找Baba是否存在
                if (Rule.Instance.PerfabsDictionary.ContainsKey(obj1.name.Replace("(Clone)", "")))
                {
                    //判断 what is win (Rule=True
                    if (Rule.Instance.Rules[Rule.Instance.PerfabsDictionary[obj1.name.Replace("(Clone)", "")], Rule.Instance.OrdersDictionary["End"]])
                    {
                        //结束
                        end = true;
                    }
                }
                //循环全部object标签物体
                foreach (GameObject obj2 in PlayerMove.Instance.allObjects)
                {
                    //同一物体
                    if (obj1 == obj2)
                    {
                        //跳过
                        continue;
                    }
                    //同一位置时
                    if (obj1.transform.position == obj2.transform.position)
                    {
                        //确认字典中是否存在该物 如BabaString(Clone)中搜寻找Baba是否存在
                        if (Rule.Instance.PerfabsDictionary.ContainsKey(obj2.name.Replace("(Clone)", "")))
                        {
                            //检查当前规则是否is win 是则跳过
                            if (Rule.Instance.Rules[Rule.Instance.PerfabsDictionary[obj2.name.Replace("(Clone)", "")], Rule.Instance.OrdersDictionary["Win"]])
                            {
                                //结束
                                end = true;
                            }
                        }
                    }
                }
            }
            //如果结束则
            if (end)
            {
                Debug.Log("End!");
                //缺少了某些动画
                //动画
                //返回菜单
                SceneManager.LoadScene("Menu");
            }

        }
        //fallCheck检测正常
        if (FallCheck)
        {
            //寻找成立Fall的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is fall
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Fall"]])
                {
                    //找到what
                    foreach (GameObject fallobj in PlayerMove.Instance.allObjects)
                    {
                        //以flag is fall为例
                        if (fallobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //一直掉落 掉落到屏幕底部
                            //while (fallobj.transform.position.y > -4.5f)
                            //
                            bool hasStop = false;
                            while (!hasStop)
                            {
                                if (fallobj.transform.position.y < -4.5) hasStop = true;
                                foreach (GameObject stopobj in PlayerMove.Instance.allObjects)
                                {
                                    //下方有物体
                                    if ((stopobj.transform.position.x - fallobj.transform.position.x) <= 0.5f &&
                                        (stopobj.transform.position.x - fallobj.transform.position.x) >= -0.5f &&
                                        (stopobj.transform.position.y - fallobj.transform.position.y) <= -0.5f &&
                                        (stopobj.transform.position.y - fallobj.transform.position.y) >= -1.5f &&
                                        (stopobj.transform.position.z - fallobj.transform.position.z) <= 0.5f &&
                                        (stopobj.transform.position.z - fallobj.transform.position.z) >= -0.5f)
                                    {
                                        //Rule.Instance.PerfabsDictionary("Wall");
                                        //Debug.Log("666"+Rule.Instance.PerfabsDictionary[stopobj.name.Replace("(Clone)", "")]);
                                        //碰到了stop而停下
                                        if (Rule.Instance.Rules[Rule.Instance.PerfabsDictionary[stopobj.name.Replace("(Clone)", "")], Rule.Instance.OrdersDictionary["Stop"]])
                                        {
                                            Debug.Log("stop to " + stopobj.name);
                                            hasStop = true;
                                        }
                                    }
                                }
                                //若是下方没有物体
                                if (!hasStop)
                                {
                                    //向下掉落
                                    fallobj.transform.Translate(new Vector3(0, -1, 0));
                                    //可以写入下落动画
                                }
                            }
                        }
                    }
                }
            }
        }
        //moreCheck检测正常
        if (MoreCheck)
        {
            //寻找成立more的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is more
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["More"]])
                {
                    //找到what
                    foreach (GameObject moreobj in PlayerMove.Instance.allObjects)
                    {
                        //以rock is more为例
                        if (moreobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //Debug.Log(moreobj.name+"-1");
                            //找到rock 注:我在此关卡的Perfab中添加了预制体 其他关卡有些忘记添加了
                            foreach (GameObject Perfab in Perfabs_List)
                            {
                                //Debug.Log(Perfab.name+"-2");
                                //在Perfab中找到rock
                                if (moreobj.name.Replace("(Clone)", "") == Perfab.name)
                                {
                                    //在rock的四面多出来
                                    //在该位置布置Rock 此时物体是可以重叠的
                                    MapMaker.Instance.MakeCreateobject(Perfab,
                                        new Vector3(moreobj.transform.position.x + 1, moreobj.transform.position.y, moreobj.transform.position.z));
                                    MapMaker.Instance.MakeCreateobject(Perfab,
                                        new Vector3(moreobj.transform.position.x - 1, moreobj.transform.position.y, moreobj.transform.position.z));
                                    MapMaker.Instance.MakeCreateobject(Perfab,
                                        new Vector3(moreobj.transform.position.x, moreobj.transform.position.y + 1, moreobj.transform.position.z));
                                    MapMaker.Instance.MakeCreateobject(Perfab,
                                        new Vector3(moreobj.transform.position.x, moreobj.transform.position.y - 1, moreobj.transform.position.z));
                                }
                            }
                        }
                    }
                }
            }
            //加入标签
            PlayerMove.Instance.allObjects = GameObject.FindGameObjectsWithTag("object");
        }
        //wordCheck检测正常
        if (WordCheck)
        {
            //寻找成立word的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is word
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Word"]])
                {
                    //找到what
                    foreach (GameObject objIsword in PlayerMove.Instance.allObjects)
                    {
                        //以rock is word为例
                        if (objIsword.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //Debug.Log(1);
                            //便利is来查看是否有规则成立
                            foreach (GameObject isobj in isObject_List)
                            {
                                //Debug.Log(2);
                                //is右边的情况
                                if (objIsword.transform.position.x + 1 == isobj.transform.position.x &&
                                    objIsword.transform.position.y == isobj.transform.position.y &&
                                    objIsword.transform.position.z == isobj.transform.position.z)
                                {
                                    //Debug.Log(3);
                                    foreach (GameObject word in PlayerMove.Instance.allObjects)
                                    {
                                        //找到右边的word
                                        if (isobj.transform.position.x + 1 == word.transform.position.x &&
                                            isobj.transform.position.y == word.transform.position.y &&
                                            isobj.transform.position.z == word.transform.position.z)
                                        {
                                            //此时 objisword(rock) isobj(is) word(push)                                            
                                            //检测字典中是否存在
                                            if (Rule.Instance.PerfabsDictionary.ContainsKey(objIsword.name.Replace("(Clone)", "")) &&
                                                Rule.Instance.OrdersDictionary.ContainsKey(word.name.Replace("(Clone)", "")))
                                            {
                                                Debug.Log(objIsword.name.Replace("(Clone)", "") + " " + isobj.name.Replace("(Clone)", "")
                                                    + " " + word.name.Replace("(Clone)", "") + "------6");//rock is push
                                                //成立规则
                                                Rule.Instance.Rules[Rule.Instance.PerfabsDictionary[objIsword.name.Replace("(Clone)", "")],
                                                Rule.Instance.OrdersDictionary[word.name.Replace("(Clone)", "")]] = true;
                                                //Rule.Instance.Rules
                                            }
                                        }
                                    }
                                }
                                //is下边的情况
                                if (objIsword.transform.position.x == isobj.transform.position.x &&
                                    objIsword.transform.position.y == isobj.transform.position.y + 1 &&
                                    objIsword.transform.position.z == isobj.transform.position.z)
                                {
                                    //Debug.Log(3);
                                    foreach (GameObject word in PlayerMove.Instance.allObjects)
                                    {
                                        //找到右边的word
                                        if (isobj.transform.position.x == word.transform.position.x &&
                                            isobj.transform.position.y == word.transform.position.y + 1 &&
                                            isobj.transform.position.z == word.transform.position.z)
                                        {
                                            //此时 objisword(rock) isobj(is) word(push)
                                            //检测字典中是否存在
                                            if (Rule.Instance.PerfabsDictionary.ContainsKey(objIsword.name.Replace("(Clone)", "")) &&
                                                Rule.Instance.OrdersDictionary.ContainsKey(word.name.Replace("(Clone)", "")))
                                            {
                                                Debug.Log(objIsword.name.Replace("(Clone)", "") + " " + isobj.name.Replace("(Clone)", "")
                                                    + " " + word.name.Replace("(Clone)", "") + "------7");//rock is push
                                                //成立规则
                                                Rule.Instance.Rules[Rule.Instance.PerfabsDictionary[objIsword.name.Replace("(Clone)", "")],
                                                Rule.Instance.OrdersDictionary[word.name.Replace("(Clone)", "")]] = true;
                                                //Rule.Instance.Rules
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //hideCheck检测正常
        if (HideCheck)
        {
            //便利list显示obj
            foreach (GameObject hideobj in HidePerfabs_List)
            {
                //显示该隐藏的obj
                hideobj.SetActive(true);
                //从隐藏列表中移除 invalidoperationexception异常的来源 不移除不影响 因此注释
                //HidePerfabs_List.Remove(hideobj);
            }
            //更迭allobj
            PlayerMove.Instance.allObjects = GameObject.FindGameObjectsWithTag("object");

            //由于需要拖动map因而(废弃 (太麻烦
            //GameObject root = GameObject.Find("Map");
            //GameObject rootChildren = root.transform.Find("Rock").gameObject;
            //root.SetActive(true);

            //方法效果不太好 (废弃
            //注:只写了hide的功能
            ////如果有hide属性 则先让所有物体显示
            //foreach (GameObject allobj in PlayerMove.Instance.allObjects)
            //{
            //    if (allobj.name.Replace("(Clone)", "") == "Hide")
            //    {
            //        foreach (GameObject SetActiveTrueobj in PlayerMove.Instance.allObjects)
            //        {
            //            SetActiveTrueobj.SetActive(true);
            //        }
            //    }
            //}
            //寻找成立hide的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is word
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Hide"]])
                {
                    //找到what
                    foreach (GameObject hideobj in PlayerMove.Instance.allObjects)
                    {
                        //以box is hide为例
                        if (hideobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            if (true)
                            {
                                HidePerfabs_List.Add(hideobj);
                                //将Flag(Clone)放进待渲染池
                                hideobj.SetActive(false);
                                //重新计算Tag为object到allObjects
                                //PlayerMove.Instance.allObjects = GameObject.FindGameObjectsWithTag("object");
                            }
                        }
                    }
                }
            }
        }
        //bonusCheck检测正常
        if (BonusCheck)
        {
            //寻找成立bonus的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is bonus
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Bonus"]])
                {
                    //找到what
                    foreach (GameObject bonusobj in PlayerMove.Instance.allObjects)
                    {
                        //以rock is bonus为例
                        if (bonusobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            foreach(GameObject Player in PlayerMove.Instance.currentPlayer)
                            {
                                if (Player.transform.position == bonusobj.transform.position)
                                {
                                    Debug.Log("Bonus you!");
                                    //返回菜单
                                    SceneManager.LoadScene("Menu");
                                    //可以插入Bonus动画
                                }
                            }
                        }
                    }
                }
            }
        }
        //doneCheck检测正常
        if (DoneCheck)
        {
            //寻找成立done的Prefab
            for (int i = 0; i < Rule.Perfabssize; i++)
            {
                //what is done
                if (Rule.Instance.Rules[i, Rule.Instance.OrdersDictionary["Done"]])
                {
                    //找到what
                    foreach (GameObject hideobj in PlayerMove.Instance.allObjects)
                    {
                        //以rock is done为例
                        if (hideobj.name.Replace("(Clone)", "") == Rule.Instance.Perfabs[i])
                        {
                            //rock消失
                            if (true)
                            {
                                //将Flag(Clone)放进待渲染池
                                hideobj.SetActive(false);
                                //重新计算Tag为object到allObjects
                                PlayerMove.Instance.allObjects = GameObject.FindGameObjectsWithTag("object");
                            }
                        }
                    }
                }
            }
        }
    }
}
