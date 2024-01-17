namespace Theme_35_Lesson_4_OOPTasks
{
    public enum CerealType
    {
        ГРЕЧКА,
        ПШЕНО,
        РИС,
        БУЛГУР
    }
    public class Cereal:Product
    {
        public CerealType Types { get; set; }

        public Cereal()
        {

        }

        public Cereal(string name, decimal price, string seller, CerealType type) : base(name, price, seller)
        {
            Types = type;
        }
    }
}
