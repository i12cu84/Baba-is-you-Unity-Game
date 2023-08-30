using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//地图内容设计
//枚举
public enum ElementTypes
{
    //carrier载具
    //空
    Empty=0,
    //baba巴巴
    Baba, 
    //wall墙
    Wall, 
    //falg旗
    Flag, 
    //box箱子
    Box, 
    //key钥匙
    Key,
    //rock岩石
    Rock, 
    //water水
    Water,
    //skull骷髅头
    Skull,
    //door门
    Door,
    //belt滑动梯子
    Belt, 


    //special特殊
    //text载具赋词属性
    TextString, 
    //empty空
    EmptyString, 
    //group群组
    GroupString, 
    //level关卡所有物体
    LevelString,
    //all所有载具
    AllString, 
    /*
        //lava岩浆
        //grass草丛
        //jelly水母
        //star海星
        //crab螃蟹
        //love爱心
        //keke可可
        //algae水藻
        //pillar柱子
        //hedge树篱
        //rose玫瑰
        //violet紫罗兰
        //cog齿轮
        //robot机器人
        //pipe管子
        //bog沼泽
        //ice冰
        //tree树
        //fungus真菌
        //fence栅栏
        //bug昆虫
        //reed芦苇
        //cloud云朵
        //rocket
        //moon月亮
        //dust尘土
        //UFO外星飞船
        //hand手
        //fruit水果
        //cilff悬崖
        //bat蝙蝠
        //fire火
        //tile瓦片
        //bird鸟
        //sun太阳
        //rubble碎砖
        //orb球体
        //cursor进入关卡的光标
    */


    //载具名字
    //baba巴巴
    BabaString,
    //wall墙
    WallString, 
    //falg旗
    FlagString,
    //box箱子
    BoxString,  
    //key钥匙
    KeyString,
    //rock岩石
    RockString,
    //water水
    WaterString,
    //skull骷髅头
    SkullString, 
    //door门
    DoorString, 
    //belt滑动梯子
    BeltString, 

    //feeling(?)
    FeelingString,
    //group2(?)
    Group2String,
    //group3(?)
    Group3String,
    //idle(?)
    IdleString,
    //mimic(?)
    MimicString,
    //often(?)
    OftenString, 
    //powered(?)
    PoweredString, 
    //seldom(?)
    SeldomString,
    //without(?)
    WithoutString,
    /*
        //lava岩浆
        //grass草丛
        //jelly水母
        //star海星
        //crab螃蟹
        //love爱心
        //keke可可
        //algae水藻
        //pillar柱子
        //hedge树篱
        //rose玫瑰
        //violet紫罗兰
        //cog齿轮
        //robot机器人
        //pipe管子
        //bog沼泽
        //ice冰
        //tree树
        //fungus真菌
        //fence栅栏
        //bug昆虫
        //reed芦苇
        //cloud云朵
        //rocket
        //moon月亮
        //dust尘土
        //UFO外星飞船
        //hand手
        //fruit水果
        //cilff悬崖
        //bat蝙蝠
        //fire火
        //tile瓦片
        //bird鸟
        //sun太阳
        //rubble碎砖
        //orb球体
        //cursor进入关卡的光标
    */


    //put赋词
    //is 是/能够
    Is,
    //not 非 不是/不能
    Not, 
    //has 变/含 摧毁/变成
    Has, 
    //and 和 和/与
    And,
    //on 在...上方
    On,
    //make 出现/做成
    Make, 
    //facing前一格
    Facing, 
    //lonely只有
    Lonely,
    //near周围
    Near, 
    //fear上下左右
    Fear, 

    //follow 跟着(?)
    Follow, 
    //eat 吃(?)
    Eat,


    //属性
    //you 操控移动
    You, 
    //win 游戏结束
    Win, 
    //stop 禁止穿过
    Stop, 
    //push 推动 
    Push, 
    //sink 重叠摧毁
    Sink,
    //weak 被碰碎
    Weak,
    //defeat 失败 游戏结束
    Defeat,
    //hot 滚烫 
    Hot,
    //melt 软化
    Melt, 
    //tele 传送
    Tele,
    //float 漂浮 在空中
    Float,
    //open 开启 能开启shut
    Open, 
    //shut 被开启 能被open开启
    Shut,
    //move 移动 随player移动
    Move,
    //pull 拉走
    Pull,
    //shift 驱动
    Shift,
    //up 上
    Up, 
    //right 右
    Right,
    //swap 互换
    Swap, 
    //end 结束
    //fall 下落
    Fall, 
    //down 下
    Down, 
    //more 更多
    More, 
    //word 单词
    Word, 
    //hide 隐藏
    Hide,
    //bonus 奖励
    Bonus,
    //done 消失
    Done,

    //best (?)
    Best, 
    //left 左
    Left, 
    //sad 哭(?)
    Sad, 
    //safe 保护(?)
    Safe,
    //sleep 睡(?)
    Sleep,
    //wonder 精彩(?)
    Wonder,
    //auto
    Auto,
    //blue
    Blue, 
    //broken
    Broken,
    //chill
    Chill,
    //falldown
    Falldown,
    //fallleft
    Fallleft, 
    //fallright
    Fallright, 
    //fallup
    Fallup, 
    //nudgedown
    Nudgedown,
    //nudgeleft
    Nudgeleft,
    //nudgeright
    Nudgeright,
    //nudgeup
    Nudgeup, 
    //party
    Party, 
    //pet
    Pet, 
    //phamtom
    Phamtom, 
    //pink
    Pink, 
    //power
    Power,
    //red
    Red, 
    //reverse
    Reverse, 
    //rosy
    Rosy,
    //still
    Still, 
    //turnleft
    Turnleft, 
    //turnright
    Turnright, 
    //you2
    You2

}

//关卡创造设定
[CreateAssetMenu()]
[System.Serializable]
public class LevelCreator : ScriptableObject
{
    [SerializeField]
    //关卡level中列表的枚举方式
    public List<ElementTypes> level = new List<ElementTypes>();
}
