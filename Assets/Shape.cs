using UnityEngine;

public class Shape : MonoBehaviour
{

	Vector2[] points;
	float strokeWidth = 0f;
	Color fillColor = Color.white;
	Color strokeColor = Color.black;

	public static Shape Create (string shapeName)
	{
		return new GameObject ("Shape-" + shapeName).AddComponent <Shape> ();
	}

	public Shape SetPoints (Vector2[] shapePoints)
	{
		this.points = shapePoints;
		return this;
	}

	public Shape SetStrokeWidth (float shapeStrokeWidth)
	{
		this.strokeWidth = shapeStrokeWidth;
		return this;
	}

	public Shape SetStrokeColor (Color shapeStrokeColor)
	{
		this.strokeColor = shapeStrokeColor;
		return this;
	}

	public Shape SetFillColor (Color shapeFillColor)
	{
		this.fillColor = shapeFillColor;
		return this;
	}

	public void Draw ()
	{
		string color = ColorUtility.ToHtmlStringRGBA (fillColor);
		Debug.Log ("<color=#" + color + ">Draw " + this.gameObject.name + "</color>");
	}

}
