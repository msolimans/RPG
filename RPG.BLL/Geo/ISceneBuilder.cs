namespace RPG.BLL.Geo
{
    public abstract class ISceneBuilder
    {
        //composition of scene which can be even passed from outside 
        protected IScene myScene { get; set; }

        public void BuildScene()
        {
            myScene = Scene.GetInstance();
        }

        public void BuildWeapons()
        {
            myScene.SetWeapons();
        }

        public void BuildGold()
        {
            myScene.SetGold();
        }

        public void BuildHearts()
        {
            myScene.SetHearts();
        }

        public void BuildLocations()
        {
            myScene.SetLocations();
        }

        protected void BuildMap()
        {
            myScene.SetMap();
        }

        protected void BuildPlayerWeapons()
        {
            myScene.SetPlayerWeapons();
        }


        public IScene GetScene()
        {
            return myScene;
        }

        public virtual bool HasGold()
        {
            return true;
        }

        public virtual bool HasHearts()
        {
            return true;
        }

        //Template design pattern to build scene based on a template 
        public void Build()
        {
            BuildScene();
            BuildWeapons();
            
            if (HasGold())
                BuildGold();
            if (HasHearts())
                BuildHearts();
            
            BuildLocations();
            BuildMap();
            BuildPlayerWeapons();
        }
    }
}