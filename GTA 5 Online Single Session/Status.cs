﻿using System;
using System.Diagnostics;
using System.Linq;

namespace GTA_5_Online_Single_Session {
    class Status {
        static public int tabIndex = 0;

        static public bool overlay = false;
        static public bool applying = false;

        static public Process gameProcess = null;
        static public bool isGameRunning = false;

        static public event EventHandler onGameStatusUpdate;

        static public void updateGameStatus() {
            Process process = Process.GetProcessesByName("GTA5").FirstOrDefault();
            gameProcess = process;
            isGameRunning = process != null;
            onGameStatusUpdate?.Invoke(null, null);
        }
    }
}
