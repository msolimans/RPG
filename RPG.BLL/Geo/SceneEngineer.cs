using System.Security.Permissions;

namespace RPG.BLL.Geo
{
    public class SceneEngineer
    {
        private readonly ISceneBuilder Builder;


        public SceneEngineer(ISceneBuilder builder)
        {
            Builder = builder;
        }

        //in case we need the scene outside
        public IScene GetScene()
        {
            return Builder.GetScene();
        }

        //building different components of the scene (weapons, gold, heats, maps..et)C 
        public void MakeScene()
        {
            Builder.Build();
        }
    }
}