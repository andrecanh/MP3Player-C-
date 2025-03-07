﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MP3_Player
{
    class mp3Player
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLenght, int hwdCallBack);

        public void open(string File)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);
        }

        public void play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }

        public void stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
        }
    }
}
