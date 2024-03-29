﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class DoubleSerializer : ISerializer
	{
		public override Type Target
		{
			get { return typeof(Double); }
		}

		public override void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((Double)Value);
		}

		public override object Read(Network.NetIncomingMessage nim)
		{
			return nim.ReadDouble();
		}
	}
}
