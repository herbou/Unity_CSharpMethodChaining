using UnityEngine;

public class Test : MonoBehaviour
{

	void Start ()
	{
		Shape.Create ("Default").Draw ();
		Shape.Create ("Rectangle").SetFillColor (Color.magenta).Draw ();
		Shape.Create ("Triangle").SetFillColor (Color.yellow).SetStrokeWidth (5f).Draw ();
	}
}

