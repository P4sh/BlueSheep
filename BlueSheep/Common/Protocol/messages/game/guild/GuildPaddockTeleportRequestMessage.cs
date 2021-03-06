









// Generated on 12/11/2014 19:01:45
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GuildPaddockTeleportRequestMessage : Message
    {
        public new const uint ID =5957;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int paddockId;
        
        public GuildPaddockTeleportRequestMessage()
        {
        }
        
        public GuildPaddockTeleportRequestMessage(int paddockId)
        {
            this.paddockId = paddockId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteInt(paddockId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            paddockId = reader.ReadInt();
        }
        
    }
    
}