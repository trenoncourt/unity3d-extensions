public static T AddComponentWithInit<T>(this GameObject obj, System.Action<T> onInit) where T : Component
{
    bool oldState = obj.activeSelf;
    obj.SetActive(false);
    T comp = obj.AddComponent<T>();
    if (onInit != null)
        onInit(comp);
    obj.SetActive(oldState);
    return comp;
}
