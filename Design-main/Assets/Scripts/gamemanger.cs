using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanger : MonoBehaviour
{
    public Material mat;
    public GameObject obj;
     ColorPicker1 colr;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("Color");
        colr = obj.GetComponent<ColorPicker1>();
       
    }

    // Update is called once per frame
    void Update()
    {
        mat = colr.currmat;
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
