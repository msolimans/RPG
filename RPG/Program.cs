using System;
using System.Collections.Generic;
using RPG.BLL.Geo;


namespace RPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("This is an RPG demo game");
            
            //SceneBuilder (has gold/heart) - NonGoldSceneBuilder (has only 
            ISceneBuilder builder = new SceneBuilder(Scene.GetInstance());
            //can be used also here
            //ISceneBuilder builder = new SceneBuilder();
            SceneEngineer engineer = new SceneEngineer(builder);
            engineer.MakeScene();
            
            //player should use move and hit using weapons
            
            
            
            
            
        }
    }
}