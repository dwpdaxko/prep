#Rules for framework equality checking


1. Is it a class (reference type)
  * Does it implement IEquatable<T> for itself - use it
  * Does it override Equals for itself - use it
  * Reference based check

2. Is it a struct (value type)
  * Does it override Equals for itself - use it
  * Reflective field by field equality check
