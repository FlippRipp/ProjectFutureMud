namespace FutureMud.Actor
{
    public abstract class ActorBody
    {
    
        //Description returns a longer description of the object and definition returns a short description
        //in a word or a few
        
        //body
        public abstract string GetBodyDescription();
    
        public abstract string GetArmDescription();
        public abstract string GetArmDefinition();
    
        public abstract string GetHandDescription();
        public abstract string GetLegDescription();
        public abstract string GetFeetDescription();
    
        //head
        public abstract string GetHeadDescription();

        public abstract string GetEyeDescription();
        public abstract string GetNoseDescription();
        public abstract string GetMouthDescription();


    }
}
