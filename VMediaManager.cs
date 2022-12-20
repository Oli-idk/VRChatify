﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsMediaController.MediaManager;
using WindowsMediaController;

namespace VRChatify
{
    public class VMediaManager
    {

        private static readonly MediaManager mediaManager = new MediaManager();
        #nullable enable
        private static MediaSession? currentSession = null;
        #nullable disable

        public void Init()
        {
            mediaManager.Start();
            mediaManager.OnAnySessionOpened += MediaManager_OnAnySessionOpened;
            mediaManager.OnAnySessionClosed += MediaManager_OnAnySessionClosed;
        }

        private void MediaManager_OnAnySessionOpened(MediaSession mediaSession)
        {
            VRChatifyUtils.DebugLog($"Session Opened: {mediaSession.Id}");
            VRChatify.GetMainWindow().UpdateSessionList();
        }

        private void MediaManager_OnAnySessionClosed(MediaSession mediaSession)
        {
            VRChatifyUtils.DebugLog($"Session Closed: {mediaSession.Id}");
            VRChatify.GetMainWindow().UpdateSessionList();
        }

        public MediaSession GetCurrentSession()
        {
            if (currentSession == null)
            {
                try
                {
                    return currentSession = mediaManager.CurrentMediaSessions.First().Value;
                }
                catch (InvalidOperationException)
                {
                    VRChatifyUtils.DebugLog("No session found");
                    return null;
                }
            }
            return currentSession;
        }

        public string GetSongName()
        {
            var songInfo = GetCurrentSession()?.ControlSession.TryGetMediaPropertiesAsync().GetAwaiter().GetResult();
            if (songInfo != null)
            {
                return songInfo.Title;
            }
            return "Unable to get Title";
        }

        public string GetSongArtist()
        {
            var songInfo = GetCurrentSession()?.ControlSession.TryGetMediaPropertiesAsync().GetAwaiter().GetResult();
            if (songInfo != null)
            {
                return songInfo.Artist;
            }
            return "Unable to get Author";
        }

        public string GetAlbumTitle()
        {
            var songInfo = GetCurrentSession()?.ControlSession.TryGetMediaPropertiesAsync().GetAwaiter().GetResult();
            if (songInfo != null)
            {
                return songInfo.AlbumTitle;
            }
            return "Unable to get Author";
        }

        public string GetAlbumTrackCount()
        {
            var songInfo = GetCurrentSession()?.ControlSession.TryGetMediaPropertiesAsync().GetAwaiter().GetResult();
            if (songInfo != null)
            {
                return songInfo.AlbumTrackCount.ToString();
            }
            return "Unable to get Author";
        }

        public MediaManager GetMediaManager()
        {
            return mediaManager;
        }

        public void setCurrentSession(MediaSession session)
        {
            currentSession = session;
        }
    }
}
