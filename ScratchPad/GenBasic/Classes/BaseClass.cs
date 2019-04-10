namespace GenBasic.Classes
{
    public abstract class BaseClass<T> { }

    public class NonGenericChild : BaseClass<int> { } //non generic inheriting from a generic class

    public class GenericChild<T> : BaseClass<T> { } //generic child passes on to base

    public class GenericChildWithAdditionalType<TAdditional> : BaseClass<string> { } 

    //more complex
    public class ComplexBaseClass<TDiagram, TSchema> { }
    public class OneTypeSpecified<TSchema> : ComplexBaseClass<WireDiagram, TSchema> { }
    public class BothTypesSpecified : ComplexBaseClass<WireDiagram, NormalSchema> { }



    //------------------------------------------
    public class WireDiagram { }
    public class NormalSchema { }

}
