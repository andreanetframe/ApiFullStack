
namespace fullstack.Data
{
    public class UserData
    {

        public class MenuItem
        {
            public int id { get; set; }
            public string label { get; set; }

        }

        public int id { get; set; }
        public string name { get; set; }
        public string token { get; set; }
        public List<MenuItem> menuitems { get; set; }

        public UserData()
        {
            menuitems = new List<MenuItem>();
        }

        public void AddMenuItem(int id, string label)
        {
            MenuItem m = new MenuItem();
            m.id = id;
            m.label = label;
            menuitems.Add(m);
        }

    }
}
