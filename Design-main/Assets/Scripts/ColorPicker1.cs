using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker1 : MonoBehaviour
{
    public Material[] Bodycolormat;
    public Material currmat;
    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = this.GetComponent<Renderer>(); // this one will be in the new script
        // you will create a new object called gamemanager, and save the variable currmat in it
        // atfer in the next scene and the new object, you will set render.material = GameMAnager.currmat;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //the blue color 
    public void Color1()
    {
        renderer.material = Bodycolormat[0];
        currmat = renderer.material;
    }

    //the red color 
    public void Color2()
    {
        renderer.material = Bodycolormat[1];
        currmat = renderer.material;
    }

    //the Yellow color 
    public void Color3()
    {
        renderer.material = Bodycolormat[2];
        currmat = renderer.material;
    }
     public void Color4()
    {
        renderer.material = Bodycolormat[3];
        currmat = renderer.material;
    }
     public void Color5()
    {
        renderer.material = Bodycolormat[4];
        currmat = renderer.material;
    }
     public void Color6()
    {
        renderer.material = Bodycolormat[5];
        currmat = renderer.material;
    }
     public void Color7()
    {
        renderer.material = Bodycolormat[6];
        currmat = renderer.material;
    }
     public void Color8()
    {
        renderer.material = Bodycolormat[7];
        currmat = renderer.material;
    }
     public void Color9()
    {
        renderer.material = Bodycolormat[8];
        currmat = renderer.material;
    }
     public void Color10()
    {
        renderer.material = Bodycolormat[9];
        currmat = renderer.material;
    }
     public void Color11()
    {
        renderer.material = Bodycolormat[10];
        currmat = renderer.material;
    }
     public void Color12()
    {
        renderer.material = Bodycolormat[11];
        currmat = renderer.material;
    }

}
