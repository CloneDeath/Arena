using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Network;

namespace Lidgren.Messages
{
	abstract class ISerializer
	{
		public abstract Type Target
		{
			get;
		}

		public virtual bool IsAssignableFrom(Type Value)
		{
			return Target.IsAssignableFrom(Value);
		}

		public abstract void Write(NetOutgoingMessage nom, object Value);
		public abstract object Read(NetIncomingMessage nim);
	}
}
