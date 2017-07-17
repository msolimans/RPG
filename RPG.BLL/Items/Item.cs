namespace RPG.BLL.Items
{
    //Any collected item that player picks as long as he is a live and visiting different locations.
    //items might be gold, heart, or weapon
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Item(int id, string name)
        {
            Id = id;
            Name = name;
            
        }
    }
}