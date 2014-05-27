using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class EnumSerializer : ISerializer
	{
		public override Type Target
		{
			get { return typeof(Enum); }
		}

		public override bool IsAssignableFrom(Type Value)
		{
			return Value.IsEnum;
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
