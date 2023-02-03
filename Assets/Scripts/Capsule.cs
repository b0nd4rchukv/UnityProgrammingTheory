using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Capsule : ShapeBase
{
	protected override string ShapeName => "Capsule";

	protected override void DisplayText()
	{
		textField.text = $"{ShapeName} Clicked!!!";
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
