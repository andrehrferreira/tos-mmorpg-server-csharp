
namespace Server
{
    public struct Rotator
    {
        public float Roll;
        public float Pitch;
        public float Yaw;

        public Rotator(float  roll, float pitch, float yaw)
        {
            Roll = roll;
            Pitch = pitch; 
            Yaw = yaw;
        }

        public static Rotator Zero()
        {
            return new Rotator(0, 0, 0);
        }

        private float ToRadians(float degrees)
        {
            return degrees * (float)(Math.PI / 180);
        }

        public Vector3 RotateVector(Vector3 vector)
        {
            float radRoll = ToRadians(Roll);
            float radPitch = ToRadians(Pitch);
            float radYaw = ToRadians(Yaw);

            Vector3 rotatedZ = new Vector3(
                vector.X * (float)Math.Cos(radYaw) - vector.Y * (float)Math.Sin(radYaw),
                vector.X * (float)Math.Sin(radYaw) + vector.Y * (float)Math.Cos(radYaw),
                vector.Z
            );

            Vector3 rotatedY = new Vector3(
                rotatedZ.X * (float)Math.Cos(radPitch) + rotatedZ.Z * (float)Math.Sin(radPitch),
                rotatedZ.Y,
                -rotatedZ.X * (float)Math.Sin(radPitch) + rotatedZ.Z * (float)Math.Cos(radPitch)
            );

            Vector3 rotatedX = new Vector3(
                rotatedY.X,
                rotatedY.Y * (float)Math.Cos(radRoll) - rotatedY.Z * (float)Math.Sin(radRoll),
                rotatedY.Y * (float)Math.Sin(radRoll) + rotatedY.Z * (float)Math.Cos(radRoll)
            );

            return rotatedX;
        }

        public bool Diff(Rotator other)
        {
            int roundX1 = (int)Math.Round(Roll);
            int roundY1 = (int)Math.Round(Pitch);
            int roundZ1 = (int)Math.Round(Yaw);
            int roundX2 = (int)Math.Round(other.Roll);
            int roundY2 = (int)Math.Round(other.Pitch);
            int roundZ2 = (int)Math.Round(other.Yaw);

            return roundX1 != roundX2 || roundY1 != roundY2 || roundZ1 != roundZ2;
        }

        public Rotator Copy()
        {
            return new Rotator(Roll, Pitch, Yaw);
        }

        public override string ToString()
        {
            return $"Roll: {Roll}, Pitch: {Pitch}, Yaw: {Yaw}";
        }
    }
}
