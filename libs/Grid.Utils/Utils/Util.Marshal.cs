using System.Runtime.InteropServices;

namespace Grid.Utils;

using SMarshal = Marshal;

partial class Util
{
	public static class Marshal
	{
		public static T ReadUsingMarshalUnsafe<T>(byte[] data) where T : struct {
			unsafe {
				fixed (byte* p = &data[0]) {
					return SMarshal.PtrToStructure<T>(new(p));
				}
			}
		}

		public static unsafe byte[] WriteUsingMarshalUnsafe<T>(T structure) where T : struct {
			byte[] byteArray = new byte[SMarshal.SizeOf(structure)];
			fixed (byte* byteArrayPtr = byteArray) {
				SMarshal.StructureToPtr(structure, (IntPtr)byteArrayPtr, true);
			}
			return byteArray;
		}
	}
}