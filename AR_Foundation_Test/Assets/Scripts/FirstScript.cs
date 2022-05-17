using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : BaseBoxes
{
    private int mNum = 0;
    
    private void Start()
    {
        baseBox = 7;
        base.GetCheatNum();
        SetBox(baseBox);
        Debug.Log($"baseBox = {baseBox}, mNum = {mNum}");
    }

    private void Update()
    {
        
    }

    public override void SetBox(int aNum)
    {
        mNum = aNum;
    }

    public override void SetBox1()
    {
        Debug.Log($"baseBox = {baseBox}");
    }
}
