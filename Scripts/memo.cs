// countTime += Time.deltaTime;
// this.question.GetComponent<Text>().text = countTime.ToString("F2");
//
// // ランダムを生み出す
// int seed = Environment.TickCount;
//
//         for (int i = 0; i < 50; i++)
//         {
//             //シート値を変えながらRandomクラスのインスタンスを作成する
//             Random rnd = new Random(seed++);
//
//             for (int j = 0; j < 10; j++)
//             {
//                 Console.Write("{0} ", rnd.Next(10, 100));
//             }
//         }//for(i)文の終わり

// //生成したObjectを持っておくためのList
//     List<GameObject> list_toggle_ = new List<GameObject>();
//
//         //インスタンスを作成
//         GameObject toggle_instance = Instantiate(toggle_prefab_) as GameObject;
//
//         //生成したインスタンスをリストで持っておく
//         list_toggle_.Add(toggle_instance);
//
//         //リストで保持しているインスタンスを削除
//         for (int i = 0; i < list_toggle_.Count; i++)
//         {
//             Destroy(list_toggle_[i]);
//         }
//
        // //リスト自体をキレイにする
        // list_toggle_.Clear();
        //   public void TrggerCloud(){
        //     for(int i = 0; i < list_cloud.Count; i++){
        //     list_cloud[i].GetComponent<BoxCollider2D>().isTrigger = true;
        //   }
        // }

        // private void OnTriggerEnter2D(Collider2D c) {
        //     if(c.gameObject.tag == "groundcheck"){
        //       colCol = gameObject.GetComponent<BoxCollider2D>();
        //       colCol.isTrigger = false;
        //       Debug.Log("OK1");
        //     }
        //   }
        // private void OnTriggerExit2D(Collider2D c) {
        //     if(c.gameObject.tag == "groundcheck"){
        //       Debug.Log("OK");
        //     }
        //   }


        //HeadCheck
        // private void OnChildTriggerEnter2D(Collider2D c) {
        //     if(c.gameObject.tag == "groundcheck"){
        //       colCol = gameObject.GetComponent<BoxCollider2D>();
        //       colCol.isTrigger = false;
        //       Debug.Log("OK1");
        //       // Physics2D.IgnoreLayerCollision(player_layer, ground_floor_layer,false);
        //       }
        //       (c.gameObject.tag == "check") {
        //       if(!GameDirector.collect2 || !GameDirector.collect){
        //         GameObject refObj = GameObject.Find("CloudFactory");
        //         CloudFactory cf = refObj.GetComponent<CloudFactory>();
        //         cf.DestroyCloud();
        //         Player.isJump = false;
        //         anim.SetBool("jump",false);
        //         anim.SetBool("run",false);
        //         anim.SetBool("down",true);
        //         audioSource.SoundBad();
        //         GameDirector.collect = false;
        //         GameDirector.collect2 = false;
        //       }
        //       else if(GameDirector.collect2 && GameDirector.collect){
        //          Physics2D.IgnoreLayerCollision(player_layer, ground_floor_layer);
        //          Player.ySpeed = 30.0f;
        //          Debug.Log("ビューン");
        //        }
        // }
        // }

        //   private void OnChildTriggerExit2D(Collider2D c) {
        //       if (c.gameObject.tag == "groundcheck") {
        //         Physics2D.IgnoreLayerCollision(player_layer, ground_floor_layer, false);
        //         Player.ySpeed = -15.0f;
        //           Debug.Log("すとん");
        //           audioSource.SoundCollect();
        //
        //       }
        //   else if (c.gameObject.tag == "groundcheck") {
        //       Physics2D.IgnoreLayerCollision(player_layer, ground_floor_layer, false);
        //       Debug.Log("土台");
        //
        //   }
        // }
        // private void OnTriggerEnter2D(Collider2D collider){
        //   if(one){
        //   if(collider.tag == "groundcheck") {
        //     GameDirector.next = true;
        //   }
        // }
        // }
        // if(collider.tag == "ground"){
        //   if(!GameDirector.collect2 || !GameDirector.collect){
        //     colCol = collider.gameObject.GetComponent<BoxCollider2D>();
        //     colCol.isTrigger = false;
        //     GameObject refObj = GameObject.Find("CloudFactory");
        //     CloudFactory cf = refObj.GetComponent<CloudFactory>();
        //     cf.DestroyCloud();
        //     Player.isJump = false;
        //     anim.SetBool("jump",false);
        //     anim.SetBool("run",false);
        //     anim.SetBool("down",true);
        //     audioSource.SoundBad();
        //     GameDirector.collect = false;
        //     GameDirector.collect2 = false;
        //     Debug.Log("ooo");
        //
        //   }
          // else if(GameDirector.collect2 && GameDirector.collect){
          //   colCol = collider.gameObject.GetComponent<BoxCollider2D>();
          //   colCol.isTrigger = true;
          //   GameDirector.next = true;
          //   // GameObject refObj = GameObject.Find("CloudFactory");
          //   // CloudFactory cf = refObj.GetComponent<CloudFactory>();
          //   // cf.MakeWall(collider);
          //   audioSource.SoundCollect();
          //
          //
        //   // }
        // }
        // if(collider.tag == "ground"){
        //   colCol = collider.gameObject.GetComponent<BoxCollider2D>();
        //   colCol.isTrigger = true;
        // }

        //player
        // using System.Collections;
        // using System.Collections.Generic;
        // using UnityEngine;
        //
        // public class Player : MonoBehaviour
        // {
        //    public float speed;
        //    public float gravity;
        //    public float jumpSpeed;
        //    public float jumpHeight;
        //    public float jumpLimitTime;
        //    public static float ySpeed;
        //    public GroundCheck ground;
        //    // public GroundCheck head;
        //
        //    private Animator anim = null;
        //    private Rigidbody2D rb = null;
        //    private bool isGround = false;
        //    public static bool isJump = false;
        //    private float jumpPos = 0.0f;
        //    private float jumpTime = 0.0f;
        //    SoundManage audioSource;
        //    // private float beforeVerticallKey;
        //    float count = 0.0f;
        //
        //    // float lastY;
        //    bool countg = false;
        //    bool one;
        //
        //     // Start is called before the first frame update
        //     void Start()
        //     {
        //         anim = GetComponent<Animator>();
        //         rb = GetComponent<Rigidbody2D>();
        //         audioSource = GameObject.Find("SoundManage").GetComponent<SoundManage>();
        //     }
        //
        //     // Update is called once per frame
        //     void Update(){
        //       if(isGround){
        //         isJump = false;
        //       if(Input.GetKeyDown(KeyCode.Space)){
        //         ySpeed = jumpSpeed;
        //         isJump = true;
        //       }
        //     }
        //   }
        //
        //
        //     void FixedUpdate()
        //     {
        //
        //       // if(countg){
        //       //   count += Time.deltaTime;
        //       // }
        //         isGround = ground.IsGround();
        //         // isHead = head.IsGround();
        //         // lastY = transform.position.y;
        //         float horizontalKey = Input.GetAxis("Horizontal");
        //         // float verticallKey = Input.GetAxis("Vertical");
        //
        //         float xSpeed = 0.0f;
        //         ySpeed = -gravity;
        //
        //         // if(isGround){
        //           // if(Input.GetKeyDown(KeyCode.Space)){
        //           //   // one = true;
        //           //   // anim.SetBool("squat",true);
        //           //   // isJump = false;
        //           // beforeVerticallKey == 0.0f
        //           // }
        //          //  bool pushUpKey = verticallKey > 0 && verticallKey < 0.8f;
        //          // if(Input.GetKeyDown(KeyCode.Space) || pushUpKey){
        //          //   ySpeed = jumpSpeed;
        //          //   jumpPos = transform.position.y;
        //          //   isJump = true;
        //          //   jumpTime = 0.0f;
        //            // audioSource.SoundJump();
        //            // Debug.Log("ジャンプ確認");
        //        //   }
        //        //   else {
        //        //     isJump = false;
        //        //   }
        //        // }
        //           // anim.SetBool("squat",true);
        //           // Invoke("DelayMethod", 3.5f);
        //           // isJump = false;
        //           // countg = true;
        //           // one = true;
        //           // anim.SetBool("squatdown",false);
        //           // anim.SetBool("squatup",true);
        //         // }
        //         // else if(count > 0.2f){
        //         //   if(one){
        //
        //           // audioSource.SoundJump();
        //           // anim.SetBool("squat",false);
        //           // anim.SetBool("jump",true);
        //
        //           // rb.velocity = new Vector2(xSpeed,ySpeed);
        //           // // countg = false;
        //           // count = 0.0f;
        //           // one = false;
        //         // }
        //         // }
        //
        //       // if(one && count > 0.2f){
        //       //    ySpeed = jumpSpeed;
        //
        //
        //          // anim.SetBool("squat",false);
        //
        //          // countg = false;
        //          // count = 0.0f;
        //          // one = false;
        //
        //        // else{
        //        //   isJump = false;
        //        // }
        //
        //
        // //      else if(isJump){
        // //        bool pushUpKey = verticallKey > 0 && verticallKey < 0.8f;
        // //        bool canHeight = jumpPos + jumpHeight > transform.position.y;
        // //        bool canTime = jumpLimitTime > jumpTime;
        // //      if(pushUpKey  && canHeight && canTime){
        // //        anim.SetBool("squat",false);
        // //        ySpeed = jumpSpeed;
        // //        jumpTime += Time.deltaTime;
        // //        Debug.Log("とんでます");
        // //      }
        // //      else {
        // //        isJump = false;
        // //        jumpTime = 0.0f;
        // //        Debug.Log("おります");
        // // }
        // //      }
        //
        //
        // //      // if(lastY > transform.position.y){
        // //      //   Debug.Log("確認確認確認");
        // //      //  anim.SetBool("jumpup",false);
        // //      //  anim.SetBool("jumpdown",true);
        // // }
        //
        //
        //         if(horizontalKey > 0){
        //           transform. localScale = new Vector3(-1,1,1);
        //           anim.SetBool("run",true);
        //           xSpeed = speed;
        //         }
        //         else if(horizontalKey < 0){
        //           transform. localScale = new Vector3(1,1,1);
        //           anim.SetBool("run",true);
        //           xSpeed = -speed;
        //         }
        //         else{
        //           anim.SetBool("run",false);
        //           xSpeed = 0.0f;
        //         }
        //         anim.SetBool("jump", isJump);
        //         anim.SetBool("ground", isGround);
        //         rb.velocity = new Vector2(xSpeed,ySpeed);
        //         // beforeVerticallKey = verticallKey;
        //     }
        // }
        //
        // //
        // using System.Collections;
        // using System.Collections.Generic;
        // using UnityEngine;
        //
        // public class Player3 : MonoBehaviour
        // {
        //    public float speed;
        //    public float gravity;
        //    public float jumpSpeed;
        //    public float jumpHeight;
        //    public float jumpLimitTime;
        //    public static float ySpeed;
        //    public GroundCheck ground;
        //    // public GroundCheck head;
        //
        //    private Animator anim = null;
        //    private Rigidbody2D rb = null;
        //    private bool isGround = false;
        //    public static bool isJump = false;
        //    private float jumpPos = 0.0f;
        //    private float jumpTime = 0.0f;
        //    SoundManage audioSource;
        //    private float beforeVerticallKey;
        //    float count = 0.0f;
        //
        //    // float lastY;
        //    bool countg = false;
        //    bool one;
        //
        //     // Start is called before the first frame update
        //     void Start()
        //     {
        //         anim = GetComponent<Animator>();
        //         rb = GetComponent<Rigidbody2D>();
        //         audioSource = GameObject.Find("SoundManage").GetComponent<SoundManage>();
        //     }
        //
        //     // Update is called once per frame
        //
        //
        //     void FixedUpdate()
        //     {
        //
        //       // if(countg){
        //       //   count += Time.deltaTime;
        //       // }
        //         isGround = ground.IsGround();
        //         // isHead = head.IsGround();
        //         // lastY = transform.position.y;
        //         float horizontalKey = Input.GetAxis("Horizontal");
        //         float verticallKey = Input.GetAxis("Vertical");
        //
        //         float xSpeed = 0.0f;
        //         ySpeed = -gravity;
        //
        //         if(isGround){
        //           // if(Input.GetKeyDown(KeyCode.Space)){
        //           //   // one = true;
        //           //   // anim.SetBool("squat",true);
        //           //   // isJump = false;
        //           // beforeVerticallKey == 0.0f
        //           // }
        //           bool pushUpKey = verticallKey > 0 && verticallKey < 0.8f;
        //          if(Input.GetKeyDown(KeyCode.Space) || pushUpKey){
        //            ySpeed = jumpSpeed;
        //            jumpPos = transform.position.y;
        //            isJump = true;
        //            jumpTime = 0.0f;
        //            // audioSource.SoundJump();
        //            // Debug.Log("ジャンプ確認");
        //          }
        //          else {
        //            isJump = false;
        //          }
        //        }
        //           // anim.SetBool("squat",true);
        //           // Invoke("DelayMethod", 3.5f);
        //           // isJump = false;
        //           // countg = true;
        //           // one = true;
        //           // anim.SetBool("squatdown",false);
        //           // anim.SetBool("squatup",true);
        //         // }
        //         // else if(count > 0.2f){
        //         //   if(one){
        //
        //           // audioSource.SoundJump();
        //           // anim.SetBool("squat",false);
        //           // anim.SetBool("jump",true);
        //
        //           // rb.velocity = new Vector2(xSpeed,ySpeed);
        //           // // countg = false;
        //           // count = 0.0f;
        //           // one = false;
        //         // }
        //         // }
        //
        //       // if(one && count > 0.2f){
        //       //    ySpeed = jumpSpeed;
        //
        //
        //          // anim.SetBool("squat",false);
        //
        //          // countg = false;
        //          // count = 0.0f;
        //          // one = false;
        //
        //        // else{
        //        //   isJump = false;
        //        // }
        //
        //
        //      else if(isJump){
        //        bool pushUpKey = verticallKey > 0 && verticallKey < 0.8f;
        //        bool canHeight = jumpPos + jumpHeight > transform.position.y;
        //        bool canTime = jumpLimitTime > jumpTime;
        //      if(pushUpKey  && canHeight && canTime){
        //        anim.SetBool("squat",false);
        //        ySpeed = jumpSpeed;
        //        jumpTime += Time.deltaTime;
        //        Debug.Log("とんでます");
        //      }
        //      else {
        //        isJump = false;
        //        jumpTime = 0.0f;
        //        Debug.Log("おります");
        // }
        //      }
        //
        //
        // //      // if(lastY > transform.position.y){
        // //      //   Debug.Log("確認確認確認");
        // //      //  anim.SetBool("jumpup",false);
        // //      //  anim.SetBool("jumpdown",true);
        // // }
        //
        //
        //         if(horizontalKey > 0){
        //           transform. localScale = new Vector3(-1,1,1);
        //           anim.SetBool("run",true);
        //           xSpeed = speed;
        //         }
        //         else if(horizontalKey < 0){
        //           transform. localScale = new Vector3(1,1,1);
        //           anim.SetBool("run",true);
        //           xSpeed = -speed;
        //         }
        //         else{
        //           anim.SetBool("run",false);
        //           xSpeed = 0.0f;
        //         }
        //         anim.SetBool("jump", isJump);
        //         anim.SetBool("ground", isGround);
        //         rb.velocity = new Vector2(xSpeed,ySpeed);
        //         beforeVerticallKey = verticallKey;
        //     }
        // }
        using System.Collections;
        using System.Collections.Generic;
        using UnityEngine;

        // public class Player2 : MonoBehaviour
        // {
        //       public float speed = 5;
        //       public GroundCheck ground;
        //       private bool isGround = false;
        //       private Vector2 dir;
        //       private Animator anim = null;
        //
        //       // 画面の左・右・上・下の境界の位置
        //       private float boundL;
        //       private float boundR;
        //       private float boundT;
        //       private float boundB;
        //
        //       private new Rigidbody2D rigidbody2D;
        //     // Start is called before the first frame update
        //     void Start()
        //     {
        //       anim = GetComponent<Animator>();
        //       this.rigidbody2D = this.GetComponent<Rigidbody2D>();
        //
        //       // あらかじめ、画面上下左右の縁がワールド空間上でどこに位置するか調べておく
        //       var mainCamera = Camera.main;
        //       var positionZ = this.transform.position.z;
        //       var topRight = mainCamera.ViewportToWorldPoint(new Vector3(1.0f, 1.0f, positionZ));
        //       var bottomLeft = mainCamera.ViewportToWorldPoint(new Vector3(0.0f, 0.0f, positionZ));
        //       this.boundL = bottomLeft.x;
        //       this.boundR = topRight.x;
        //       this.boundT = topRight.y;
        //       this.boundB = bottomLeft.y;
        //     }
        //
        //     // Update is called once per frame
        //     void Update()
        //     {
        //       var x = Input.GetAxisRaw("Horizontal");
        //
        //       // 上・下
        //       var y = Input.GetAxisRaw("Vertical");
        //
        //       this.dir = new Vector2(x, y);
        //     }
        //
        //     private void FixedUpdate()
        //     {
        //         // 現在の位置
        //         isGround = ground.IsGround();
        //         var position = this.rigidbody2D.position;
        //
        //         // 範囲制限を加える前の速度
        //         var velocity = this.dir * this.speed;
        //
        //         // 今回の物理状態更新での移動量
        //         var deltaPosition = velocity * Time.deltaTime;
        //
        //         // 範囲制限を加えなかった場合の、予想される移動先
        //         var nextPosition = position + deltaPosition;
        //
        //         // 予想移動先の座標をクランプする
        //         var clampedNextPosition = new Vector2(
        //             Mathf.Clamp(nextPosition.x, this.boundL, this.boundR),
        //             Mathf.Clamp(nextPosition.y, this.boundB, this.boundT));
        //
        //         // クランプ後の移動先座標から移動量を求める
        //         var clampedDeltaPosition = clampedNextPosition - position;
        //
        //         // クランプ後の移動量から速度を求める
        //         var clampedVelocity = clampedDeltaPosition / Time.deltaTime;
        //
        //         // クランプ後の速度を代入
        //         this.rigidbody2D.velocity = clampedVelocity;
        //     }
        // }
        // using System.Collections;
        // using System.Collections.Generic;
        // using UnityEngine;
        // using UnityEngine.UI;
        //
        // [RequireComponent(typeof(Slider))]
        // public class SoundSlider : MonoBehaviour
        // {
        //
        //     Slider m_Slider;
        //     [SerializeField]
        //     bool m_isInput;
        //     [SerializeField]
        //     float m_ScroolSpeed = 1;
        //     void Awake()
        //     {
        //         m_Slider = GetComponent<Slider>();
        //         m_Slider.value = AudioListener.volume ;
        //     }
        //
        //     private void OnEnable()
        //     {
        //         m_Slider.value = AudioListener.volume;
        //         m_Slider.onValueChanged.AddListener((sliderValue) => AudioListener.volume = sliderValue);
        //     }
        //
        //     private void OnDisable()
        //     {
        //         m_Slider.onValueChanged.RemoveAllListeners();
        //     }
        //
        // }
        //
