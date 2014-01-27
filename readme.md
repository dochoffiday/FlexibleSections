FlexibleSections
===============

An improvement upon ASP.NET MVC Sections.

Usage
---------------

```csharp
<!DOCTYPE html>
<html lang="en">
<head>
    <title>@ViewBag.Title</title>
    @this.Section("header")
</head>
<body>
    @this.Section("prebody")

	@RenderBody()
		
    @this.Section("footer")
</body>
</html>
```

```csharp
@using(this.AddToSection("footer"))
{
    <script src="//js.stripe.com/v2/" type="text/javascript"></script>
}
```