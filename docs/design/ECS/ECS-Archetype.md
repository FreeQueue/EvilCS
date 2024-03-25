# 构建原型ECS

## 设想使用方式

### 创建组件

```csharp
[Storage(StorageType.Table)] // 可选，默认为Table
public record struct Transform(
    float X,
    float Y,
    float Z,
    float W
):IComponent{
    Vector3 Location=>...//也许可用Union的方式
    Vector3 Rotate=>...
}

[Storage(StorageType.SparseSet)]
public record struct Velocity:IComponent{
    Vector3 value;

    public static implicit operator Vector3(Velocity source){
        return source.value;
    } 
}

```
### 创建系统
```csharp
[Systems]
public static class MovementSystems{

    private NPC NPCFilterValue=new(walking:true);

    [Tag]//标识，用于系统排序，默认产生的Tag为“类名.方法名”
    [With<NPC>,Without<Freeze>]
    [Invoke<Update>]
    public static void Walk(
        Query<(Ref<Transform> transform,Velocity velocity)> q,
        Res<Time> time){
            foreach((Ref<Transform> transform,Velocity velocity) in q){

                //transform是可以被赋值的
            }
    }

    [Tag]
    [Active(false)]//默认为关闭的系统
    [Invoke<Start>]
    public static void Test(){

    } 
}

[Tag]//为所有子系统添加Tag？
[Systems]
public static class TestSystems{
    
}
```
### 排布系统
```csharp
```
## 生成原型ID

使用ComponentId组成的列表作为键

## 组合

## 引用
1.ref Query<T1,T2,..> 实现多个重载
2.World 作为参数输入Query的方法中，用于传递引用
3.使用RAII，在方法退出时进行更新

