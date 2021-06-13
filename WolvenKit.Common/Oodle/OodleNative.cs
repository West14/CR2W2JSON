using System;
using System.Runtime.InteropServices;

namespace WolvenKit.Common.Oodle
{
    public static class OodleNative
    {
        #region enums

        public enum OodleLZ_CheckCRC : int
        {
            No = 0,
            Yes = 1,
        }

        public enum OodleLZ_Compression : int
        {
            None = 0,
            SuperFast = 1,
            VeryFast = 2,
            Fast = 3,
            Normal = 4,
            Optimal1 = 5,
            Optimal2 = 6,
            Optimal3 = 7,
            Optimal4 = 8,
            Optimal5 = 9,
        }

        public enum OodleLZ_Compressor : int
        {
            LZH = 0,
            LZHLW = 1,
            LZNIB = 2,
            None = 3,
            LZB16 = 4,
            LZBLW = 5,
            LZA = 6,
            LZNA = 7,
            Kraken = 8,
            Mermaid = 9,
            BitKnit = 10,
            Selkie = 11,
            Akkorokamui = 12,
        }

        public enum OodleLZ_Decode : int
        {
            ThreadPhase1 = 1,
            ThreadPhase2 = 2,
            Unthreaded = 3,
        }

        public enum OodleLZ_FuzzSafe : int
        {
            No = 0,
            Yes = 1,
        }

        public enum OodleLZ_Verbosity : int
        {
            None = 0,
        }

        #endregion enums

        #region windows

        [DllImport("oo2ext_7_win64.dll", EntryPoint = "OodleLZ_Compress", CallingConvention = CallingConvention.StdCall)]
        public static extern long Compress(
            int algorithm,
            IntPtr inputBuffer,
            long inputSize,
            IntPtr outputBuffer,
            int level,
            IntPtr a6,
            IntPtr a7,
            IntPtr a8,
            IntPtr a9,
            long a10);

        [DllImport("oo2ext_7_win64.dll", EntryPoint = "OodleLZ_GetCompressedBufferSizeNeeded", CallingConvention = CallingConvention.StdCall)]
        public static extern long GetCompressedBufferSizeNeeded(long size);

        [DllImport("oo2ext_7_win64.dll")]
        public static extern int OodleLZ_Decompress(byte[] buffer, long bufferSize, byte[] outputBuffer, long outputBufferSize,
            OodleLZ_FuzzSafe fuzzSafetyFlag,
            OodleLZ_CheckCRC crcCheckFlag,
            OodleLZ_Verbosity logVerbosityFlag,
            uint d, uint e, uint f, uint g, uint h, uint i, OodleLZ_Decode threadModule);

        #endregion windows
    }
}
