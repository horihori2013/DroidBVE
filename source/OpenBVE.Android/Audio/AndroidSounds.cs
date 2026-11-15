// Android concrete Sounds implementation - mirrors the desktop
// OpenBVE/Audio/Sounds.cs (which is internal to the desktop project).
//
// The playback engine itself lives in SoundManager.SoundsBase and runs on the
// same OpenAL API as desktop; on Android the OpenAL implementation is OpenAL
// Soft (see native/build-openal-soft.sh).

using System.Linq;
using OpenBveApi.Hosts;
using OpenBveApi.Sounds;
using OpenTK.Audio.OpenAL;
using SoundManager;
using TrainManager.Trains;

namespace DroidBVE
{
	internal class AndroidSounds : SoundsBase
	{
		public AndroidSounds(HostInterface currentHost) : base(currentHost)
		{
		}

		/// <summary>Stops all sounds that are attached to the specified train.</summary>
		public override void StopAllSounds(object train)
		{
			if (!(train is TrainBase t))
			{
				return;
			}
			for (int i = 0; i < SourceCount; i++)
			{
				if (t.Cars.Contains(Sources[i].Parent) || Sources[i].Parent == train)
				{
					if (Sources[i].State == SoundSourceState.Playing)
					{
						AL.DeleteSources(1, ref Sources[i].OpenAlSourceName);
						Sources[i].OpenAlSourceName = 0;
					}
					Sources[i].State = SoundSourceState.Stopped;
				}
			}
		}
	}
}