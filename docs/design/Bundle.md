# Bundle
## Description
1. Bundle是一个数据结构，用于打包Component，方便用户使用，用户根据插件的需要可以快速的加入合适的Bundle，而不需要一个一个的加入Component。
2. Bundle应该是一种结构体，不能继承，但可以组合，可以包含Component，也可以包含其他的Bundle，
3. Bundle最好是一个不可变的数据结构，不能修改，只能创建新的Bundle。
## Examples
### Declare
```csharp
public record struct MyBundle() : Bundle
```
```csharp


command.CreateEntity();
```