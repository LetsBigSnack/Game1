namespace libs;

public class King : GameObject {

    public King () : base(){
        this.Type = GameObjectType.King;
        this.CharRepresentation = '♚';
        this.Color = ConsoleColor.DarkGreen;
    }

        public override void Move(int dx, int dy) {

        SetPrevPosX(this.PosX);
        SetPrevPosY(this.PosY);
        this.PosX += dx*2;
        this.PosY += dy*2;
    }
}