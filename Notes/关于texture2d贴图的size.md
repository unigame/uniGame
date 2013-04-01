## 关于Texture2D贴图的Size

* Unity会自动调整贴图的大小为2的n次方,原因说是为了使用更少的显存和GPU读取更快，具体参考[Texture2D Size](http://docs.unity3d.com/Documentation/Manual/Textures.html#texturesizes)

> 当然，在程序中，为了使用Non power of 2的贴图，可以通过再Inspector中调整Texture Type为Advanced，然后设置Non Power of 2为None.