using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class DragTarget : MonoBehaviour
{
    Vector3 _pos;
    PointManager _pointManager;
    [SerializeField] int _addPoint;

    private void Start()
    {
        _pointManager = FindObjectOfType<PointManager>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MouseDown();
        }

        if (Input.GetMouseButtonUp(0))
        {
            MouseUp();
        }
    }

    private void MouseDown()
    {
        _pos = this.transform.position;
        this.transform.position = Input.mousePosition;
    }

    private void MouseUp()
    {
        this.transform.position = _pos;
        if(this.transform.position.x >= 100 || -100 >= this.transform.position.x)
        {
            _pointManager.AddPoint(_addPoint);
        }
    }
}
