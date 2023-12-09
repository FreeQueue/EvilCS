using Grid.ECS.Storage;
using Grid.Utils;
using Xunit;

namespace Grid.ECS.Playground.Test;

public class TableTest
{
	Table _table= new(TypeSet.Get(typeof(int),typeof(string)));
	
	[Fact]
	public void Add() {
		// var row = _table.Add(Entity.Empty);
		// Assert.Equal(0, row);
		// Assert.Single(_table.Entities);
		// Assert.Equal(Entity.Empty, _table.Entities[row]);
		// Assert.Equal(0, _table.GetColumn<int>()[row]);
		// Assert.Null(_table.GetColumn<string>()[row]);
	}
}