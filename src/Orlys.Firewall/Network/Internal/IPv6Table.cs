﻿// Author: Orlys
// Github: https://github.com/Orlys
namespace Orlys.Network.Internal
{
    using System.Runtime.InteropServices;

    // https://docs.microsoft.com/en-us/windows/win32/api/tcpmib/ns-tcpmib-mib_tcp6table_owner_pid
    [StructLayout(LayoutKind.Sequential)]
    internal struct IPv6Table
    {
        private uint _dwNumEntries;

        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.Struct, SizeConst = 1)]
        private IPv6Row[] _table;
    }
}