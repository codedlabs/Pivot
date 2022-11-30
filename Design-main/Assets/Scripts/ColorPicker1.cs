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
    public void Bluecolor()
    {
        renderer.material = Bodycolormat[0];
        currmat = renderer.material;
    }

    //the red color 
    public void Redcolor()
    {
        renderer.material = Bodycolormat[1];
        currmat = renderer.material;
    }

    //the Yellow color 
    public void Yellowcolor()
    {
        renderer.material = Bodycolormat[2];
        currmat = renderer.material;
    }

}
