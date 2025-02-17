# 配置文件、存档、网络和ECS系统的桥梁

## 传统游戏流程

1. 启动
2. 加载配置文件完成初始化
3. 依赖配置信息进行世界初始化与世界活动
4. 存档将世界序列化
5. 读取存档完成世界反序列化

## 分析

都是数据，他们有什么不同

1. 配置
   受游戏设计者管理
   是游戏的内容
   可以来自网络
2. 持久化状态
   持久化状态持久化后会转化为配置，和配置的不同是，它是由程序在运行时产生的
   完全可以让游戏设计者通过编辑器产生一些持久化状态，并将这些数据作为配置，也就是游戏内容来使用
   往往需要网络同步
3. 临时状态
   临时状态可以保存吗，也许可以，但不必要
   可能不需要网络同步

## ECS应该在什么层面做这些事

1. 以实体级别决定是否序列化
   可以使用一个序列化组件作为标签
2. 在组件级别
   有的组件可能不应该保存，也不应该同步

## 几种情况

1. 读取配置/Prefab
2. 最方便的是让组件本身可以轻松序列化和反序列化。统一的编写
3. 保存游戏状态

理论上ECS可以保存所有组件状态，但是否应该这么做？
