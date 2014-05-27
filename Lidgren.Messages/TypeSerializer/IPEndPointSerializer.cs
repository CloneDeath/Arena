using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Lidgren.Messages.TypeSerializer
{
	class IPEndPointSerializer : ISerializer
	{
		public override Type Target
		{
			get { return typeof(IPEndPoint);  }
		}

		public override void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((IPEndPoint)Value);
		}

		public override object Read(Network.NetIncomingMessage nim)
		{
			return nim.ReadIPEndPoint();
		}
	}
}
