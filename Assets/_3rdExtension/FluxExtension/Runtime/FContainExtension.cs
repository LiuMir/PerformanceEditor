using Flux;

public static class FContainExtension 
{
    // 通过key获取FContainer上的自定义参数
    public static ContainParamBase GetCustomParam(this FContainer fContainer, string key)
    {
        fContainer.ParamDic.TryGetValue(key, out ContainParamBase param);
        return param;
    }

    // 给FContainer添加上自定义参数
    public static void AddCustomParam(this FContainer fContainer, string key, ContainParamBase param)
    {
        fContainer.ParamDic.AddKeyAndValue(key, param);
    }
}
