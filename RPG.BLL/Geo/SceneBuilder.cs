namespace RPG.BLL.Geo
{
    public class SceneBuilder: ISceneBuilder
    {
        //Has Gold/Heart
        public SceneBuilder()
        {
            myScene = Scene.GetInstance();
        }

        public SceneBuilder(IScene scene)
        {
            myScene = scene;
        }
        
        
    }
}