# Aq.Interop.ErrorCodes

### OS-specific error codes for .NET

```csharp
using static Aq.Interop.PlatformErrors

class Program {
  void Main() {
    int errno = ...;
    if (ENOENT == errno) {
      throw new Exception("Not Exists")
    }
  }
}
```
