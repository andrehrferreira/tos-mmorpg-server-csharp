namespace Server
{
    public struct Transform
    {
        public Vector3 Position;
        public Rotator Rotation;
        public Vector3 Scale;

        public Transform(Vector3 position, Rotator rotation, Vector3 scale)
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
        }

        public void SetPosition(Vector3 newLocation)
        {
            Position = newLocation;
        }

        public Transform Copy()
        {
            return new Transform(
                Position.Copy(),
                Rotation.Copy(),
                Scale.Copy()
            );
        }
    }
}
