using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Assets.Scripts.Network
{
    public struct PacketHeader
    {
        ushort size { get; set; }
        ushort id   { get; set; }

        public static int GetIdStartPos()
        {
            // id 앞에 size를 담기 위해 size 크기인 2를 반환.
            // protocol에서 다른 변수들이 헤더에 추가된다면 주의 필요.
            return 2;
        }

        public static int GetHeaderSize()
        {
            return Marshal.SizeOf< PacketHeader >();
        }
    }
}
