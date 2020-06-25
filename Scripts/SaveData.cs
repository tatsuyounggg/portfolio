using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
GameObject[] Suns = new GameObject[3];
static public string[] Clears = new string[28];
void Awake(){
  for(int i = 0; i< 3; i++){
    Suns[i] = GameObject.Find("sun"+i);
    Debug.Log(Suns[i]);
  }
  string DataString = PlayerPrefs.GetString("CLEAR");
  if(DataString == ""){
    DataString = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
  }
    for(int i = 0; i< 28; i++){
      Clears[i] = DataString.Split(","[0])[i];
    }
}
void Start(){

}

public void UpdateSun(){
  for(int i = 0; i < 3 ;i++){
    GameObject sun = Suns[i];
    sun.SetActive(Clears[(GameDirector.multiplied * 3) -i] == "1");
  }
}
public void UpdateSunRandom(){
    GameObject sun = GameObject.Find("sun4");
    sun.SetActive(Clears[0] == "1");
}

static public void ClearStage(int _n){
  Clears[_n] = "1";
  Debug.Log(Clears[_n]);
  PlayerPrefs.SetString("CLEAR",string.Join(",",Clears));
  PlayerPrefs.Save();
}
}
