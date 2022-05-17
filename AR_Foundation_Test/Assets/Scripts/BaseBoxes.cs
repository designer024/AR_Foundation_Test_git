using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBoxes : MonoBehaviour
{
    public int baseBox;

    public abstract void SetBox(int aNum);

    public abstract void SetBox1();

    protected internal void GetCheatNum()
    {
        baseBox = -999;
    }
}
