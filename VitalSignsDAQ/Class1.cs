using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.DirectX.DirectSound;

namespace VitalSignsDAQ
{
    public class Class1
    {
        private const int SAMPLES = 1;
        private static int[] SAMPLE_FORMAT_ARRAY = { SAMPLES, 1, 1 };

        /// <summary>
        /// Pequeno teste conceitual utilizando a placa de som padrao
        /// </summary>
        public void teste()
        {

            Capture cap = new Capture(new DeviceInformation().DriverGuid);
            CaptureBufferDescription desc = new CaptureBufferDescription();
            CaptureBuffer buffer;

            WaveFormat wf = new WaveFormat();
            wf.BitsPerSample = 16;
            wf.SamplesPerSecond = 44100;
            wf.Channels = 2;
            wf.BlockAlign = (short)(wf.Channels * wf.BitsPerSample / 8);
            wf.AverageBytesPerSecond = wf.BlockAlign * wf.SamplesPerSecond;
            wf.FormatTag = WaveFormatTag.Pcm;

            desc.Format = wf;
            desc.BufferBytes = SAMPLES * wf.BlockAlign;

            

            buffer = new Microsoft.DirectX.DirectSound.CaptureBuffer(desc, cap);
            buffer.Start(true);

        zed:
            Array samples = buffer.Read(0, typeof(Int16), LockFlag.FromWriteCursor, SAMPLE_FORMAT_ARRAY);
            System.Console.WriteLine(samples.GetValue(0,0,0).ToString());

            goto zed;

            
        }
    }
}
