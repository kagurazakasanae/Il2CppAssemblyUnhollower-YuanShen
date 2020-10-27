using System;
using System.Runtime.InteropServices;

namespace UnhollowerBaseLib.Runtime.VersionSpecific
{
    public class Unity2018_0NativeClassStructHandler : INativeClassStructHandler
    {
        public unsafe INativeClassStruct CreateNewClassStruct(int vTableSlots)
        {
            var pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Il2CppClassU2018_0>() + Marshal.SizeOf<VirtualInvokeData>() * vTableSlots);

            *(Il2CppClassU2018_0*) pointer = default;
            
            return new Unity2018_0NativeClassStruct(pointer);
        }

        public unsafe INativeClassStruct Wrap(Il2CppClass* classPointer)
        {
            return new Unity2018_0NativeClassStruct((IntPtr) classPointer);
        }
        
        [StructLayout(LayoutKind.Sequential)]
        private struct Il2CppClassU2018_0
        {
            public Il2CppClassPart1 Part1;
            public Il2CppClassPart2 Part2;
            public byte typeHierarchyDepth; // Initialized in SetupTypeHierachy 104
            public byte genericRecursionDepth;  //105
            public byte rank;   //106
            public byte minimumAlignment; // Alignment of this type 107
            public byte packingSize;    //108
            public ClassBitfield1 bitfield_1;   //109
            public ClassBitfield2 bitfield_2;   //10a
        }

        private unsafe class Unity2018_0NativeClassStruct : INativeClassStruct
        {
            public Unity2018_0NativeClassStruct(IntPtr pointer)
            {
                //Console.WriteLine(new System.Diagnostics.StackTrace().ToString());
                //Console.WriteLine(new Il2CppSystem.Diagnostics.StackTrace().ToString());


                Pointer = pointer;
                if(Part1->byval_arg == null)
                {
                    Part1->byval_arg = (Il2CppTypeStruct*)Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Il2CppTypeStruct)));
                    //Console.WriteLine("Unity2018_0NativeClassStruct: Part1->byval_arg: 0x" + new IntPtr(Part1->byval_arg).ToString("x2"));
                }
                if (Part1->this_arg == null)
                {
                    Part1->this_arg = (Il2CppTypeStruct*)Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Il2CppTypeStruct)));
                    //Console.WriteLine("Unity2018_0NativeClassStruct: Part1->this_arg: 0x" + new IntPtr(Part1->this_arg).ToString("x2"));
                }
            }

            public IntPtr Pointer { get; }
            public Il2CppClass* ClassPointer => (Il2CppClass*) Pointer;

            public IntPtr VTable => IntPtr.Add(Pointer, Marshal.SizeOf<Il2CppClassU2018_0>());

            public Il2CppClassPart1* Part1 => &((Il2CppClassU2018_0*) Pointer)->Part1;
            public Il2CppClassPart2* Part2 => &((Il2CppClassU2018_0*) Pointer)->Part2;
            public byte* typeHierarchyDepth => &((Il2CppClassU2018_0*)Pointer)->typeHierarchyDepth;
            public byte* genericRecursionDepth => &((Il2CppClassU2018_0*)Pointer)->genericRecursionDepth;
            public byte* rank => &((Il2CppClassU2018_0*)Pointer)->rank;
            public byte* minimumAlignment => &((Il2CppClassU2018_0*)Pointer)->minimumAlignment;
            public byte* packingSize => &((Il2CppClassU2018_0*)Pointer)->packingSize;

            public ClassBitfield1* Bitfield1 => &((Il2CppClassU2018_0*)Pointer)->bitfield_1;
            public ClassBitfield2* Bitfield2 => &((Il2CppClassU2018_0*)Pointer)->bitfield_2;
        }
    }
}