using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonMatExample : MonoBehaviour
{
    Hex.Board<int> matrix = new Hex.Board<int>(5, 5, 1f);
    // Start is called before the first frame update
    void Start() {
        matrix.Foreach((Hex.Vector index, ref int content) => {
            GameObject o = new GameObject();
            o.transform.position = matrix.Position(index);
            o.name = index.ToString();
            o.transform.parent = transform;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
