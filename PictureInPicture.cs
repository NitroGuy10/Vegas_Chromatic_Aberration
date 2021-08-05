using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptPortal.Vegas;

namespace Vegas_Chromatic_Aberration
{
    public class PictureInPicture
    {
        public VideoTrack VideoTrack;
        public Effect Effect;

        public OFXDouble2DParameter location;

        public PictureInPicture(VideoTrack videoTrack)
        {
            VideoTrack = videoTrack;
            VideoTrack.Effects.AddEffect(GUI.Vegas.VideoFX.GetChildByName("VEGAS Picture In Picture"));
            Effect = VideoTrack.Effects[VideoTrack.Effects.Count - 1];

            location = (OFXDouble2DParameter)OFXEffect.FindParameterByName("Location");

            OFXDoubleParameter scale = (OFXDoubleParameter)OFXEffect.FindParameterByName("Scale");
            scale.Value = 1;
            scale.ParameterChanged();
        }

        public OFXEffect OFXEffect
        {
            get
            {
                return Effect.OFXEffect;
            }
        }
    }
}
