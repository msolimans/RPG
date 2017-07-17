namespace RPG.BLL.Geo
{
    public class HeartsOnlyScene: ISceneBuilder
    {
        public HeartsOnlyScene()
        {
            myScene = Scene.GetInstance();
        }

        public HeartsOnlyScene(IScene scene)
        {
            myScene = scene;
        }

        public override bool HasHearts()
        {
            return false;
        }
        
        
    }
}