using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float angleY;

	void Update ()
	{
	    this.transform.eulerAngles += new Vector3(0, angleY, 0);
	}
}
