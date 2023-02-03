using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : ShapeBase
{
	protected override string ShapeName => "Sphere";

	protected override void DisplayText()
	{
        textField.text = $"{ShapeName} Clicked";
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
