using System;
using MSR.LST.Net.Rtp;
using MSR.LST;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace ArchiveTranscoder
{
	/// <summary>
	/// Test code
	/// </summary>
	public class Test
	{
		public Test() { }

        #region Test Code

        public static void CheckAzureDBConnectivity() {
            DatabaseUtility.SQLConnectionString = "Data Source=tczxnf5cbu.database.windows.net;Initial Catalog=ArchiveService;Integrated Security=false;User ID=cxp;Password=ConferenceXP!";
            if (DatabaseUtility.CheckConnectivity()) {
                Debug.WriteLine("Azure database is alive.");
                Conference[] confs = DatabaseUtility.GetConferences();
            }
            else {
                Debug.WriteLine("Azure database is not alive.");
            }
        }

        /// <summary>
        /// Read from a stream and attempt to find various issues.
        /// </summary>
        /// <param name="streamId"></param>
        /// <param name="durationSeconds"></param>
        public static void VerifyStream(int streamId, int durationSeconds) {
            DBStreamPlayer streamPlayer = new DBStreamPlayer(streamId, (long)durationSeconds * (long)Constants.TicksPerSec, PayloadType.dynamicVideo);
            Console.WriteLine("VerifyStream: streamID=" + streamId.ToString() + 
                "; requested duration Ticks=" + ((long)durationSeconds * (long)Constants.TicksPerSec).ToString());
            verifyStream(streamPlayer);
        }

         public static void VerifyStream(int streamId, DateTime startTime, DateTime endTime) {
            DBStreamPlayer streamPlayer = new DBStreamPlayer(streamId, startTime.Ticks, endTime.Ticks, PayloadType.dynamicVideo);
            Console.WriteLine("VerifyStream: streamID=" + streamId.ToString() +
                "; Start=" + startTime.ToString() + "; End=" + endTime.ToString());
            verifyStream(streamPlayer);
        }
        
        private static void verifyStream(DBStreamPlayer streamPlayer) {
            BufferChunk frame;
            long streamTime;
            BufferChunk sample;
            bool keyframe;
            long refTime = 0;
            long lastStreamTime = 0;
 
            while (streamPlayer.GetNextFrame(out frame, out streamTime)) {
                try {
                    sample = ProfileUtility.FrameToSample(frame, out keyframe);
                }
                catch (Exception ex) {
                    DateTime dt = new DateTime(streamTime);
                    Console.WriteLine("FrameToSample failed at: " + dt.ToString() + "; Sampletime=" + streamTime.ToString());                    
                    Console.WriteLine(ex.ToString());
                    continue;
                }
                if (refTime == 0)
                    refTime = streamTime;
                    //DateTime dt = new DateTime(streamTime);
                    //Console.WriteLine("Sample: " + dt.ToString() + "; Sampletime=" + streamTime.ToString() + "; length=" + sample.Length.ToString());                    Console.WriteLine(ex.ToString());

                lastStreamTime = streamTime;
            }

            DateTime dt1 = new DateTime(refTime);
            DateTime dt2 = new DateTime(lastStreamTime);
            Console.WriteLine("Started at " + dt1.ToString() + "; Ended at " + dt2.ToString() + " (" + lastStreamTime.ToString() + " ticks)" + 
                " after duration ticks =" + (lastStreamTime - refTime).ToString());
        }

        #endregion Test Code
    }
}