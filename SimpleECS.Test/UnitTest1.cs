using NUnit.Framework.Interfaces;

namespace SimpleECS.Test;

public class Tests
{
    private World world;

    [SetUp]
    public void Setup() {
        world = World.Create("My World"); // naming the world is optional
        world.OnSet((ref int new_value) =>
            TestContext.WriteLine($"an entity set an int to {new_value}"));

        // if you need the invoking entity, put it as the first parameter
        world.OnSet((Entity entity, ref int new_value) =>
            TestContext.WriteLine($"{entity} set int to {new_value}"));

        // if you need the previous value, simply put it between the entity
        // and the new value without any modifiers.
        // if the component did not have an old component, it'll be set to default
        world.OnSet((Entity entity, int old_value, ref int new_value) =>
            TestContext.WriteLine($"{entity} set int {old_value} to {new_value}"));

        // the callback is invoked whenever an entity in the world with the component removes the component or is destroyed
        world.OnRemove((int val) =>
            TestContext.WriteLine($"an entity removed int {val}"));

        // put the entity as the first paramter to get the invoking entity
        world.OnRemove((Entity e, int val) =>
            TestContext.WriteLine($"{e} removed int {val}"));
    }

    [Test]
    public void Test1() {
        var entity = world.CreateEntity("my entity", 3, 5f);
        if (!entity) Assert.Fail();
        if (!entity.Has<int>()) Assert.Fail();
        ref int v = ref entity.Get<int>();
        Assert.That(v, Is.EqualTo(3));
        entity.Set(5).Set("my entity2");
        Assert.That(v, Is.EqualTo(5));

        if (entity.TryGet(out int value)) {
            entity.Set(value + 4);
        }

        entity.Remove<int>();
        entity.Destroy();
        var newWorld = World.Create("new World");
        entity.Transfer(newWorld);
        entity.GetAllComponents();
        entity.GetAllComponentTypes();
        
    }
}