The implicit and explicit keywords in C# are used when declaring conversion operators. Let's say that you have the following class:

```cs
public class Role
{
    public string Name { get; set; }
}
```
If you want to create a new `Role` and assign a `Name` to it, you will typically do it like this:

```cs
Role role = new Role();
role.Name = "RoleName";
```

Since it has only one property, it would perhaps be convenient if we could instead do it like this:

```cs
Role role = "RoleName";
```

This means that we want to *implicitly* convert a string to a `Role` (since there is no specific cast involved in the code). To achieve this, we add an implicit conversion operator:

```cs
public static implicit operator Role(string roleName)
{
    return new Role() { Name = roleName };
}
```
Another option is to implement an explicit conversion operator:

```cs
public static explicit operator Role(string roleName)
{
    return new Role() { Name = roleName };
}
```

In this case, we cannot implicitly convert a string to a `Role`, but we need to cast it in our code:

```cs
Role r = (Role)"RoleName";
```

---

Fuente: https://stackoverflow.com/a/1176680