namespace libs;

public class Pawn : GameObject {

    public Pawn () : base(){
        this.Type = GameObjectType.Pawn;
        this.CharRepresentation = '♙';
        this.Color = ConsoleColor.Black;
    }

        public override void Move(int dx, int dy) {

        SetPrevPosX(this.PosX);
        SetPrevPosY(this.PosY);
        this.PosX += dx;
        this.PosY += dy;
    }
}