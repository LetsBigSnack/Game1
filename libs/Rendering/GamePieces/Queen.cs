namespace libs;

public class Queen : GameObject {
    public Queen () : base() {
        this.Type = GameObjectType.Queen;
        this.CharRepresentation = '♕';
    }

        public override void Move(int dx, int dy) {

        SetPrevPosX(this.PosX);
        SetPrevPosY(this.PosY);
        this.PosX += dx;
        this.PosY += dy;
    }
}