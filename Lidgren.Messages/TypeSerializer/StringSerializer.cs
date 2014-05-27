using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class StringSerializer : ISerializer
	{
		public override Type Target
		{
			get { return typeof(String); }
		}

		public override void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((String)Value);
		}

		public override object Read(Network.NetIncomingMessage nim)
		{
			return nim.ReadString();
		}
	}
}
