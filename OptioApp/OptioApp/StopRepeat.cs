using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace OptioApp
{
    class StopRepeat
    {
        OptioForm of;
        public StopRepeat(OptioForm of)
        {
            this.of = of;
        }
        public void optio_SpeakStarted(object sender, SpeakStartedEventArgs e) //To stop system repeating itself(from declarations above)
        {
            of.speechreco.RecognizeAsyncStop();
        }

        public void optio_SpeakCompleted(object sender, SpeakCompletedEventArgs e)//To stop system repeating itself(from declarations above)
        {
            of.speechreco.RecognizeAsync(RecognizeMode.Multiple);
        }
    }
}
