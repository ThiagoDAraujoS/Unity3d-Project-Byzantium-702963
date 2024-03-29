﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonMatExample : MonoBehaviour
{
    public GameObject hexagonCell;
    Hex.Square<int> matrix = new Hex.Square<int>(15, 16);
    // Start is called before the first frame update
    void Start() {
        matrix.Foreach((Hex.Vector index, ref int content) => {
            GameObject o = Instantiate(hexagonCell,index,transform.rotation,transform);
            o.name = index.ToString();
        });
    }

    public Dice.Group<Dice.Die> dice;
    // Update is called once per frame
    void Update()
    {
        
    }
}
