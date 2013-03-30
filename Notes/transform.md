## Transform Class

> [Transform](http://docs.unity3d.com/Documentation/ScriptReference/Transform.html) Position, Rotation and Scale of an object.

1. Translate(…)，Rotate(…)
> a. 第一个参数，移动或者旋转矩阵。是一个[Vecter3](http://docs.unity3d.com/Documentation/ScriptReference/Vector3.html)类型参数，分别有forward，back，right，left，up和down几种方向，请注意各种旋转的基准坐标轴，比如right和left是绕x轴旋转，up和down是沿y轴上下。
> b. 第二个参数，默认设置以物体自身的坐标轴做移动和旋转,但是还可以设置以世界坐标系为移动和旋转坐标系。一般设置为绕自身坐标系旋转，以世界坐标系进行移动。