using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    int point = 0;
    private GameObject PointText;

    void Start()
    {
        point = 0;
        this.PointText = GameObject.Find("PointText");
        Point();
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "LargeCloud") ;
        {
            point += 10;
        }
        if (collision.gameObject.tag == "SmallCloudPrefab") ;
        {
            point += 5;
        }
        if (collision.gameObject.tag == "LargeStar") ;
        {
            point += 10;
        }
        if (collision.gameObject.tag == "SmallStarPrefab") ;
        {
            point += 5;
        }
        Point();
    }

    void Point()
    {
        this.PointText.GetComponent<Text>().text = "“¾“_"+point.ToString();
    }
}
