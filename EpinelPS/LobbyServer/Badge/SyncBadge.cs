﻿using EpinelPS.Utils;

namespace EpinelPS.LobbyServer.Badge
{
    [PacketPath("/badge/sync")]
    public class SyncBadge : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqSyncBadge>();

            var response = new ResSyncBadge();
            await WriteDataAsync(response);
        }
    }
}