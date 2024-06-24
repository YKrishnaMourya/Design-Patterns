Factory Pattern is a creational design pattern
Abstracting object creation from client side(decoupling objects from client side) => any new object type in library should not affect client code.

Learnings:
Enums, Enum.TryParse, Enum.TryParse always return true for interger strings {"-2", "-1",...}
interface is a contract defining the behavoir of instances or objects
interface cannot be static or static class cannot implement interface
<https://www.reddit.com/r/csharp/comments/k566x6/implementing_static_methods_on_interfaces
You don't create instances of interfaces per se. Think of an interface as a contract that defines an ability that the instance of a type has.
For example: If I have an interface IDriveable that has methods Accelerate(), Brake(), TurnLeft() and TurnRight() then I might have classes Car, Truck and Bicycle that implement that interface - what that's saying is that any instance of IDriveable (i.e. any object that implements IDriveable) can do those things.

If an interface could have a static method:
interface IFoo
{
    static void Bar();
}   
class Foo1 : IFoo
{
    public static void Bar() { ... }
}
class Foo2 : IFoo
{
    public static void Bar() { ... }
}
and you invoked it:
IFoo.Bar();
there would be no way to known which implementation you would end up calling. Would that call Foo1.Bar or Foo2.Bar?
You might decide you want it to call both implementations. Which might work, until you introduce return values
