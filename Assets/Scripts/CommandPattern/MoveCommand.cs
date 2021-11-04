public class MoveCommand : Command
{
    NewPlayerMovement playerMovement;
    float h, v;

    public MoveCommand(NewPlayerMovement _playerMovement, float _h, float _v)
    {
        this.playerMovement = _playerMovement;
        this.h = _h;
        this.v = _v;
    }

    //Trigger
    public override void Execute()
    {
        playerMovement.Move(h, v);
        playerMovement.Animating(h, v);
    }

    public override void UnExecute()
    {
        playerMovement.Move(-h, -v);
        playerMovement.Animating(h, v);
    }
}
