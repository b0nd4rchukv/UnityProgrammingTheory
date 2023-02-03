using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class ShapeBase : MonoBehaviour
{
	public TextMeshProUGUI textField;

	protected abstract string ShapeName { get; }

    protected abstract void DisplayText();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnMouseUp()
	{
        DisplayText();
	}
}
