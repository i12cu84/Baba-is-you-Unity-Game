using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//地图绘制
public class MapMaker : MonoBehaviour
{
    //地图元素预制体
    public List<GameObject> Prefabs;
    //具体关卡的实例化内容(每一格)
    public LevelCreator levelCreator;
    //父类地图
    public GameObject parentMap;

    //地图临时数据变量
    private GameObject createObject;

    void Awake()
    {
        //左上角坐标x
        float currentX = -9.5f;
        //左上角坐标y
        float currentY = 8.5f;
        //布置地图
        foreach (ElementTypes ElementType in levelCreator.level)
        {
            //地图存有空元素
            if (ElementType.ToString() == "Empty")
            {
                //下一格
                currentX += 1;
                //这一行若非越界
                if (currentX > 9.5f)
                {
                    //第一列
                    currentX = -9.5f;
                    //下一行
                    currentY -= 1;
                }
                continue;//布置下一行
            }
            //
            foreach (GameObject ob in Prefabs)
            {
                //如果与布置元素名字相同 则 布置上元素
                if (ElementType.ToString() == ob.name)
                {
                    //布置相应元素
                    createObject = Instantiate(ob, new Vector3(currentX, currentY, 0), Quaternion.identity);
                    createObject.transform.parent = parentMap.transform;
                }
            }
            //移到下一格
            currentX += 1;
            //如果在这一行的最后一个 
            if (currentX > 9.5f)
            {
                //移到下一行的第一个
                currentX = -9.5f;
                //平移下一行
                currentY -= 1;
            }
        }
    }
}
