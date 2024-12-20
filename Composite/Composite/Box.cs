using System.Collections.Generic;

public class Box : Component
{
    private List<Component> _components = new List<Component>();

    public Box (string name)
    {
        base.name = name;
    }

    public void AddComponent(Component component)
    {
        _components.Add(component);
    }

    public void RemoveComponent(Component component)
    {
        _components.Remove(component);
    }

    public override decimal GetPrice()
    {
        decimal total = 0;
        foreach (var component in _components)
        {
            total += component.GetPrice();
        }
        return total;
    }
}
