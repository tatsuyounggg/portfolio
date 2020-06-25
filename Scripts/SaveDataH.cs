using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataH : MonoBehaviour
{
GameObject[] Moons = new GameObject[3];
static public string[] Clears = new string[31];
void Awake(){
  for(int i = 0; i< 3; i++){
    Moons[i] = GameObject.Find("moon"+i);
    Debug.Log(Moons[i]);
  }
  string DataString = PlayerPrefs.GetString("CLEARH");
  if(DataString == ""){
    DataString = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
  }
    for(int i = 0; i< 31; i++){
      Clears[i] = DataString.Split(","[0])[i];
    }

}
void Start(){

}

public void UpdateMoon(){
  for(int i = 0; i < 3 ;i++){
    GameObject moon = Moons[i];
    moon.SetActive(Clears[((GameDirector.multiplied -9) * 3) -i] == "1");
  }
}
public void UpdateMoonRandom(){
    GameObject moon = GameObject.Find("moon4");
    moon.SetActive(Clears[0] == "1");
    // PlayerPrefs.SetString("CLEAR",string.Join(",",Clears));
    // PlayerPrefs.Save();
}

static public void ClearStage(int _n){
  Clears[_n] = "1";
  Debug.Log(Clears[_n]);
  PlayerPrefs.SetString("CLEARH",string.Join(",",Clears));
  PlayerPrefs.Save();
  // UpdateMoon();
}
}
