﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public float minX, maxX, minY, maxY;
    public Loc thisLoc;

    // Start is called before the first frame update
    void Start()
    {
        buildLoc();
    }

    public void buildLoc()
    {
        float curX, curY, scaleX, scaleY;
        curX = transform.position.x;
        curY = transform.position.y;
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
        minX = curX - (scaleX / 2);
        maxX = curX + (scaleX / 2);
        minY = curY - (scaleY / 2);
        maxY = curY + (scaleY / 2);
        thisLoc = new Loc(minX, maxX, minY, maxY);
        Debug.Log(string.Concat(transform.localPosition.x, " ", transform.localPosition.y));
        //Debug.Log(string.Concat("Loc Created: ", this.gameObject.name));
    }

    public bool collision(Loc other)
    {
        return thisLoc.collision(other);
    }
}
public class Loc
{
    public float minX, minY, maxX, maxY;
    public Loc(float a, float b, float c, float d)
    {
        minX = a; minY = c; maxX = b; maxY = d;
    }

    public bool collision(Loc other)
    {
        if (((other.minX > this.minX) && (other.minX < this.maxX)) ||
            ((other.maxX > this.minX) && (other.maxX < this.maxX)) ||
            ((other.minY > this.minY) && (other.minY < this.maxY)) ||
            ((other.maxY > this.minY) && (other.minY < this.maxY)))
        {
            return true;
        }
        else return false;
    }

    public bool click(float x, float y)
    {
        if ((minX <= x && maxX >= x) && (minY <= y && maxY >= y)) return true;
        else return false;
    }

    public string ToString => string.Concat("minX:", minX, " maxX: ", maxX, " minY: ", minY, " maxY: ", maxY);
}
