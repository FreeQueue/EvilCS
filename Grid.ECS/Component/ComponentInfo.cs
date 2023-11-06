global using ComponentId=System.Int32;
namespace Grid.ECS;


public readonly record struct ComponentInfo(ComponentId Id, ComponentDescriptor Descriptor)
{
    
}