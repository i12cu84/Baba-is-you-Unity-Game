using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
//地图UI设计脚本
//[CustomEditor(typeof(LevelCreator))]//(因为打包时会报错 遂注释
[ExecuteInEditMode]
public class LevelCreatorInspector //: Editor//(因为打包时会报错 遂注释
{
    public Dictionary<ElementTypes, Texture> textureHolder = new Dictionary<ElementTypes, Texture>();

    ////加载相应元素的贴图 (因为打包时会报错 遂注释
    //private void OnEnable()
    //{
    //    //carrier载具
    //    //空
    //    textureHolder.Add(ElementTypes.Empty, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrier/empty.png"));
    //    //baba巴巴
    //    textureHolder.Add(ElementTypes.Baba, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrier/baba.png"));
    //    //wall墙
    //    textureHolder.Add(ElementTypes.Wall, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrier/wall.png"));
    //    //falg旗
    //    textureHolder.Add(ElementTypes.Flag, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrier/flag.png"));
    //    //box箱子
    //    textureHolder.Add(ElementTypes.Box, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrier/box.png"));
    //    //key钥匙
    //    textureHolder.Add(ElementTypes.Key, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrier/key.png"));
    //    //rock岩石
    //    textureHolder.Add(ElementTypes.Rock, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrier/rock.png"));
    //    //water水
    //    textureHolder.Add(ElementTypes.Water, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrier/water.png"));
    //    //skull骷髅头
    //    textureHolder.Add(ElementTypes.Skull, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrier/skull.png"));
    //    //door门
    //    textureHolder.Add(ElementTypes.Door, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrier/door.png"));
    //    //belt滑动梯子
    //    textureHolder.Add(ElementTypes.Belt, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrier/belt.png"));


    //    //special特殊
    //    //text载具赋词属性
    //    textureHolder.Add(ElementTypes.TextString, (Texture)EditorGUIUtility.Load("Assets/Sprites/special/text.png"));
    //    //empty空
    //    textureHolder.Add(ElementTypes.EmptyString, (Texture)EditorGUIUtility.Load("Assets/Sprites/special/empty.png"));
    //    //group群组
    //    textureHolder.Add(ElementTypes.GroupString, (Texture)EditorGUIUtility.Load("Assets/Sprites/special/group.png"));
    //    //level关卡所有物体
    //    textureHolder.Add(ElementTypes.LevelString, (Texture)EditorGUIUtility.Load("Assets/Sprites/special/level.png"));
    //    //all所有载具
    //    textureHolder.Add(ElementTypes.AllString, (Texture)EditorGUIUtility.Load("Assets/Sprites/special/all.png"));


    //    //载具名字
    //    //baba巴巴
    //    textureHolder.Add(ElementTypes.BabaString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/babastring.png"));
    //    //wall墙
    //    textureHolder.Add(ElementTypes.WallString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/wallstring.png"));
    //    //falg旗
    //    textureHolder.Add(ElementTypes.FlagString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/flagstring.png"));
    //    //box箱子
    //    textureHolder.Add(ElementTypes.BoxString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/boxstring.png"));
    //    //key钥匙
    //    textureHolder.Add(ElementTypes.KeyString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/keystring.png"));
    //    //rock岩石
    //    textureHolder.Add(ElementTypes.RockString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/rockstring.png"));
    //    //water水
    //    textureHolder.Add(ElementTypes.WaterString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/waterstring.png"));
    //    //skull骷髅头
    //    textureHolder.Add(ElementTypes.SkullString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/skullstring.png"));
    //    //door门
    //    textureHolder.Add(ElementTypes.DoorString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/doorstring.png"));
    //    //belt滑动梯子
    //    textureHolder.Add(ElementTypes.BeltString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/beltstring.png"));
    //    //feeling(?)
    //    textureHolder.Add(ElementTypes.FeelingString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/feelingstring.png"));
    //    //group2(?)
    //    textureHolder.Add(ElementTypes.Group2String, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/group2string.png"));
    //    //group3(?)
    //    textureHolder.Add(ElementTypes.Group3String, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/group3string.png"));
    //    //idle(?)
    //    textureHolder.Add(ElementTypes.IdleString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/idlestring.png"));
    //    //mimic(?)
    //    textureHolder.Add(ElementTypes.MimicString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/mimicstring.png"));
    //    //often(?)
    //    textureHolder.Add(ElementTypes.OftenString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/oftenstring.png"));
    //    //powered(?)
    //    textureHolder.Add(ElementTypes.PoweredString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/poweredstring.png"));
    //    //seldom(?)
    //    textureHolder.Add(ElementTypes.SeldomString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/seldomString.png"));
    //    //without(?)
    //    textureHolder.Add(ElementTypes.WithoutString, (Texture)EditorGUIUtility.Load("Assets/Sprites/carrierstring/withoutstring.png"));


