using System.Collections;
using ECS.Util;

List<int> a = new() { 1, 2, 3 };
List<double> b = new() { 1, 2, 3 };
Dictionary<Type, IList> dic = new() { { a.GetType(), a }, { b.GetType(), b } };

Dictionary<int,int> dic2=new();
dic2.TryGetValue(0,out int i);
dic2.Contains(new (0,1));
i.Log();