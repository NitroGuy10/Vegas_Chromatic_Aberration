using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptPortal.Vegas;

namespace Vegas_Chromatic_Aberration
{
    static class ChromaticAberration
    {
        public static void Apply()
        {
            VideoTrack track3 = GUI.Vegas.Project.AddVideoTrack();
            VideoTrack track2 = GUI.Vegas.Project.AddVideoTrack();
            VideoTrack track1 = GUI.Vegas.Project.AddVideoTrack();
            VideoTrack parentTrack = GUI.Vegas.Project.AddVideoTrack();

            track1.CompositeNestingLevel = 1;
            track2.CompositeNestingLevel = 1;
            track3.CompositeNestingLevel = 1;

            parentTrack.Name = "Chromatic Aberration";
            

            track1.CompositeMode = CompositeMode.Add;
            track2.CompositeMode = CompositeMode.Add;
            track3.CompositeMode = CompositeMode.Add;

            PictureInPicture(track1, SettingControl.SettingControls["Horizontal Offset"].Value + 0.5, SettingControl.SettingControls["Vertical Offset"].Value + 0.5);
            PictureInPicture(track3, -SettingControl.SettingControls["Horizontal Offset"].Value + 0.5, -SettingControl.SettingControls["Vertical Offset"].Value + 0.5);

            // TODO name tracks and apply appropriate channel blend settings to match the state of the GUI's checkboxes
            ChannelBlend(track1, "TODO");
            ChannelBlend(track2, "TODO");
            ChannelBlend(track3, "TODO");
            track1.Name = "Red";
            track2.Name = "Green";
            track3.Name = "Blue";
        }

        private static void PictureInPicture(VideoTrack videoTrack, double x, double y)
        {
            videoTrack.Effects.AddEffect(GUI.Vegas.VideoFX.GetChildByName("VEGAS Picture In Picture"));
            OFXEffect ofxEffect = videoTrack.Effects[videoTrack.Effects.Count - 1].OFXEffect;

            OFXDoubleParameter scale = (OFXDoubleParameter)ofxEffect.FindParameterByName("Scale");
            scale.Value = 1;
            scale.ParameterChanged();

            OFXDouble2DParameter location = (OFXDouble2DParameter)ofxEffect.FindParameterByName("Location");
            OFXDouble2D newLocation = new OFXDouble2D();
            newLocation.X = x;
            newLocation.Y = y;
            location.Value = newLocation;
            location.ParameterChanged();
        }

        private static void ChannelBlend(VideoTrack videoTrack, string channelName)
        {
            // TODO apply Channel Blend effect
        }
    }
}
