using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNActiveGO : MonoBehaviour
{
    public GameObject objToModifiy;
    public Vector3 Min;
    public Vector3 Max;
    [Range (0f, 0.1f)]
    public float speed;
    private bool Front=false;
    private bool Back=false;
    private bool Left=false;
    private bool Right=false;
    private bool Up=false;
    private bool Down=false;
    private bool RotLeft=false;
    private bool RotRight=false;
    private void move(Vector3 mov){
        objToModifiy.transform.position =  Clamp(objToModifiy.transform.position + mov);
    }
    private void rotate(float x, float y, float z){
        objToModifiy.transform.Rotate(x,y,z);
    }

    public void moveFront(bool setbool){
        Front = setbool;
    }
    public void moveBack(bool setbool){
        Back = setbool;
    }
    public void moveLeft(bool setbool){
        Left = setbool;
    }
    public void moveRight(bool setbool){
        Right = setbool;
    }
    public void moveUp(bool setbool){
        Up = setbool;
    }
    public void moveDown(bool setbool){
        Down = setbool;
    }
    public void RotateLeft(bool setbool){
        RotLeft = setbool;

    }
    public void RotateRight(bool setbool){
        RotRight = setbool;
    }
    private void FixedUpdate() {
        if(Front){
            move(new Vector3(0,0,speed));
        }
        if(Back){
            move(new Vector3(0,0,-speed));
        }
        if(Left){
            move(new Vector3(-speed,0,0));
        }
        if(Right){
            move(new Vector3(speed,0,0));
        }
        if(Up){
            move(new Vector3(0,speed,0));
        }
        if(Down){
            move(new Vector3(0,-speed,0));
        }
        if(RotLeft){
            rotate(0,speed,0);
        }
        if(RotRight){
            rotate(0,-speed,0);
        }
    }
    private Vector3 Clamp(Vector3 vec){
        vec.x = Mathf.Clamp(vec.x, Min.x, Max.x);
        vec.y = Mathf.Clamp(vec.y, Min.y, Max.y);
        vec.z = Mathf.Clamp(vec.z, Min.z, Max.z);
        return vec;
    }
    public void SetGO(GameObject toGO){
        objToModifiy = toGO;
    }
}
