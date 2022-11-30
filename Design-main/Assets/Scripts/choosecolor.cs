using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choosecolor : MonoBehaviour
{
    Renderer renderer;
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gm = GameObject.FindGameObjectWithTag("Game Manager");
        gamemanger gmscript = gm.GetComponent<gamemanger>();
        mat = gmscript.mat;
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material = mat;
    }
}
