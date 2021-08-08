using System;
using System.Collections.Generic;
using ScriptPortal.Vegas;
using System.Windows.Forms;

namespace Vegas_Chromatic_Aberration
{
    static class ChromaticAberration
    {
        private static readonly string[] channelNames = { "RED", "GREEN", "BLUE" };
        public static void Apply()
        {
            VideoTrack track2 = GUI.Vegas.Project.AddVideoTrack();
            VideoTrack track1 = GUI.Vegas.Project.AddVideoTrack();
            VideoTrack parentTrack = GUI.Vegas.Project.AddVideoTrack();

            track1.CompositeNestingLevel = 1;
            track2.CompositeNestingLevel = 1;

            parentTrack.Name = "Chromatic Aberration";


            track1.CompositeMode = CompositeMode.Add;
            track2.CompositeMode = CompositeMode.Add;

            PictureInPicture(track1, SettingControl.SettingControls["Horizontal Offset"].Value + 0.5, SettingControl.SettingControls["Vertical Offset"].Value + 0.5);
            PictureInPicture(track2, -SettingControl.SettingControls["Horizontal Offset"].Value + 0.5, -SettingControl.SettingControls["Vertical Offset"].Value + 0.5);

            List<string> nonTargetChannels = new List<string>();
            foreach(KeyValuePair<string, RadioButton> channelButton in GUI.channelButtons)
            {
                if (channelButton.Value.Checked)
                {
                    ChannelBlend(track1, channelButton.Key);
                    ChannelBlend(track2, channelButton.Key, true);

                    track1.Name = channelButton.Key;
                }
                else
                {
                    nonTargetChannels.Add(channelButton.Key);
                }
            }
            track2.Name = string.Join(" & ", nonTargetChannels);
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

        private static void ChannelBlend(VideoTrack videoTrack, string channelName, Boolean everythingExcept = false)
        {
            videoTrack.Effects.AddEffect(GUI.Vegas.VideoFX.GetChildByName("VEGAS Channel Blend"));
            OFXEffect ofxEffect = videoTrack.Effects[videoTrack.Effects.Count - 1].OFXEffect;

            foreach (string currentName in channelNames)
            {
                double weight = 0;
                if ((!everythingExcept && currentName.Equals(channelName)) || (everythingExcept && !currentName.Equals(channelName)))
                {
                    weight = 1;
                }

                OFXDoubleParameter parameter = (OFXDoubleParameter)ofxEffect.FindParameterByName(currentName + " weight " + currentName.Substring(0, 1));
                parameter.Value = weight;
                parameter.ParameterChanged();
            }
        }
    }
}
