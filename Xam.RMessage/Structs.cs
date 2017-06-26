using System;
using ObjCRuntime;

namespace Xam.RMessage
{

	[Native]
	public enum RMessageType : long
	{
	    Normal = 0,
	    Warning,
	    Error,
	    Success,
	    Custom
	}

	[Native]
	public enum RMessagePosition : long
	{
	    Top = 0,
	    NavBarOverlay,
	    Bottom
	}

	[Native]
	public enum RMessageDuration : long
	{
	    Automatic = 0,
	    Endless = -1
	}
}