    //    //put赋词
    //    //is 是/能够
    //    textureHolder.Add(ElementTypes.Is, (Texture)EditorGUIUtility.Load("Assets/Sprites/put/is.png"));
    //    //not 非 不是/不能
    //    textureHolder.Add(ElementTypes.Not, (Texture)EditorGUIUtility.Load("Assets/Sprites/put/not.png"));
    //    //has 变/含 摧毁/变成
    //    textureHolder.Add(ElementTypes.Has, (Texture)EditorGUIUtility.Load("Assets/Sprites/put/has.png"));
    //    //and 和 和/与
    //    textureHolder.Add(ElementTypes.And, (Texture)EditorGUIUtility.Load("Assets/Sprites/put/and.png"));
    //    //on 在...上方
    //    textureHolder.Add(ElementTypes.On, (Texture)EditorGUIUtility.Load("Assets/Sprites/put/on.png"));
    //    //make 出现/做成
    //    textureHolder.Add(ElementTypes.Make, (Texture)EditorGUIUtility.Load("Assets/Sprites/put/make.png"));
    //    //facing前一格
    //    textureHolder.Add(ElementTypes.Facing, (Texture)EditorGUIUtility.Load("Assets/Sprites/put/facing.png"));
    //    //lonely只有
    //    textureHolder.Add(ElementTypes.Lonely, (Texture)EditorGUIUtility.Load("Assets/Sprites/put/lonely.png"));
    //    //near周围
    //    textureHolder.Add(ElementTypes.Near, (Texture)EditorGUIUtility.Load("Assets/Sprites/put/near.png"));
    //    //fear上下左右
    //    textureHolder.Add(ElementTypes.Fear, (Texture)EditorGUIUtility.Load("Assets/Sprites/put/fear.png"));
    //    //follow 跟着(?)
    //    textureHolder.Add(ElementTypes.Follow, (Texture)EditorGUIUtility.Load("Assets/Sprites/put/follow.png"));
    //    //eat 吃(?)
    //    textureHolder.Add(ElementTypes.Eat, (Texture)EditorGUIUtility.Load("Assets/Sprites/put/eat.png"));


    //    //属性
    //    //you 操控移动
    //    textureHolder.Add(ElementTypes.You, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/you.png"));
    //    //win 游戏结束
    //    textureHolder.Add(ElementTypes.Win, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/win.png"));
    //    //stop 禁止穿过
    //    textureHolder.Add(ElementTypes.Stop, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/stop.png"));
    //    //push 推动 
    //    textureHolder.Add(ElementTypes.Push, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/push.png"));
    //    //sink 重叠摧毁
    //    textureHolder.Add(ElementTypes.Sink, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/sink.png"));
    //    //weak 被碰碎
    //    textureHolder.Add(ElementTypes.Weak, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/weak.png"));
    //    //defeat 失败 游戏结束
    //    textureHolder.Add(ElementTypes.Defeat, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/defeat.png"));
    //    //hot 滚烫 
    //    textureHolder.Add(ElementTypes.Hot, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/hot.png"));
    //    //melt 软化
    //    textureHolder.Add(ElementTypes.Melt, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/melt.png"));
    //    //tele 传送
    //    textureHolder.Add(ElementTypes.Tele, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/tele.png"));
    //    //float 漂浮 在空中
    //    textureHolder.Add(ElementTypes.Float, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/float.png"));
    //    //open 开启 能开启shut
    //    textureHolder.Add(ElementTypes.Open, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/open.png"));
    //    //shut 被开启 能被open开启
    //    textureHolder.Add(ElementTypes.Shut, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/shut.png"));
    //    //move 移动 随player移动
    //    textureHolder.Add(ElementTypes.Move, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/move.png"));
    //    //pull 拉走
    //    textureHolder.Add(ElementTypes.Pull, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/pull.png"));
    //    //shift 驱动
    //    textureHolder.Add(ElementTypes.Shift, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/shift.png"));
    //    //up 上
    //    textureHolder.Add(ElementTypes.Up, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/up.png"));
    //    //right 右
    //    textureHolder.Add(ElementTypes.Right, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/right.png"));
    //    //swap 互换
    //    textureHolder.Add(ElementTypes.Swap, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/swap.png"));
    //    //end 结束
    //    textureHolder.Add(ElementTypes.End, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/end.png"));
    //    //fall 下落
    //    textureHolder.Add(ElementTypes.Fall, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/fall.png"));
    //    //down 下
    //    textureHolder.Add(ElementTypes.Down, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/down.png"));
    //    //more 更多
    //    textureHolder.Add(ElementTypes.More, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/more.png"));
    //    //word 单词
    //    textureHolder.Add(ElementTypes.Word, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/word.png"));
    //    //hide 隐藏
    //    textureHolder.Add(ElementTypes.Hide, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/hide.png"));
    //    //bonus 奖励
    //    textureHolder.Add(ElementTypes.Bonus, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/bonus.png"));
    //    //done 消失
    //    textureHolder.Add(ElementTypes.Done, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/done.png"));
    //    //best (?)
    //    textureHolder.Add(ElementTypes.Best, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/best.png"));
    //    //left 左
    //    textureHolder.Add(ElementTypes.Left, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/left.png"));
    //    //sad 哭(?)
    //    textureHolder.Add(ElementTypes.Sad, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/sad.png"));
    //    //safe 保护(?)
    //    textureHolder.Add(ElementTypes.Safe, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/safe.png"));
    //    //sleep 睡(?)
    //    textureHolder.Add(ElementTypes.Sleep, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/sleep.png"));
    //    //wonder 精彩(?)
    //    textureHolder.Add(ElementTypes.Wonder, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/wonder.png"));
    //    //auto
    //    textureHolder.Add(ElementTypes.Auto, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/auto.png"));
    //    //blue
    //    textureHolder.Add(ElementTypes.Blue, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/blue.png"));
    //    //broken
    //    textureHolder.Add(ElementTypes.Broken, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/broken.png"));
    //    //chill
    //    textureHolder.Add(ElementTypes.Chill, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/chill.png"));
    //    //falldown
    //    textureHolder.Add(ElementTypes.Falldown, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/falldown.png"));
    //    //fallleft
    //    textureHolder.Add(ElementTypes.Fallleft, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/fallleft.png"));
    //    //fallright
    //    textureHolder.Add(ElementTypes.Fallright, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/fallright.png"));
    //    //fallup
    //    textureHolder.Add(ElementTypes.Fallup, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/fallup.png"));
    //    //nudgedown
    //    textureHolder.Add(ElementTypes.Nudgedown, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/nudgedown.png"));
    //    //nudgeleft
    //    textureHolder.Add(ElementTypes.Nudgeleft, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/nudgeleft.png"));
    //    //nudgeright
    //    textureHolder.Add(ElementTypes.Nudgeright, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/nudgeright.png"));
    //    //nudgeup
    //    textureHolder.Add(ElementTypes.Nudgeup, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/nudgeup.png"));
    //    //party
    //    textureHolder.Add(ElementTypes.Party, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/party.png"));
    //    //pet
    //    textureHolder.Add(ElementTypes.Pet, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/pet.png"));
    //    //phamtom
    //    textureHolder.Add(ElementTypes.Phamtom, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/Phamtom.png"));
    //    //pink
    //    textureHolder.Add(ElementTypes.Pink, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/pink.png"));
    //    //power
    //    textureHolder.Add(ElementTypes.Power, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/power.png"));
    //    //red
    //    textureHolder.Add(ElementTypes.Red, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/red.png"));
    //    //reverse
    //    textureHolder.Add(ElementTypes.Reverse, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/reverse.png"));
    //    //rosy
    //    textureHolder.Add(ElementTypes.Rosy, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/rosy.png"));
    //    //still
    //    textureHolder.Add(ElementTypes.Still, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/still.png"));
    //    //turnleft
    //    textureHolder.Add(ElementTypes.Turnleft, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/turnleft.png"));
    //    //turnright
    //    textureHolder.Add(ElementTypes.Turnright, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/turnright.png"));
    //    //you2
    //    textureHolder.Add(ElementTypes.You2, (Texture)EditorGUIUtility.Load("Assets/Sprites/order/you2.png"));

