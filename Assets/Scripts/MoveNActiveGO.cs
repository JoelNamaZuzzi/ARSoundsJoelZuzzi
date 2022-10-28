using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNActiveGO : MonoBehaviour
{
    public GameObject objToModifiy;
    public Vector3 Min;
    public Vector3 Max;

    public void move(Vector3 mov){
        objToModifiy.transform.position =  Clamp(objToModifiy.transform.position + mov);
    }

    public void moveFront(){
        move(new Vector3(0,0,-0.1f));
    }
    public void moveBack(){
        move(new Vector3(0,0,0.1f));
    }
    public void moveLeft(){
        move(new Vector3(0.1f,0,0));
    }
    public void moveRight(){
        move(new Vector3(-0.1f,0,0));
    }
    public void moveUp(){
        move(new Vector3(0,0.1f,0));
    }
    public void moveDown(){
        move(new Vector3(0,-0.1f,0));
    }

    private Vector3 Clamp(Vector3 vec){
        vec.x = Mathf.Clamp(vec.x, Min.x, Max.x);
        vec.y = Mathf.Clamp(vec.y, Min.y, Max.y);
        vec.z = Mathf.Clamp(vec.z, Min.z, Max.z);
        return vec;
    }
}
