namespace libs;

public class Rook : GameObject {

    public Rook () : base(){
        this.Type = GameObjectType.Rook;
        this.CharRepresentation = '♖';
        this.Color = ConsoleColor.Gray;
    }

            public override void Move(int dx, int dy) {

        SetPrevPosX(this.PosX);
        SetPrevPosY(this.PosY);
        this.PosX += dx;
        this.PosY += dy;
    }
}