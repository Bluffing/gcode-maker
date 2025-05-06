namespace gcode_maker
{
    public class Coord
    {
        public double x;
        public double y;
        public Coord(double x, double y) { this.x = x; this.y = y; }

        public static implicit operator Coord((double x, double y) t) { return new Coord(t.x, t.y); }
        public static implicit operator (double, double)(Coord c) { return (c.x, c.y); }

        public static bool operator !=(Coord a, Coord b) => a.x != b.x || a.y != b.y;
        public static bool operator ==(Coord a, Coord b) => !(a != b);
        public override bool Equals(object? obj)
        {
            var coord = obj as Coord;
            if (coord is not null)
                return this == coord;
            (int x, int y)? tuple = obj as (int x, int y)?;
            if (tuple is not null)
                return this == tuple;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Coord operator +(Coord a, Coord b) => new Coord(a.x + b.x, a.y + b.y);
        public static Coord operator +(Coord a, (int x, int y) b) => new Coord(a.x + b.x, a.y + b.y);
        public static Coord operator +((int x, int y) a, Coord b) => new Coord(a.x + b.x, a.y + b.y);
        public static Coord operator +(Coord a, int b) => new Coord(a.x + b, a.y + b);


        public static Coord operator -(Coord a, Coord b) => new Coord(a.x - b.x, a.y - b.y);
        public static Coord operator -(Coord a, (int x, int y) b) => new Coord(a.x - b.x, a.y - b.y);
        public static Coord operator -((int x, int y) a, Coord b) => new Coord(a.x - b.x, a.y - b.y);
        public static Coord operator -(Coord a, int b) => new Coord(a.x - b, a.y - b);
        public static Coord operator -(Coord a) => new Coord(-a.x, -a.y);

        public static Coord operator /(Coord a, int b) => new Coord(a.x / b, a.y / b);
        public static Coord operator /(Coord a, float b) => new Coord((int)(a.x / b), (int)(a.y / b));
        public static Coord operator *(Coord a, int b) => new Coord(a.x * b, a.y * b);
        public static Coord operator *(int b, Coord a) => new Coord(a.x * b, a.y * b);
        public static Coord operator *(Coord a, float b) => new Coord((int)(a.x * b), (int)(a.y * b));
        public static Coord operator *(float b, Coord a) => new Coord((int)(a.x * b), (int)(a.y * b));

        public static Coord Clamp(Coord a, Coord min, Coord max) => new Coord(Math.Clamp(a.x, min.x, max.x), Math.Clamp(a.y, min.y, max.y));
        // public bool FitIn(Coord other) => x >= 0 && x <= other.x && y >= 0 && y <= other.y;

        private bool IsBetween(double a, double b, double point) => (a < b && a <= point && point <= b) || (a >= point && point >= b);
        // public bool FitIn(Coord start, Coord end) => x >= start.x && x <= end.x && y >= start.y && y <= end.y;
        public bool FitIn(Coord start, Coord end)
        {
            var bleak = IsBetween(start.x, end.x, x);
            var bloo = IsBetween(start.y, end.y, y);

            return IsBetween(start.x, end.x, x) && IsBetween(start.y, end.y, y);
        }
        public Coord Round(int digits = 0)
        {
            x = Math.Round(x, digits);
            y = Math.Round(y, digits);
            return this;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }

        public string GCodeString(string cmd)
        {
            return $"{cmd} X{x:0.000} Y{y:0.000}";
        }
    }
}
