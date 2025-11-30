namespace Task2.My_Controller
{
    public class Api_SomeImage
    {
        private API_Controller controller = new API_Controller();
        public SomeImageEntity GetImage(int id)
        {
            controller.GetOne(id);
            return new SomeImageEntity();
        }
        public SomeImageEntity SetImage(SomeImageEntity Image_entity)
        {
            controller.Update();
            return Image_entity;
        }
        public List<SomeImageEntity> GetEntitiesByFilter(string filter)
        {
            controller.GetByFilter();
            return new List<SomeImageEntity>();
        }
    }
}
