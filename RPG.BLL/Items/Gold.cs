namespace RPG.BLL.Items
{
    public class Gold: Item
    {
        public int Grams { get; set; }

        public Gold(int id, string name, int grams) : base(id, name)
        {
            Grams = grams;
        }
    }
}