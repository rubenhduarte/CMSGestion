namespace SharedComponents;

public abstract class ValueObject<T> : IEquatable<T> where T : ValueObject<T>
{
    protected abstract bool EqualsCore(T other);
    protected abstract int GetHashCodeCore();

    public bool Equals(T other)
    {
        if (other == null) return false;
        if (ReferenceEquals(this, other)) return true;
        return EqualsCore(other);
    }

    public override bool Equals(object obj) => Equals(obj as T);

    public override int GetHashCode() => GetHashCodeCore();

    public static bool operator ==(ValueObject<T> a, ValueObject<T> b)
    {
        if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            return true;

        if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            return false;

        return a.Equals(b);
    }

    public static bool operator !=(ValueObject<T> a, ValueObject<T> b) => !(a == b);
}
