﻿using EpinelPS.Utils;

namespace EpinelPS.LobbyServer.PartyMatch
{
    [PacketPath("/partymatch/listinvitation")]
    public class ListPartyMatchInvitations : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqListInvitation>();
            var user = GetUser();

            var response = new ResListInvitation();
            // TODO
            await WriteDataAsync(response);
        }
    }
}
