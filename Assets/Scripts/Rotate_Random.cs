using UnityEngine;
using System.Collections;

public class Rotate_Random : MonoBehaviour 

{
    int random_num;
	void Start () 
	{
        random_num = Random.Range(75,150);
	}

	void Update () 
	{
		transform.Rotate (new Vector3 (0, 0, random_num) * Time.deltaTime);
	}
}