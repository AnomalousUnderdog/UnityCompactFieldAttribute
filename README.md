# UnityCompactFieldAttribute
Lets each property label have their own width, to prevent the labels from getting cut off

![Preview](/preview.gif "Preview")

## Installation
Copy the CompactField folder to your project.

## Usage
Add the CompactField attribute to your MonoBehaviour fields:

```csharp
		[CompactField]
		public float testFloat = 3.0f;

		[CompactField]
		public bool testBool;
```