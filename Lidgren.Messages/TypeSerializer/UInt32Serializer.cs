using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class UInt32Serializer : ISerializer
	{
		public override Type Target
		{
			get { return typeof(UInt32); }
		}

		public override void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((UInt32)Value);
		}

		public override object Read(Network.NetIncomingMessage nim)
		{
			return (UInt32)nim.ReadUInt32();
		}
	}
}
