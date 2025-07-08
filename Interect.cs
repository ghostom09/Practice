using UnityEngine;
using Unity.Mathematics;

public class Interect : MonoBehaviour
{
    public GameObject button;
    public static bool Fade; 
    public static bool bed;
    public static bool generator;
    public static bool EasterEggPicture;
    public static bool homeDoor; //집에서 나가기
    public static bool interectFade; //페이드 상호작용
    public static bool goHomeBack; //집으로 돌아갈래
    public static bool loseWill = false; //버튼 삭제
    public static bool friendDoorIn; //친구집들어가기
    public static bool friendDoorOut; //친구집나가기
    public static bool bag; 
    public static bool pickUpItem; 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && CompareTag("Bed"))
        {
            // Destroy(other.gameObject);
        }
        if (other.CompareTag("Player") && CompareTag("Generator"))
        {
            Vector3 buttonPos = new Vector3(transform.position.x + 0.5f, transform.position.y -4.2f, 0);
            Instantiate(button, buttonPos, quaternion.identity);
            Button.buttonIsAlive = true;
        }
        if (other.CompareTag("Player") && CompareTag("Picture(Easteregg)"))
        {
            Button.buttonIsAlive = true;
        }
        if (other.CompareTag("Player") && CompareTag("HomeDoor"))
        {
            Vector3 buttonPos = new Vector3(transform.position.x - 1f, transform.position.y -4.2f, 0);
            Instantiate(button, buttonPos, quaternion.identity);
            Button.buttonIsAlive = true;
            interectFade = true;
            homeDoor = true;
        }
        if (other.CompareTag("Player") && CompareTag("GoBackHome")) //asd
        {
            if (!loseWill)
            {
                Vector3 buttonPos = new Vector3(transform.position.x + 1.5f, transform.position.y -4.7f, 0);
                Instantiate(button, buttonPos, quaternion.identity);
                goHomeBack = true;
            }
            Button.buttonIsAlive = true;
        }
        if (other.CompareTag("Player") && CompareTag("FriendDoorIn"))
        {
            Vector3 buttonPos = new Vector3(transform.position.x + 0.5f, transform.position.y -4.2f, 0);
            Instantiate(button, buttonPos, quaternion.identity);
            Button.buttonIsAlive = true;
            interectFade = true;
            friendDoorIn = true;
        }
        if (other.CompareTag("Player") && CompareTag("FriendDoorOut"))
        {
            Vector3 buttonPos = new Vector3(transform.position.x + 1.5f, transform.position.y -4.2f, 0);
            Instantiate(button, buttonPos, quaternion.identity);
            Button.buttonIsAlive = true;
            interectFade = true;
            friendDoorOut = true;
        }
        if (other.CompareTag("Player") && CompareTag("Bag"))
        {
            Vector3 buttonPos = new Vector3(transform.position.x + 1.5f, transform.position.y -4.2f, 0);
            Instantiate(button, buttonPos, quaternion.identity);
            Button.buttonIsAlive = true;
            bag = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Button.buttonIsAlive = false;
            interectFade = false;
            friendDoorIn = false;
            friendDoorOut = false;
            goHomeBack = false;
            homeDoor = false;
            if (pickUpItem)
            {
                Debug.Log("pick up item");
                Destroy(gameObject);
                pickUpItem = false;
            }
        }
    }
}
