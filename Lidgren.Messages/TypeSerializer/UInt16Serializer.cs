﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class UInt16Serializer : ISerializer
	{
		public override Type Target
		{
			get { return typeof(UInt16); }
		}

		public override void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((UInt16)Value);
		}

		public override object Read(Network.NetIncomingMessage nim)
		{
			return (UInt16)nim.ReadUInt16();
		}
	}
}
