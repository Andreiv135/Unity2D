using UnityEngine;
using System.Collections;
using System.IO;

public class Load : MonoBehaviour {
	
	public float x;
	public float y;
	public float z;

	// Use this for initialization
	void Start () {
        StreamReader streamReader = new StreamReader("Data/Save/Position.raa"); // Открываем файл
		if(streamReader != null) {
          while (!streamReader.EndOfStream) // Читаем строки пока они не закончатся
          {
				x = System.Convert.ToSingle(streamReader.ReadLine());
				y = System.Convert.ToSingle(streamReader.ReadLine());
				z = System.Convert.ToSingle(streamReader.ReadLine());
          }
			if(x != 0 && y != 0 && z != 0) 
				transform.position = new Vector3(x, y, z);
		}
		
	}
}
