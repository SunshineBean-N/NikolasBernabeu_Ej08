using UnityEngine;

public class JestorMEnu : MonoBehaviour
{
    public bool controlPanel;
    public string nombreAnimacion;
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ControlAnimacion()
    {
        if (controlPanel) { nombreAnimacion = "nombrequecorresponda"; }
        else { nombreAnimacion = "laotraanimacion"; }
        animator.Play(nombreAnimacion);
        controlPanel = !controlPanel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
