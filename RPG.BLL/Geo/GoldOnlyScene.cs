namespace RPG.BLL.Geo
{
    public class GoldSceneBuilder: ISceneBuilder
    {
      
        public GoldSceneBuilder()
        {
            myScene = Scene.GetInstance();
        }
        
        public GoldSceneBuilder(IScene scene)
        {
            myScene = scene;
        }

        public override bool HasHearts()
        {
            return false;
        }
    }
}