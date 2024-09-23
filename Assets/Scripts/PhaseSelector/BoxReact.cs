using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxReact : MonoBehaviour{
    [SerializeField] private Sprite hoveredSprite;
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private string levelName;

    private SpriteRenderer spriteRenderer;
    public bool isHovered;
    public bool isDisabled;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = defaultSprite;

        isHovered = false;

        if(PlayerPrefs.GetInt(levelName) == 1){
            isDisabled = true;
            spriteRenderer.color = Color.gray;
        }
        else{
            isDisabled = false;
            PlayerPrefs.SetInt(levelName, 0);
            PlayerPrefs.Save();
        }
    }

    void Update(){
        if(isHovered && Input.GetMouseButtonDown(0) && PlayerPrefs.GetInt(levelName) == 0){
            PlayerPrefs.SetInt(levelName, 1);
            PlayerPrefs.Save();

            SceneManager.LoadScene(levelName);
        }
    }

    private void OnTriggerStay2D(Collider2D other) {
        if(other.CompareTag("CatSelector")){
            if(!isDisabled){
                spriteRenderer.sprite = hoveredSprite;
                isHovered = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("CatSelector")){
            spriteRenderer.sprite = defaultSprite;
            isHovered = false;
        }
    }
}