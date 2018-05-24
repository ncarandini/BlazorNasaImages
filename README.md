# BlazorNasaImages
A sample Blazor app that use the Open Data Nasa APIs to fetch images from the Nasa Astronomy Picture of the Day service.

### Points of interest
1. Simple dinamic page layout change with a one-way binding to a boolean field and two components:

```
@if (cardView)
{
    <ImageCards NasaImageInfoList="@nasaImageInfoList" />
}
else
{
    <ImageList NasaImageInfoList="@nasaImageInfoList" />
}
```

2. Use of the Javascript interop to write on the browser console the error message object in case of error:

```
// FetchNasaImages.cshtml
...
catch (Exception ex)
{
    RegisteredFunction.Invoke<bool>("consoleLog", ex);
}
...
```

```
// Index.html (in wwwroot)
...
<script>
    // Register a Javascript function
    Blazor.registerFunction('consoleLog', (data) => {
        console.dir(data);
        return true;
    });
</script>
```
(from the example of Javascript interopt found in the [Learn Blazor site](https://learn-blazor.com/architecture/interop/)).

Here's the result:
![image](https://user-images.githubusercontent.com/139274/40505385-4fdee964-5f94-11e8-909b-1c428da51020.png)

### ApiKey
The key used in the source is an anonymous one (DEMO_KEY).
Beware that this anonymous key has big usage restrictions, please get your free apiKey at https://api.nasa.gov/index.html#apply-for-an-api-key

### Screenshots
![image](https://user-images.githubusercontent.com/139274/40503240-b838a09c-5f8d-11e8-8b67-1a09ce7e90f0.png)

![image](https://user-images.githubusercontent.com/139274/40503299-ee137994-5f8d-11e8-880c-5b80f3b4b1d6.png)

![image](https://user-images.githubusercontent.com/139274/40503549-bb897e8c-5f8e-11e8-9595-1a1eb0f767ef.png)
