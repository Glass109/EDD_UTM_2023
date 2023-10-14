using System.Drawing;
using Console = Colorful.Console;


List<char> chars = new List<char>()
{
	'r', 'e', 'x', 's', 'z', 'q', 'j', 'w', 't', 'a', 'b', 'c', 'l', 'm',
	'r', 'e', 'x', 's', 'z', 'q', 'j', 'w', 't', 'a', 'b', 'c', 'l', 'm',
	'r', 'e', 'x', 's', 'z', 'q', 'j', 'w', 't', 'a', 'b', 'c', 'l', 'm',
	'r', 'e', 'x', 's', 'z', 'q', 'j', 'w', 't', 'a', 'b', 'c', 'l', 'm'
};
Console.WriteWithGradient(chars, Color.Yellow, Color.Fuchsia, 14);