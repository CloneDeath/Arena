using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class Int32Serializer : ISerializer
	{
		public override Type Target
		{
			get { return typeof(Int32); }
		}

		public override void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((Int32)Value);
		}

		public override object Read(Network.NetIncomingMessage nim)
		{
			return (Int32)nim.ReadInt32();
		}
	}
}
