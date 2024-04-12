namespace libs;

public class Bishop : GameObject {

    public Bishop () : base(){
        this.Type = GameObjectType.Bishop;
        this.CharRepresentation = '♗';
        this.Color = ConsoleColor.Blue;
    }
}