namespace Domain.Models.Abstract;

public abstract class DomainModel : IDomain
{
    public int Id { get; set; }

    /// <summary>
    /// Returns a string representation of the domain model, including its properties.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is DomainModel other)
        {
            return this.Id == other.Id;
        }
        return false;
    }

    /// <summary>
    /// Returns the hash code for the domain model based on its Id.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }
}
