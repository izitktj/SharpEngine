# SharpEngine
Terminal C# engine (Development)

# WARNING
## Try diferent fonts, for me, rastering font is soo slow

# Buffer functions

* `updateChar` - Add a char to buffer.

* `updateText` - Add a string (or multiple chars) to buffer.

* `updateQuad` - Add a quad (also multiple chars) to buffer.

* `drawBuffer` - Draw on console everything saved in buffer array.

* `Clear` - Clear buffer array.

# Examples

## `updateChar`

```csharp
Buffer.updateChar('#', 5, 2);
```
Output:
![image](https://github.com/izitktj/SharpEngine/assets/75653878/d209b88e-d46a-41e4-9c48-f1752772940d)

## `updateText`

```csharp
Buffer.updateText("I love bananas", 1, 3);
```
Output:
![image](https://github.com/izitktj/SharpEngine/assets/75653878/623538db-4acf-48b6-a571-0d7dbebcf1d5)

## `updateQuad`

```csharp
char[] beatyQuad = 
{
    '0', '0', '0', '0',
    '0', '0', '0', '0',
    '0', '0', '0', '0',
    '0', '0', '0', '0'
};

Buffer.updateQuad(beatyQuad, 5, 5, 9, 9);
```
Output:
![image](https://github.com/izitktj/SharpEngine/assets/75653878/dbf04c7f-cdba-451c-bc4d-07ea497ed38d)

