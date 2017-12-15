using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX.DirectSound;

namespace VitalSigns.DAQ
{
    public abstract class VitalSignBase
    {
        #region Properties
        private string signalName;
        private Guid deviceGuid;
        private string deviceName;
        private short bitsPerSample;
        private int sampleRate;
        private short channels;
        
        private bool start;
        private const int SAMPLES = 8;
        private static int[] SAMPLE_FORMAT_ARRAY = { SAMPLES, 1, 1 };

        public string SignalName
        {
            get { return signalName; }
            set { signalName = value; }
        }
        public Guid DeviceGuid
        {
            get { return deviceGuid; }
            set { deviceGuid = value; }
        }
        public string DeviceName
        {
            get { return deviceName; }
            set { deviceName = value; }
        }
        public short BitsPerSample
        {
            get { return bitsPerSample; }
            set { bitsPerSample = value; }
        }
        public int SampleRate
        {
            get { return sampleRate; }
            set { sampleRate = value; }
        }
        public short Channels
        {
            get { return channels; }
            set { channels = value; }
        }


        #endregion


        public VitalSignBase() { }

        public void StartCapture()
        {
            start = true;
        }

        public void StopCapture()
        {
            start = false;
        }

        private Capture cap;
        private CaptureBufferDescription desc;
        private CaptureBuffer buffer;

        public float GetSignFromDevice(out float response) 
        {
            cap = new Capture(deviceGuid);
            desc = new CaptureBufferDescription();

            WaveFormat wf = new WaveFormat();
            wf.BitsPerSample = bitsPerSample;
            wf.SamplesPerSecond = sampleRate;
            wf.Channels = channels;
            wf.BlockAlign = (short)(wf.Channels * wf.BitsPerSample / 8);
            wf.AverageBytesPerSecond = wf.BlockAlign * wf.SamplesPerSecond;
            wf.FormatTag = WaveFormatTag.Pcm;

            desc.Format = wf;
            desc.BufferBytes = SAMPLES * wf.BlockAlign;

            buffer = new Microsoft.DirectX.DirectSound.CaptureBuffer(desc, cap);
            buffer.Start(true);

            while (start)
            {
                Array samples = buffer.Read(0, typeof(Int16), LockFlag.FromWriteCursor, SAMPLE_FORMAT_ARRAY);
                response = ((float)samples.GetValue(0, 0, 0)) / 100;
            }
            response = 0.0f;
            return 0.0f;
        }
    }
}
