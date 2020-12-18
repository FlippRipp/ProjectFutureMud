using System;

namespace FutureMud.Actor
{
    [Serializable]
    public class Actor
    {
        public ActorTags actorTags;
        public ActorAppearance actorAppearance;

        public string actorIDName;
        public string actorDisplayName;
    }
}