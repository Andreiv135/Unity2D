using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;
public class Menu : MonoBehaviour //PickStars
{
    public string point;
    GameObject Stars;
    string Point;
    public string Level;
    GameObject Pers;

    //Save
    public string filename; // Путь сохранения
    void Start()
    {
        Stars = GameObject.FindGameObjectWithTag("stars");
        Point = "555";
        // Point 
        Pers = GameObject.FindGameObjectWithTag("Player");
        if (filename == "") filename = "Data/Save/Position.raa";

    }
    private void FuncLoad()
    {


    }
    void FuncSave()
    {
        StreamWriter sw = new StreamWriter(filename); // Создаем файл
        sw.WriteLine(Point); // Пишем 
        Debug.Log("Save" + Point);
        sw.Close(); // Закрываем(сохраняем)

    }
    public void StartGame()
    {
        SceneManager.LoadScene(Level);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
        FuncSave();
    }
    public void Quit()
    {

        Application.Quit();
    }

}
/*
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PickStars : MonoBehaviour
{

    public int pointOut;
    GameObject Obj;
    string Out;
    void Start()
    {
        Obj = GameObject.FindWithTag("Point");

    }
    void OnTriggerEnter2D(Collider2D stars)
    {

        if (stars.gameObject.CompareTag("stars"))
        {
            pointOut++;
            Out = "Stars:" + pointOut + "/10";
            Obj.GetComponent<Text>().text = Out;
            Destroy(stars.gameObject);

        }
    }
}
*/
