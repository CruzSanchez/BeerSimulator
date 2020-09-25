using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class QuickWheel : MonoBehaviour
{
    float posX;
    float posY;
    int position;
    Color color;
    Animator animator;
    SpriteRenderer spriteRenderer;
    ActiveItem activeItem;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        color = GetComponent<SpriteRenderer>().color;
        activeItem = FindObjectOfType<ActiveItem>();

        switch (gameObject.name.Split('_').LastOrDefault())
        {
            case "1":
                position = 1;
                posX = -.25f;
                posY = .25f;
                break;
            case "2":
                position = 2;
                posX = 0f;
                posY = .25f;
                break;
            case "3":
                position = 3;
                posX = .25f;
                posY = .25f;
                break;
            case "4":
                position = 4;
                posX = -.25f;
                posY = 0f;
                break;
            case "5":
                position = 5;
                posX = 0f;
                posY = 0f;
                break;
            case "6":
                position = 6;
                posX = .25f;
                posY = 0f;
                break;
            case "7":
                position = 7;
                posX = -.25f;
                posY = -.25f;
                break;
            case "8":
                position = 8;
                posX = -0f;
                posY = -.25f;
                break;
            case "9":
                position = 9;
                posX = .25f;
                posY = -.25f;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            animator.Play($"{gameObject.name}_Open");
            transform.position = new Vector3(posX, posY, 12);
            HighlightSquare();
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.Play($"{gameObject.name}_Close");
            transform.position = new Vector3(0f, 0f, -10);
            GetComponent<SpriteRenderer>().color = color;
            selectItem();

        }
    }

    void selectItem()
    {
        switch (position)
        {
            case 1:
                if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") > 0)
                {
                    var child = gameObject.transform.GetChild(0);
                    activeItem.SetSprite(child.gameObject.GetComponent<SpriteRenderer>().sprite);
                }
                break;

            case 2:
                if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") > 0)
                {
                    var child = gameObject.transform.GetChild(0);
                    activeItem.SetSprite(child.gameObject.GetComponent<SpriteRenderer>().sprite);
                }
                break;

            case 3:
                if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") > 0)
                {
                    var child = gameObject.transform.GetChild(0);
                    activeItem.SetSprite(child.gameObject.GetComponent<SpriteRenderer>().sprite);
                }
                break;

            //case 4:
            //    if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") == 0) sprite.color = Color.red;
            //    else sprite.color = color;
            //    break;

            //case 5:
            //    if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0) sprite.color = Color.red;
            //    else sprite.color = color;
            //    break;

            //case 6:
            //    if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") == 0) sprite.color = Color.red;
            //    else sprite.color = color;
            //    break;

            //case 7:
            //    if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") < 0) sprite.color = Color.red;
            //    else sprite.color = color;
            //    break;

            //case 8:
            //    if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") < 0) sprite.color = Color.red;
            //    else sprite.color = color;
            //    break;

            //case 9:
            //    if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") < 0) sprite.color = Color.red;
            //    else sprite.color = color;
            //    break;

            default:
                break;
        }
    }

    void HighlightSquare()
    {

        switch (position)
        {
            case 1:
                if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") > 0) spriteRenderer.color = Color.red;
                else spriteRenderer.color = color;
                break;

            case 2:
                if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") > 0) spriteRenderer.color = Color.red;
                else spriteRenderer.color = color;
                break;

            case 3:
                if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") > 0) spriteRenderer.color = Color.red;
                else spriteRenderer.color = color;
                break;

            case 4:
                if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") == 0) spriteRenderer.color = Color.red;
                else spriteRenderer.color = color;
                break;

            case 5:
                if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0) spriteRenderer.color = Color.red;
                else spriteRenderer.color = color;
                break;

            case 6:
                if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") == 0) spriteRenderer.color = Color.red;
                else spriteRenderer.color = color;
                break;

            case 7:
                if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") < 0) spriteRenderer.color = Color.red;
                else spriteRenderer.color = color;
                break;

            case 8:
                if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") < 0) spriteRenderer.color = Color.red;
                else spriteRenderer.color = color;
                break;

            case 9:
                if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") < 0) spriteRenderer.color = Color.red;
                else spriteRenderer.color = color;
                break;

            default:
                break;
        }
    }
}
