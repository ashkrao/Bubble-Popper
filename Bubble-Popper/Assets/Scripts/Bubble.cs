using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class Bubble : MonoBehaviour, IInputClickHandler
{

    public BubblePopEffect popPrefab;
    public void OnInputClicked(InputClickedEventData eventData)
    {
        //Air tap event on Hololens
        PopOnClick();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // - 1f is roughly the floor position while sitting

        if (this.transform.position.y <= -3f)
        {
            Pop();
        }

    }
    private void Pop()
    {
        this.GetComponent<MeshRenderer>().enabled = false;
        Instantiate(popPrefab);
        Destroy(this.gameObject);
        ScoreScript.Missed += 1;
    }
    private void PopOnClick()
    {
        this.GetComponent<MeshRenderer>().enabled = false;
        Instantiate(popPrefab);
        Destroy(this.gameObject);
        ScoreScript.ScoreValue += 1;
    }
}
