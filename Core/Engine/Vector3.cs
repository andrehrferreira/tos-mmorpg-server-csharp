namespace Server
{
    public struct Vector3
    {
        public float X; 
        public float Y; 
        public float Z;

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3 Zero()
        {
            return new Vector3(0, 0, 0);
        }

        public static Vector3 One()
        {
            return new Vector3(1, 1, 1);
        }

        public Vector3 Add(Vector3 v)
        {
            return new Vector3(X + v.X, Y + v.Y, Z + v.Z);
        }

        public Vector3 AddScalar(float v)
        {
            return new Vector3(X + v, Y + v, Z + v);
        }

        public Vector3 Subtract(Vector3 v)
        {
            return new Vector3(X - v.X, Y - v.Y, Z - v.Z);
        }

        public Vector3 MultiplyScalar(float scalar)
        {
            return new Vector3(X * scalar, Y * scalar, Z * scalar);
        }

        public Vector3 DivideScalar(float scalar)
        {
            return scalar != 0 ? new Vector3(X / scalar, Y / scalar, Z / scalar) : new Vector3(0, 0, 0);
        }

        public Vector3 Normalize()
        {
            float length = Length();
            return DivideScalar(length);
        }

        public float Length()
        {
            return (float)Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public static float Dot(Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static Vector3 Cross(Vector3 v1, Vector3 v2)
        {
            return new Vector3(
                v1.Y * v2.Z - v1.Z * v2.Y,
                v1.Z * v2.X - v1.X * v2.Z,
                v1.X * v2.Y - v1.Y * v2.X
            );
        }

        public float DistanceTo(Vector3 other)
        {
            return (float)Math.Sqrt(
                (X - other.X) * (X - other.X) +
                (Y - other.Y) * (Y - other.Y) +
                (Z - other.Z) * (Z - other.Z)
            );
        }

        public float DistanceBetween(Vector3 other)
        {
            float dx = other.X - X;
            float dy = other.Y - Y;
            float dz = other.Z - Z;
            return (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        public bool Diff(Vector3 other)
        {
            int roundX1 = (int)Math.Round(X);
            int roundY1 = (int)Math.Round(Y);
            int roundZ1 = (int)Math.Round(Z);
            int roundX2 = (int)Math.Round(other.X);
            int roundY2 = (int)Math.Round(other.Y);
            int roundZ2 = (int)Math.Round(other.Z);

            return roundX1 != roundX2 || roundY1 != roundY2 || roundZ1 != roundZ2;
        }

        public Vector3 Scale(float scalar)
        {
            return new Vector3(X * scalar, Y * scalar, Z * scalar);
        }

        public Vector3 Lerp(Vector3 target, float t)
        {
            t = Math.Max(0, Math.Min(1, t));
            float newX = (1 - t) * X + t * target.X;
            float newY = (1 - t) * Y + t * target.Y;
            float newZ = (1 - t) * Z + t * target.Z;
            return new Vector3(newX, newY, newZ);
        }


        public Vector3 Copy()
        {
            return new Vector3(X, Y, Z);
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}";
        }
    }
}
