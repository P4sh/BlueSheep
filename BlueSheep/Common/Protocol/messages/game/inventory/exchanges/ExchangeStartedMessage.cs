









// Generated on 12/11/2014 19:01:52
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ExchangeStartedMessage : Message
    {
        public new const uint ID =5512;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public sbyte exchangeType;
        
        public ExchangeStartedMessage()
        {
        }
        
        public ExchangeStartedMessage(sbyte exchangeType)
        {
            this.exchangeType = exchangeType;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteSByte(exchangeType);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            exchangeType = reader.ReadSByte();
        }
        
    }
    
}