    //}

    //空场地元素
    public ElementTypes currentSelected = ElementTypes.Empty;

    ////默认组件编辑方式 //(因为打包时会报错 遂注释
    //public override void OnInspectorGUI()
    //{
    //    //配置UI
    //    base.OnInspectorGUI();
    //    //标签
    //    GUILayout.Label("Current Selected : " + currentSelected.ToString());
    //    //关卡实例化
    //    LevelCreator levelCreator = (LevelCreator)target;
    //    //开根计算行列
    //    int rows = (int)Mathf.Sqrt(levelCreator.level.Count);
    //    //展现关卡的纵配置
    //    GUILayout.BeginVertical();
    //    //循环配置
    //    for (int r = 0; r < rows; r++)
    //    {
    //        //展现关卡的横配置
    //        GUILayout.BeginHorizontal();
    //        //配置每个位置的预制体
    //        for (int c = 0; c < rows; c++)
    //        {
    //            //每行每列展示25像素的方块
    //            if (GUILayout.Button(textureHolder[levelCreator.level[r * rows + c]], GUILayout.Width(25), GUILayout.Height(25)))
    //            {
    //                //展示具体物品
    //                levelCreator.level[r * rows + c] = currentSelected;
    //            }
    //        }
    //        //结束绘制
    //        GUILayout.EndHorizontal();
    //    }
    //    //绘制地图
    //    GUILayout.EndVertical();
    //    GUILayout.Space(20);
    //    GUILayout.BeginVertical();
    //    GUILayout.BeginHorizontal();
    //    int count = 0;
    //    foreach (KeyValuePair<ElementTypes, Texture> e in textureHolder)
    //    {
    //        count++;
    //        if (GUILayout.Button(e.Value, GUILayout.Width(50), GUILayout.Height(50)))
    //        {
    //            currentSelected = e.Key;
    //        }
    //        if (count % 8 == 0)
    //        {
    //            GUILayout.EndHorizontal();
    //            GUILayout.BeginHorizontal();
    //        }
    //    }
    //    GUILayout.EndHorizontal();
    //    GUILayout.EndVertical();
    //    GUIUtility.ExitGUI();
    //}
}