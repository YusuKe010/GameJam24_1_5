using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static int _point = 0;
    public static int Point => _point;

    public void AddPoint(int addpoint)
    {
        _point += addpoint;
    }
}
