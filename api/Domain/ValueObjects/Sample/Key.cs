using Domain.Entities.Sample;

namespace Domain.ValueObjects.Sample
{
    public class Key : ValueObject
    {
        public Note Root { get; set; }
        public Modification Mod { get; set; }
        public Form Form { get; set; }
        public ICollection<Sound> Sounds { get; set; }
        
        public Key() { }

        public Key(Note root, Modification mod, Form form)
        {
            Root = root;
            Mod = mod;
            Form = form;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Root;
            yield return Mod;
            yield return Form;
        }
    }


    public enum Note
    {
        C, D, E, F, G, A, B
    }

    public enum Modification
    {
        Flat,
        Sharp
    }

    public enum Form
    {
        Major,
        Minor
    }
}
