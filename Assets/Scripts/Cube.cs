using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : ShapeBase
{
	protected override string ShapeName => "Cube";

	protected override void DisplayText()
	{
		textField.text = $"{ShapeName} Maybe Clicked";
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
