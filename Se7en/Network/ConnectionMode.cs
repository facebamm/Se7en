﻿namespace Se7en.Network {

    public enum ConnectionMode : byte {
        TcpIpStream = 0x1,
        TcpIpPortBinding = 0x2,
        UdpAssociate = 0x3
    }
}