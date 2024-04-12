namespace libs;

public class Knight : GameObject {

    public Knight () : base(){
        this.Type = GameObjectType.Knight;
        this.CharRepresentation = '♘';
        this.Color = ConsoleColor.Red;
    }

    public override void Move(int dx, int dy) {

        SetPrevPosX(this.PosX);
        SetPrevPosY(this.PosY);
        this.PosX += dx;
        this.PosY += dy;
    }
}