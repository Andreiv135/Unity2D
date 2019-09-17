using UnityEngine;
using System.Collections;
using System.IO; // Используем библиотеку ввода вывода

public class Save : MonoBehaviour {
   
   public string filename; // Путь сохранения
   
   
   void Start () // Данный скрипт выполняется при инициализации объекта.
   {
      if ( filename == "" ) filename = "Data/Save/Position.raa"; 
      // Если название файла не указанно то пишем по умолчанию
      
   }

   void OnTriggerEnter2D(Collider2D pes) 
   {
       if (pes.CompareTag("Player")) { 

       Debug.Log("Yt ghjikj");
         StreamWriter sw = new StreamWriter(filename); // Создаем файл
            sw.WriteLine(transform.position.x); // Пишем координаты
			sw.WriteLine(transform.position.y);
			sw.WriteLine(transform.position.z);
			Debug.Log("Save" + transform.position);
            sw.Close(); // Закрываем(сохраняем)
   }
   }
}