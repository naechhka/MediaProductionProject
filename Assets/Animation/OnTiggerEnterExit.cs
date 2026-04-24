using UnityEngine;

public class OnTiggerEnterExit : MonoBehaviour
{

    public Animator animator;
    public AudioClip talking;
    public float delay = 3f;
    public TMPro.TextMeshProUGUI text;

    public string message;
    public GameObject panel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // animator.SetBool("talk", true);
        animator.SetTrigger("start");
        gameObject.GetComponent<AudioSource>().PlayOneShot(talking);
        panel.SetActive(true);
        text.text = message;
        Debug.Log("UI TRIGGER");

    }

    void OnTriggerExit(Collider other)
    {
        // animator.SetBool("talk", false);
        gameObject.GetComponent<AudioSource>().Stop();
        panel.SetActive(false);
    }
}
