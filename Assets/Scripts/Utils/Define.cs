using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{

    
    public enum Sounds
    {
        BGM,
        SFX,
        MaxCount
    }
    public enum BGM
    {

        MaxCount
    }
    public enum SFX
    {
        MaxCount
    }
    public enum State
    {
        MaxCount
    }

    public enum Tag
    {
        MaxCount
    }

    /// <summary>
    /// UI Event 종류 지정
    /// </summary>
    public enum UIEvent
    {
        Click,
        Drag,
        DragEnd,
    }
    public enum Face
    {
        default1,
        default2,
        smile1,
        smile2,
        blank1,
        blank2,
        bad1,
        bad2,
        good1,
        good2,
    }
    public enum Scenes
    {
        Title,
        Game,
    }


}