namespace Grid.Utils;

public static partial class Util
{
	public static class Hash
	{
		private const int Prime = 53;

		public static int Combine(IEnumerable<int> ints) {
			int power = 1;
			int hashCode = 0;
			unchecked {
				foreach (int i in ints) {
					power *= Prime;
					hashCode += i * power;
				}
			}
			return hashCode;
		}
	}
}