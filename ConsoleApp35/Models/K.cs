namespace ConsoleApp35.Models
{
    public class K
    {
        public int Kelvin { get; set; }
        public K(int kelvin)
        {
            Kelvin = kelvin;
        }
        public static implicit operator C(K kelvinn)
        {
            return new C(kelvinn.Kelvin - 273);
        }
    }
}
