﻿namespace TraktRater.UI
{
    using System;
    using System.Drawing;

    using global::TraktRater.Logger;

    delegate void UpdateProgressDelegate(string message, bool error);

    public static class UIUtils
    {
        public static void UpdateStatus(string message, params object[] args)
        {
            try
            {
                UpdateStatus(string.Format(message, args), false);
            }
            catch (FormatException)
            {
                // we parsed a badly formatted string in the string format
                return;
            }
        }

        public static void UpdateStatus(string message, bool error = false)
        {
            // if (Program.MainWindow.InvokeRequired)
            // {
            //     UpdateProgressDelegate updateProgress = UpdateStatus;
            //     object[] args = { message, error };
            //     Program.MainWindow.Invoke(updateProgress, args);
            //     return;
            // }

            // Program.MainWindow.lblStatusMessage.Text = message;
            // Program.MainWindow.lblStatusMessage.ForeColor = error ? Color.Red : Color.Black;

            // if (!error)
            //     FileLog.Info(message);
            // else
            //     FileLog.Error(message);
        }
    }
}
