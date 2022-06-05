using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMovement : MonoBehaviour
{
    private CharacterController _characterController; //char controler
    private bool charMove = true; //hareket ediyor mu?
    public int line = 1;
    public int targetLine = 1;
    private Vector3 charVec = Vector3.zero; //karakter hareket ettirmek için bir vektör
    public float moveSpeed = 10.8f; //hareket hızı
    public float jumpRange = 3.5f;
    public float gravity = 4.5f;
    private float _posY;
    private Animator _animator;
    
    private void Start()
    {
        _animator = GetComponent<Animator>(); //caching
        _characterController = gameObject.GetComponent<CharacterController>(); // cachledik
    }

    private void Update()
    {
        charVec.z = moveSpeed;

        if (_characterController.isGrounded) //anim için
        {
            _animator.SetBool("ground", true);
        }

        Vector3 pos = gameObject.transform.position; //pos'a her döngüde position yükleniyor
        
        if (!line.Equals(targetLine)) //line ile targetLine (hedef line) eşit değilse
        {
            if (targetLine==0 && pos.x < -2) //hedef 0 ve pos.x -2den azsa
            {
                gameObject.transform.position = new Vector3(-2f, pos.y, pos.z); //-2de devam et
                line = targetLine;
                charMove = true;
                charVec.x = 0;
            }else if (targetLine==1 && (pos.x > 0 || pos.x <0)) // hedef 1se ve pos ortada değilse
            {
                if (line == 0 && pos.x>0) // ortanın sağındaysa
                {
                    gameObject.transform.position = new Vector3(0, pos.y, pos.z); //ortaya gel
                    line = targetLine;
                    charMove = true;
                    charVec.x = 0;
                }else if (line == 2 && pos.x<0) //ortanın solundaysa
                {
                    gameObject.transform.position = new Vector3(0, pos.y, pos.z); //ortaya gel
                    line = targetLine;
                    charMove = true;
                    charVec.x = 0;
                }
            }else if (targetLine==2 && pos.x >2) //hedef  2yse ve pos en sağda değilse
            {
                gameObject.transform.position = new Vector3(2, pos.y, pos.z); //2de devam et
                line = targetLine;
                charMove = true;
                charVec.x = 0;
            }
        }
        
        _posY -= gravity * Time.deltaTime * 1.2f; //yer çekimi simulasyonu
        charVec.y = _posY;
        
        checkInputs();
        touchControl();
        
        _characterController.Move(charVec * Time.deltaTime); //hareketin yapılışını yumuşatıyor/zaman katarak yapıyor
    }

    void touchControl()
    {
        if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);

            if (parmak.deltaPosition.x > 48.0f && charMove && line<2)
            {
                targetLine++;
                charMove = false;
                charVec.x = moveSpeed;
            }
            if (parmak.deltaPosition.x < -48.0f && charMove && line>0)
            {
                targetLine--;
                charMove = false;
                charVec.x = -moveSpeed;
            }
            if (parmak.deltaPosition.y > 64.0f && _characterController.isGrounded)  // ---------Jumping----------
            {
                _posY = jumpRange;
                _animator.SetTrigger("jump");
                _animator.SetBool("ground", false);
            }
            
        }
    }

    

    void checkInputs() //klavye kontrole göre hedef, iş yapılış hızı ayarlar
    {
        if (Input.GetKeyDown(KeyCode.A) && charMove && line>0)
        {
            targetLine--;
            charMove = false;
            charVec.x = -moveSpeed;
        }
        if (Input.GetKeyDown(KeyCode.D) && charMove && line<2)
        {
            targetLine++;
            charMove = false;
            charVec.x = moveSpeed;
        }
        
        if (Input.GetKeyDown(KeyCode.W) && _characterController.isGrounded)  // ---------Jumping----------
        {
            _posY = jumpRange;
            _animator.SetTrigger("jump");
            _animator.SetBool("ground", false);
        }
        
    }
}
