
namespace Task2.My_Controller
{
    public class API_Controller
    {
        public SomeEntity Create(SomeEntity entity) { return entity; }
        public SomeEntity Update(SomeEntity entity) { return entity; }
        public SomeEntity GetOne(int id) { return new SomeEntity(); }
        public List<SomeEntity> GetMany() { return new List<SomeEntity>(); }
        public List<SomeEntity> GetByFilter() { return new List<SomeEntity>(); }
        public SomeEntity Delete(int id) { return new SomeEntity(); }
        public List<SomeEntity> DeleteMany() { return new List<SomeEntity>(); }
        public SomeEntity Print(int id) { return new SomeEntity(); }
        public List<SomeEntity> PrintMany() { return new List<SomeEntity>(); }
        public SomeEntity SetStatus(int id, string status) { return new SomeEntity(); }
        public SomeEntity Deactivate(int id) { return new SomeEntity(); }
        public SomeEntity Activate(int id) { return new SomeEntity(); }

        internal object? Create()
        {
            throw new NotImplementedException();
        }

        internal object? Update()
        {
            throw new NotImplementedException();
        }

        internal object? Delete()
        {
            throw new NotImplementedException();
        }

        internal object? GetOne()
        {
            throw new NotImplementedException();
        }

        internal object? Print()
        {
            throw new NotImplementedException();
        }

        internal object? SetStatus()
        {
            throw new NotImplementedException();
        }

        internal object? Deactivate()
        {
            throw new NotImplementedException();
        }

        internal object? Activate()
        {
            throw new NotImplementedException();
        }
    }
}
