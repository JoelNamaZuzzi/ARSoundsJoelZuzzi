using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveNActiveGO : MonoBehaviour
{
    public GameObject objToModifiy;
    public Vector3 Min;
    public Vector3 Max;
    [Range (0f, 1f)]
    public float speed;
    [Range (1f, 10f)]
    public float RotSpeed;
    private bool Front=false;
    private bool Back=false;
    private bool Left=false;
    private bool Right=false;
    private bool Up=false;
    private bool Down=false;
    private bool RotLeft=false;
    private bool RotRight=false;
    [SerializeField] private TMP_Text MoveTXT;
    [SerializeField] private TMP_Text RotTXT;
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
            rotate(0,RotSpeed,0);
        }
        if(RotRight){
            rotate(0,-RotSpeed,0);
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

    public void SetMoveSpeed(float value)
    {
        speed = value;
        MoveTXT.text = value.ToString("F2");
    }
    public void SetRotSpeed(float spd)
    {
        RotSpeed = spd;
        RotTXT.text = spd.ToString("F0");
    }
    
    public void ToggleGO()
    {
        objToModifiy.SetActive(!objToModifiy.activeSelf);
    }
}
