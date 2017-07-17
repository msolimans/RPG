namespace RPG.BLL.Items
{
    public class Hearts: Item
    {
        public int Galons { get; internal set; }
        //how many galons of this type of Hearts that should be used to make player fully alive or restored 
        public int FullAliveGalons { get; internal set; }

        public Hearts(int id, string name) : base(id, name)
        {
            Galons = 0;
            FullAliveGalons = 0;
        }

        public Hearts(int id, string name, int galons, int fullAliveGalons) : base(id, name)
        {
            Galons = galons;
            FullAliveGalons = fullAliveGalons;
        }
        
        
        
    }
}