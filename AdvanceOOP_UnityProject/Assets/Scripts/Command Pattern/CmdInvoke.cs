// written by Grady
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmdInvoke : MonoBehaviour
{
    // variables
    public Queue<Command> queueOfColorCommands = new Queue<Command>();
    //public IEnumerator paverWaitCounter;
    [SerializeField]public Command RedTile;
    [SerializeField]public Command BlueTile;
    [SerializeField]public Command GreenTile;
    [SerializeField]public Command YellowTile;
    // Start is called before the first frame update
    void Start()
    {
        //this.paverWaitCounter = this.PaverWaitCounter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // simple methods to be called on collision with the player
    // that add the pavers to the queue of commands
    public void AddRed() { queueOfColorCommands.Enqueue(RedTile); }
    public void AddBlue() { queueOfColorCommands.Enqueue(BlueTile); }
    public void AddGreen() { queueOfColorCommands.Enqueue(GreenTile); }
    public void AddYellow() { queueOfColorCommands.Enqueue(YellowTile); }
    // turns off all pavers for simplicity's sake
    public void ToggleOffPavers()
    {
        RedTile.GetComponent<MeshRenderer>().enabled = false;
        BlueTile.GetComponent<MeshRenderer>().enabled = false;
        GreenTile.GetComponent<MeshRenderer>().enabled = false;
        YellowTile.GetComponent<MeshRenderer>().enabled = false;
    }
    // creates time between activations so it is visible to the player
    /*
    IEnumerator PaverWaitCounter(Command c)
    {
        ToggleOffPavers();
        yield return new WaitForSeconds(3f);
        c.Execute();
        
    }*/
    // upon collision with the player, the play paver will run the queue
    public void RunCommands()
    {        
        foreach (Command c in queueOfColorCommands)
        {
            ToggleOffPavers();            
            c.Execute();
            //StartCoroutine(PaverWaitCounter(c));
        }
        foreach (Command c in queueOfColorCommands)
        {
            queueOfColorCommands.Dequeue();
        }
    }
}
