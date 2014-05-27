using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class Int64Serializer : ISerializer
	{
		public override Type Target
		{
			get { return typeof(Int64); }
		}

		public override void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((Int64)Value);
		}

		public override object Read(Network.NetIncomingMessage nim)
		{
			return (Int64)nim.ReadInt64();
		}
	}
}
