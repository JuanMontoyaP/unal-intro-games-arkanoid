
public static class ArkanoidEvent
{
    public delegate void BallDeadZoneAction(Ball ball);
    public static BallDeadZoneAction OnBallReachDeadZoneEvent;
}
