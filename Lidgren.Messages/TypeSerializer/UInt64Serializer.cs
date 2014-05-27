﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class UInt64Serializer : ISerializer
	{
		public override Type Target
		{
			get { return typeof(UInt64); }
		}

		public override void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((UInt64)Value);
		}

		public override object Read(Network.NetIncomingMessage nim)
		{
			return (UInt64)nim.ReadUInt64();
		}
	}
}
