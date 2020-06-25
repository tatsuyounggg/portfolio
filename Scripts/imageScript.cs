using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageScript : MonoBehaviour
{
  [SerializeField]
  private RectTransform canvasRectTfm;
  [SerializeField]
  private Transform targetTfm;

  private RectTransform myRectTfm;
  private Text bubble;
  private Vector3 offset = new Vector3(-4.0f,0,0);

  void Start() {
      myRectTfm = GetComponent<RectTransform>();
      this.bubble = this.GetComponent<Text>();
      StartCoroutine("Bubble");
  }

  void Update() {
      if(targetTfm.position.x > 0.0f){
        offset = new Vector3(-3.5f,0f,0);
      }
      else if(targetTfm.position.x < 0.0f){
        offset = new Vector3(3.0f,0f,0);
      }
      Vector2 screenPos = RectTransformUtility.WorldToScreenPoint(Camera.main, targetTfm.position + offset);
      myRectTfm.position = screenPos;
  }
  IEnumerator Bubble(){
    this.bubble.text = "スタートボタン\nをおして〜";
    yield return new WaitForSeconds(2f);
    this.bubble.text = "→←で動くよ〜";
    yield return new WaitForSeconds(2f);
    this.bubble.text = "↑かスペースで\nジャンプ！";
    yield return new WaitForSeconds(2f);
    this.bubble.text = "どこまで高く\n行けるかな〜";
    yield return new WaitForSeconds(2f);
    this.bubble.text = "せいかいの\nくもにのろう！";
    yield return new WaitForSeconds(2f);
    this.bubble.text = "リセットで\nまたはじめよう";
    yield return new WaitForSeconds(2f);
    this.bubble.text = "きょうも\nがんばろ〜";
    yield return new WaitForSeconds(2f);
    this.bubble.text = "下でくもを\nおりられるよ〜";
    yield return new WaitForSeconds(2f);
    StartCoroutine("Bubble");
}
public void ResetComment(){
  this.bubble.text = "よーし！また\nがんばるぞ〜！";
}

}
