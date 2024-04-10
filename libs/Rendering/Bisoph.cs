namespace libs;

public class Bisoph : GameObject {

    public Bisoph () : base(){
        this.Type = GameObjectType.Bisoph;
        this.CharRepresentation = '♗';
        this.Color = ConsoleColor.Blue;
    }
}