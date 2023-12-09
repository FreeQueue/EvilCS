namespace Grid.Utils;

public class TypeValueDic
{
	private TypeSet TypeSet;
	private Dictionary<Type, object> _dic = new();
	
	public T Get<T>() {
		return (T)_dic[typeof(T)];
	}
}