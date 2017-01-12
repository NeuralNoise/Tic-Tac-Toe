using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    public enum StateEnum { Empty, Cross, Cercle}
    StateEnum state;
    public StateEnum State
    {
        get { return state; }
        set
        {
            state = value;
            switch(state)
            {
                case StateEnum.Empty:
                    transform.GetChild(0).gameObject.SetActive(false);
                    transform.GetChild(1).gameObject.SetActive(false);
                    transform.GetComponent<Button>().interactable = true;
                    break;
                case StateEnum.Cross:
                    transform.GetChild(0).gameObject.SetActive(false);
                    transform.GetChild(1).gameObject.SetActive(true);
                    transform.GetComponent<Button>().interactable = false;
                    break;
                case StateEnum.Cercle:
                    transform.GetChild(0).gameObject.SetActive(true);
                    transform.GetChild(1).gameObject.SetActive(false);
                    transform.GetComponent<Button>().interactable = false;
                    break;
            }
        }
    }

}
